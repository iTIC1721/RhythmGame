using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Crosstales.FB;
using System.IO;
using NAudio.Wave;

public class MoodManager : MonoBehaviour {

	#region PUBLIC VAR
	// 비주얼라이저용 큐브를 담을 부모 오브젝트
	public Transform cubeParent;
	// Output Detection 비주얼라이저용 큐브 프리팹
	public GameObject prefabObject;
	// 메인 카메라
	public Camera mainCamera;
	// 오디오 소스
	public AudioSource audioSource;
	// SubBandBeatDetection
	public SubbandBeatDetection subbandBeatDetection;
	// 텍스트 UI
	[Header("UI Object")]
	public Text uText;

	public GameObject selectAudioUI;
	#endregion

	#region PRIVATE / PUBLIC VAR
	// 모든 큐브에 대응하는 CubeSound를 담을 배열
	private CubeSound[] cubeSounds;
	// Output Detection에 사용될 큐브 오브젝트
	private GameObject outputCube;

	[System.NonSerialized]
	public float beatAmount;
	private float outputAmount;

	private float[] spectrumData0 = new float[1024];
	private float[] spectrumData1 = new float[1024];

	// 0번 채널의 OutputData를 담는 배열
	private float[] outputData0 = new float[1024];
	// 1번 채널의 OutputData를 담는 배열
	private float[] outputData1 = new float[1024];

	private float instantEnergy = 0;

	private float[] historyBuffer = new float[43];
	private bool isTimePassed = true;
	private IEnumerator timePassCoroutine;

	[System.NonSerialized]
	public bool isDebugMode = true;

	[System.NonSerialized]
	public string audioFileName = string.Empty;
	#endregion

	#region CONSTANTS
	// Mood의 한계치
	[System.NonSerialized]
	public const float maxMoodCount = 12f;

	//private const float sensitivityConstant = 1.935f;
	private const float sensitivityConstant = 1.6f;
	private const float bassConstant = 0.236f;
	private const float kickConstant = 0.866f;
	private const float beatConstant = 1.55f;
	#endregion

	/// <summary>
	/// Manager 오브젝트가 생성될 때 실행되는 함수
	/// </summary>
	private void Start() {
		if (outputCube != null) {
			// Output용 큐브를 cubeParent 오브젝트 하위에 생성
			outputCube = Instantiate(prefabObject, new Vector3(-44f, -23f, 0f), Quaternion.identity, cubeParent);
			outputCube.GetComponent<MeshRenderer>().material.color = Color.gray;
		}
	}

	/// <summary>
	/// 매 프레임마다 작동되는 함수
	/// </summary>
	private void Update() {
		// CubeSound를 담은 배열에 들어간 값이 있다면 DetectMood 함수를 실행
		if (cubeSounds != null) {
			DetectMood();
		}

		// Output Data를 감지해서 비주얼라이저로 표시
		DetectOutputSound();

		DetectBassBeat();
	}

	//=======================================================================

	/// <summary>
	/// 로컬에서 오디오 파일을 가져옴
	/// </summary>
	/// <returns></returns>
	public IEnumerator GetAudioFileAndStartGame(InputField inputField) {
		while (true) {
			// 파일 브라우저를 통해 오디오 파일의 경로를 가져옴
			string path = FileBrowser.OpenSingleFile("Select your Music", "", new ExtensionFilter[] { new ExtensionFilter("Audio Files", "wav", "ogg", "mp3") });
			inputField.text = path;
			// 오디오 파일의 이름을 가져옴
			audioFileName = Path.GetFileNameWithoutExtension(path);
			// mp3파일인 경우에 wav로 변환한 뒤 가져옴
			if (Path.GetExtension(path).ToLower() == ".mp3") {
				// wav 파일 경로 생성
				string newFilePath = Directory.GetCurrentDirectory() + @"\" + audioFileName + ".wav";
				// mp3 -> wav 변환
				using (Mp3FileReader reader = new Mp3FileReader(path)) {
					WaveFileWriter.CreateWaveFile(newFilePath, reader);
				}
				path = newFilePath;
			}

			WWW www = new WWW("file:///" + path);

			yield return www;

			if (www.error == null) {
				audioSource.clip = www.GetAudioClip();

				//TODO: 별개의 UI 제작
				//yield return StartCoroutine(StartGame(name));
				yield break;
			}
			else {
				Debug.LogError("오디오 파일을 가져오는 중 오류가 발생했습니다...");
			}

			yield return null;
		}
	}

	/// <summary>
	/// 게임을 시작
	/// </summary>
	/// <param name="name">오디오 파일의 이름</param>
	/// <returns></returns>
	public IEnumerator StartGame(string name) {
		LevelCtrl.Instance.StartGame(name, subbandBeatDetection.userDifficulty + " Mode", 7, 7);

		yield return new WaitForSeconds(2f);

		audioSource.Play();
		Debug.Log("Audio Play");

		yield return StartCoroutine(WaitAudioFinish());
	}

	/// <summary>
	/// 오디오가 끝날 때까지 기다림
	/// </summary>
	/// <returns></returns>
	private IEnumerator WaitAudioFinish() {
		while (true) {
			if (!audioSource.isPlaying) {
				yield return StartCoroutine(WaitAllFallsDown());
				yield break;
			}
			yield return null;
		}
	}

	/// <summary>
	/// 오디오가 끝나고 모든 오브젝트들이 사라질 때까지 기다림
	/// </summary>
	/// <returns></returns>
	private IEnumerator WaitAllFallsDown() {
		// I'll be fine LOL
		while (true) {
			if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && GameObject.FindGameObjectsWithTag("Laser").Length == 0 && GameObject.FindGameObjectsWithTag("Heart").Length == 0) {
				yield return new WaitForSeconds(2f);

				LevelCtrl.Instance.Initialize();
				
				selectAudioUI.SetActive(true);

				yield break;
			}
			yield return null;
		}
	}

	//=======================================================================

	/// <summary>
	/// 모든 CubeSound의 beatedNum을 더해 배경색을 그에 따라 변경하는 함수
	/// </summary>
	public void DetectMood() {
		// 비트의 총 합을 담을 변수
		float temp = 0f;

		// 모든 CubeSound의 beatNum을 더함
		for (int i = 0; i < cubeSounds.Length; i++) {
			temp += cubeSounds[i].beatedNum;
		}

		beatAmount = temp;
		if (mainCamera != null) {
			// 배경색을 beatAmount에 따라 변경
			mainCamera.backgroundColor = new Color((beatAmount >= maxMoodCount) ? 1f : beatAmount / maxMoodCount, 0f, 0f);
			//Debug.Log("Beat : " + beatAmount);
		}
	}
	
	/// <summary>
	/// parent 오브젝트 하위에 있는 모든 CubeSound를 배열 형태로 cubeSound 배열에 담는 함수
	/// </summary>
	/// <param name="parent"></param>
	public void GetCubeSounds(Transform parent) {
		CubeSound[] cubeSounds = parent.GetComponentsInChildren<CubeSound>();
		Debug.Log("Get CubeSounds");
		this.cubeSounds = cubeSounds;
	}

	//=======================================================================

	/// <summary>
	/// 오디오의 Output 값을 감지해 비주얼라이저를 통해 표시하는 함수
	/// </summary>
	public void DetectOutputSound() {
		// 0번 채널과 1번 채널의 OutputData를 담음
		AudioListener.GetOutputData(outputData0, 0);
		AudioListener.GetOutputData(outputData1, 1);

		// 결과를 담을 float 변수
		float result = 0f;

		// 모든 OutputData를 더해 result 변수에 저장
		for (int i = 0; i < outputData0.Length; i++) {
			result += Mathf.Abs(outputData0[i]);
		}
		for (int i = 0; i < outputData1.Length; i++) {
			result += Mathf.Abs(outputData1[i]);
		}

		//uText.text = result.ToString();
		//Debug.Log(result);

		outputAmount = result;
		// result의 값을 비주얼라이저에 표시
		if (outputCube != null) {
			outputCube.transform.localScale = new Vector3(result / 100f, 1f, 1f);
			outputCube.transform.localPosition = new Vector3(-44f + (result / 200f), outputCube.transform.localPosition.y, outputCube.transform.localPosition.z);
		}
	}

	//=======================================================================

	/// <summary>
	/// 음악 구간의 변화를 기록하는 함수
	/// </summary>
	public void DetectBassBeat() {
		audioSource.GetSpectrumData(spectrumData0, 0, FFTWindow.Rectangular);
		audioSource.GetSpectrumData(spectrumData1, 1, FFTWindow.Rectangular);
		GetInstantEnergy(0, 64, spectrumData0, spectrumData1);

		if (isTimePassed) {
			if ((instantEnergy >= beatConstant || instantEnergy >= sensitivityConstant * GetAverage(historyBuffer)) && instantEnergy >= bassConstant) {
				if (instantEnergy >= kickConstant) {
					Debug.LogWarning("Bass Detected : " + instantEnergy + " > " + sensitivityConstant * GetAverage(historyBuffer));
					if (!isDebugMode)
						DoRandom(instantEnergy);
				}
				else {
					Debug.Log("Bass Detected : " + instantEnergy + " > " + sensitivityConstant * GetAverage(historyBuffer));
					if (!isDebugMode)
						DoRandom(instantEnergy);
				}
				timePassCoroutine = TimePassCoroutine(0.15f);
				StartCoroutine(timePassCoroutine);
			}
		}

		historyBuffer = ShiftArray(historyBuffer, 1);
		historyBuffer[0] = instantEnergy;
	}

	public void GetInstantEnergy(int startPoint, int endPoint, float[] sample0, float[] sample1) {
		float result = 0;

		for (int i = startPoint; i <= endPoint; i++) {
			result += Mathf.Pow(sample0[i], 2) + Mathf.Pow(sample1[i], 2);
		}

		instantEnergy = result;
	}

	public float GetAverage(float[] array) {
		float result = 0f;
		int count = 0;
		for (int i = 0; i < array.Length; i++) {
			if (array[i] != 0) {
				result += array[i];
				count++;
			}
		}
		if (count != 0)
			return result / count;
		else
			return float.MaxValue;
	}

	public T[] ShiftArray<T>(T[] _original, int amount) {
		T[] result = _original;
		for (int i = (result.Length - 1) - amount; i >= 0; i--) {
			result[i + amount] = result[i];
		}
		for (int i = 0; i < amount; i++) {
			result[i] = default(T);
		}
		return result;
	}

	public IEnumerator TimePassCoroutine(float time) {
		isTimePassed = false;
		yield return new WaitForSeconds(time);
		isTimePassed = true;
	}

	//=======================================================================

	public void DoRandom(float energy) {
		LevelCtrl.Instance.DoRandom(RoundOff(energy, bassConstant), energy, outputAmount / 1000f, beatAmount, maxMoodCount);
	}

	private int RoundOff(float value, float rate) {
		int floor = Mathf.FloorToInt(value);

		if (value - floor >= rate)
			return floor + 1;
		else
			return floor;
	}
}
