using System.Collections;
using UnityEngine;

public class CubeSound : MonoBehaviour {

	public SubbandBeatDetection selectedBeatDetection;
	public CubesManager cubesManager;
	public MoodManager moodManager;
	public int[] subbandsToEar;

	public float smoothnessChange;

	private MeshRenderer myMeshRenderer;
	private MeshRenderer spectrumMeshRenderer;
	private Color beatedColor;

	private Transform spectrumCube;

	[System.NonSerialized]
	public float beatedNum;

	[System.NonSerialized]
	public bool isDebugMode = true;

	void Start() {
		for (int i = 0; i < subbandsToEar.Length; i++) {
			selectedBeatDetection.subBands[subbandsToEar[i]].OnBeat += OnBeat;
		}

		myMeshRenderer = GetComponent<MeshRenderer>();
		beatedColor = Color.black;
		beatedNum = 0f;

		spectrumCube = Instantiate(cubesManager.spectrumPrefabObject, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity, transform.parent).transform;
		spectrumMeshRenderer = spectrumCube.GetComponent<MeshRenderer>();
	}

	void Update() {
		EnergyToSpectrum();

		beatedColor = Color.Lerp(beatedColor, Color.black, smoothnessChange * Time.deltaTime);
		beatedNum = Mathf.Lerp(beatedNum, 0, smoothnessChange * Time.deltaTime);

		if (isDebugMode) {
			myMeshRenderer.material.color = beatedColor;
			spectrumMeshRenderer.material.color = beatedColor;
		}
	}

	void OnBeat() {
		beatedColor = Color.yellow;
		beatedNum = 1f;
		if (!isDebugMode && cubesManager.isTimePassed) {
			moodManager.DoRandom((((moodManager.beatAmount - (MoodManager.maxMoodCount / 2)) / (MoodManager.maxMoodCount / 2)) + 1f) * 0.7f, true, Color.gray);
			cubesManager.timePassCoroutine = cubesManager.TimePassCoroutine(0.2f);
			StartCoroutine(cubesManager.timePassCoroutine);
		}
	}


	private void EnergyToSpectrum() {
		float sumEnergy = 0;
		for (int i = 0; i < subbandsToEar.Length; i++) {
			sumEnergy += selectedBeatDetection.subBands[subbandsToEar[i]].instantEnergy;
		}

		float instantEnergy = sumEnergy / 2;

		float yScale = (instantEnergy >= 0.5f / 30.0f) ? instantEnergy * 30 : 0.5f;
		spectrumCube.localScale = new Vector3(spectrumCube.localScale.x, yScale, spectrumCube.localScale.z);
		spectrumCube.localPosition = new Vector3(spectrumCube.localPosition.x, (cubesManager.yPositionOfCubes + 2) + yScale / 2, spectrumCube.localPosition.z);
	}
}