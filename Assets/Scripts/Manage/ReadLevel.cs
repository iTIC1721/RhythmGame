using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

#region Reference URLs
// http://wergia.tistory.com/53
// http://phiru.tistory.com/337
// http://phiru.tistory.com/327
// https://forum.unity.com/threads/importing-audio-files-at-runtime.140088/
#endregion

#region Data Classes
/// <summary>
/// 일반적인 블럭 장애물의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class EnemyData {
	public float activeTime;

	public int spawnDir;
	public int spawnPos;
	public float speed;
	public float velo;
	public bool isHeart;

	public void Active() {
		LevelCtrl.Instance.SpawnEnemy((Direction)spawnDir, spawnPos, speed, velo, isHeart);
	}

	public EnemyData(float activeTime, int spawnDir, int spawnPos, float speed, float velo, bool isHeart) {
		this.activeTime = activeTime;
		this.spawnDir = spawnDir;
		this.spawnPos = spawnPos;
		this.speed = speed;
		this.velo = velo;
		this.isHeart = isHeart;
	}
}

/// <summary>
/// 레이저 장애물의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class LaserData {
	public float activeTime;

	public int spawnDir;
	public int spawnPos;
	public float time;

	public void Active() {
		LevelCtrl.Instance.SpawnLaser((Direction)spawnDir, spawnPos, time);
	}

	public LaserData(float activeTime, int spawnDir, int spawnPos, float time) {
		this.activeTime = activeTime;
		this.spawnDir = spawnDir;
		this.spawnPos = spawnPos;
		this.time = time;
	}
}

/// <summary>
/// 레벨 크기를 조정하는 명령어의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class ResizeLevelData {
	public float activeTime;

	public int width;
	public int height;

	public void Active() {
		LevelCtrl.Instance.ResizeLevel(width, height);
	}

	public ResizeLevelData(float activeTime, int width, int height) {
		this.activeTime = activeTime;
		this.width = width;
		this.height = height;
	}
}

/// <summary>
/// 색을 변경하는 명령어의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class ColorData {
	public ColorDataList colorData;
	public float activeTime;

	public float r;
	public float g;
	public float b;
	public float time;

	public void Active() {
		switch (colorData) {
			case ColorDataList.Back:
				LevelCtrl.Instance.ChangeBackColor(new Color(r, g, b), time);
				break;

			case ColorDataList.Level:
				LevelCtrl.Instance.ChangeLevelColor(new Color(r, g, b), time);
				break;

			case ColorDataList.Enemy:
				LevelCtrl.Instance.ChangeEnemyColor(new Color(r, g, b), time);
				break;
		}		
	}

	public ColorData(ColorDataList colorData, float activetime, float r, float g, float b, float time) {
		this.colorData = colorData;
		this.activeTime = activetime;
		this.r = r;
		this.g = g;
		this.b = b;
		this.time = time;
	}
}

/// <summary>
/// 카메라를 회전하는 명령어의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class RotateLevelData {
	public float activeTime;

	public float angle;
	public float time;

	public void Active() {
		LevelCtrl.Instance.RotateLevel(angle, time);
	}

	public RotateLevelData(float activeTime, float angle, float time) {
		this.activeTime = activeTime;
		this.angle = angle;
		this.time = time;
	}
}

/// <summary>
/// 레벨을 확대하는 명령어의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class EnlargeLevelData {
	public float activeTime;

	public float rate;
	public float time;

	public void Active() {
		LevelCtrl.Instance.EnlargeLevel(rate, time);
	}

	public EnlargeLevelData(float activeTime, float rate, float time) {
		this.activeTime = activeTime;
		this.rate = rate;
		this.time = time;
	}
}

/// <summary>
/// 카메라를 이동하는 명령어의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class MoveLevelData {
	public float activeTime;

	public float x;
	public float y;
	public float time;

	public void Active() {
		LevelCtrl.Instance.MoveLevel(x, y, time);
	}

	public MoveLevelData(float activeTime, float x, float y, float time) {
		this.activeTime = activeTime;
		this.x = x;
		this.y = y;
		this.time = time;
	}
}

/// <summary>
/// 플레이어의 투명 여부를 변경하는 명령어의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class PlayerVisibleData {
	public float activeTime;

	public bool visible;

	public void Active() {
		LevelCtrl.Instance.PlayerVisible(visible);
	}

	public PlayerVisibleData(float activeTime, bool visible) {
		this.activeTime = activeTime;
		this.visible = visible;
	}
}

/// <summary>
/// 플레이어 위치를 변경하는 명령어의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class ReplacePlayerData {
	public float activeTime;

	public int x;
	public int y;

	public void Active() {
		LevelCtrl.Instance.ReplacePlayer(x, y);
	}

	public ReplacePlayerData(float activeTime, int x, int y) {
		this.activeTime = activeTime;
		this.x = x;
		this.y = y;
	}
}

/// <summary>
/// 특정 태그를 가진 엔티티를 제거하는 명령어의 생성 정보를 나타내는 클래스입니다.
/// </summary>
public class KillEntityData {
	public float activeTime;

	public string tag;

	public void Active() {
		LevelCtrl.Instance.KillEntity(tag);
	}

	public KillEntityData(float activeTime, string tag) {
		this.activeTime = activeTime;
		this.tag = tag;
	}
}
#endregion

// UNDONE: 테스트 필요
public class ReadLevel : MonoBehaviour {

	#region Lists
	List<string> infoList = new List<string>();
	List<EnemyData> enemyDataList = new List<EnemyData>();
	List<LaserData> laserDataList = new List<LaserData>();
	List<ResizeLevelData> resizeDataList = new List<ResizeLevelData>();
	List<ColorData> colDataList = new List<ColorData>();
	List<RotateLevelData> rotateDataList = new List<RotateLevelData>();
	List<EnlargeLevelData> enlargeDataList = new List<EnlargeLevelData>();
	List<MoveLevelData> moveDataList = new List<MoveLevelData>();
	List<PlayerVisibleData> visibleDataList = new List<PlayerVisibleData>();
	List<ReplacePlayerData> replacePlayerDataList = new List<ReplacePlayerData>();
	List<KillEntityData> killDataList = new List<KillEntityData>();
	#endregion

	#region Coroutine Vars
	IEnumerator spawnEnemyCor;
	IEnumerator spawnLaserCor;
	IEnumerator resizeLevelCor;
	IEnumerator colorCor;
	IEnumerator rotateCor;
	IEnumerator enlargeCor;
	IEnumerator moveCor;
	IEnumerator visibleCor;
	IEnumerator replacePlayerCor;
	IEnumerator killCor;
	#endregion

	#region Coroutines
	/// <summary>
	/// 장애물 생성 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator SpawnEnemyCor() {
		for (int i = 0; i < enemyDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(enemyDataList[i].activeTime - (i > 0 ? enemyDataList[i - 1].activeTime : 0));
			// 실행
			enemyDataList[i].Active();
		}
	}
	
	/// <summary>
	/// 레이저 생성 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator LaserEnemyCor() {
		for (int i = 0; i < laserDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(laserDataList[i].activeTime - (i > 0 ? laserDataList[i - 1].activeTime : 0));
			// 실행
			laserDataList[i].Active();
		}
	}

	/// <summary>
	/// 레벨 크기 조정 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator ResizeLevelCor() {
		for (int i = 0; i < resizeDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(resizeDataList[i].activeTime - (i > 0 ? resizeDataList[i - 1].activeTime : 0));
			// 실행
			resizeDataList[i].Active();
		}
	}

	/// <summary>
	/// 배경색 변경 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator ColorCor() {
		for (int i = 0; i < colDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(colDataList[i].activeTime - (i > 0 ? colDataList[i - 1].activeTime : 0));
			// 실행
			colDataList[i].Active();
		}
	}

	/// <summary>
	/// 회전 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator RotateCor() {
		for (int i = 0; i < rotateDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(rotateDataList[i].activeTime - (i > 0 ? rotateDataList[i - 1].activeTime : 0));
			// 실행
			rotateDataList[i].Active();
		}
	}

	/// <summary>
	/// 확대 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator EnlargeCor() {
		for (int i = 0; i < enlargeDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(enlargeDataList[i].activeTime - (i > 0 ? enlargeDataList[i - 1].activeTime : 0));
			// 실행
			enlargeDataList[i].Active();
		}
	}

	/// <summary>
	/// 이동 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator MoveCor() {
		for (int i = 0; i < moveDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(moveDataList[i].activeTime - (i > 0 ? moveDataList[i - 1].activeTime : 0));
			// 실행
			moveDataList[i].Active();
		}
	}

	/// <summary>
	/// 투명 여부 변경 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator VisibleCor() {
		for (int i = 0; i < visibleDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(visibleDataList[i].activeTime - (i > 0 ? visibleDataList[i - 1].activeTime : 0));
			// 실행
			visibleDataList[i].Active();
		}
	}

	/// <summary>
	/// 플레이어 위치 변경 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator ReplacePlayerCor() {
		for (int i = 0; i < replacePlayerDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(replacePlayerDataList[i].activeTime - (i > 0 ? replacePlayerDataList[i - 1].activeTime : 0));
			// 실행
			replacePlayerDataList[i].Active();
		}
	}

	/// <summary>
	/// 엔티티 제거 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator KillCor() {
		for (int i = 0; i < killDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(killDataList[i].activeTime - (i > 0 ? killDataList[i - 1].activeTime : 0));
			// 실행
			killDataList[i].Active();
		}
	}
	#endregion

	#region Publics
	public TextAsset levelDataFile;
	public AudioClip audioClip;

	public AudioSource audioSource;
	#endregion

	#region Privates
	private string audioPath = string.Empty;
	bool isReady = false;
	#endregion

	#region Methods
	/// <summary>
	/// levelDataFile로 지정된 Xml 파일을 읽어와 리스트에 저장합니다.
	/// </summary>
	public void LoadXml() {
		// 리스트 초기화
		#region Initialize Lists

		enemyDataList.Clear();
		laserDataList.Clear();
		resizeDataList.Clear();
		colDataList.Clear();
		rotateDataList.Clear();
		enlargeDataList.Clear();
		moveDataList.Clear();
		visibleDataList.Clear();
		replacePlayerDataList.Clear();
		killDataList.Clear();

		#endregion

		// Xml 불러오기
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(levelDataFile.text);
		XmlNodeList nodes;

		#region Add Info
		nodes = xmlDoc.SelectNodes("CustomLevel/Info");
		foreach (XmlNode node in nodes) {
			infoList.Add(node.SelectSingleNode("LevelName").InnerText);
			infoList.Add(node.SelectSingleNode("LevelDesigner").InnerText);
			infoList.Add(node.SelectSingleNode("MusicName").InnerText);
			infoList.Add(node.SelectSingleNode("Composer").InnerText);
		}
		#endregion

		#region Add EnemySpawn
		nodes = xmlDoc.SelectNodes("CustomLevel/EnemySpawn");
		foreach (XmlNode node in nodes) {
			try {
				EnemyData data = new EnemyData(
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					int.Parse(node.SelectSingleNode("SpawnDir").InnerText),
					int.Parse(node.SelectSingleNode("SpawnPos").InnerText),
					float.Parse(node.SelectSingleNode("Speed").InnerText),
					float.Parse(node.SelectSingleNode("Velo").InnerText),
					bool.Parse(node.SelectSingleNode("IsHeart").InnerText)
					);
				enemyDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion

		#region Add LaserSpawn
		nodes = xmlDoc.SelectNodes("CustomLevel/LaserSpawn");
		foreach (XmlNode node in nodes) {
			try {
				LaserData data = new LaserData(
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					int.Parse(node.SelectSingleNode("SpawnDir").InnerText),
					int.Parse(node.SelectSingleNode("SpawnPos").InnerText),
					float.Parse(node.SelectSingleNode("Time").InnerText)
					);
				laserDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion

		#region Add ResizeLevel
		nodes = xmlDoc.SelectNodes("CustomLevel/ResizeLevel");
		foreach (XmlNode node in nodes) {
			try {
				ResizeLevelData data = new ResizeLevelData(
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					int.Parse(node.SelectSingleNode("Width").InnerText),
					int.Parse(node.SelectSingleNode("Height").InnerText)
					);
				resizeDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion

		#region Add ColorChange
		nodes = xmlDoc.SelectNodes("CustomLevel/ColorChange");
		foreach (XmlNode node in nodes) {
			try {
				ColorData data = new ColorData(
					(ColorDataList)Enum.Parse(typeof(ColorDataList), node.SelectSingleNode("ColorData").InnerText),
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					float.Parse(node.SelectSingleNode("R").InnerText),
					float.Parse(node.SelectSingleNode("G").InnerText),
					float.Parse(node.SelectSingleNode("B").InnerText),
					float.Parse(node.SelectSingleNode("Time").InnerText)
					);
				colDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion

		#region Add RotateLevel
		nodes = xmlDoc.SelectNodes("CustomLevel/RotateLevel");
		foreach (XmlNode node in nodes) {
			try {
				RotateLevelData data = new RotateLevelData(
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					float.Parse(node.SelectSingleNode("Angle").InnerText),
					float.Parse(node.SelectSingleNode("Time").InnerText)
					);
				rotateDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion

		#region Add EnlargeLevel
		nodes = xmlDoc.SelectNodes("CustomLevel/EnlargeLevel");
		foreach (XmlNode node in nodes) {
			try {
				EnlargeLevelData data = new EnlargeLevelData(
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					float.Parse(node.SelectSingleNode("Rate").InnerText),
					float.Parse(node.SelectSingleNode("Time").InnerText)
					);
				enlargeDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion

		#region Add MoveLevel
		nodes = xmlDoc.SelectNodes("CustomLevel/MoveLevel");
		foreach (XmlNode node in nodes) {
			try {
				MoveLevelData data = new MoveLevelData(
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					float.Parse(node.SelectSingleNode("X").InnerText),
					float.Parse(node.SelectSingleNode("Y").InnerText),
					float.Parse(node.SelectSingleNode("Time").InnerText)
					);
				moveDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion

		#region Add PlayerVisible
		nodes = xmlDoc.SelectNodes("CustomLevel/PlayerVisible");
		foreach (XmlNode node in nodes) {
			try {
				PlayerVisibleData data = new PlayerVisibleData(
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					bool.Parse(node.SelectSingleNode("Visible").InnerText)
					);
				visibleDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion

		#region Add ReplacePlayer
		nodes = xmlDoc.SelectNodes("CustomLevel/ReplacePlayer");
		foreach (XmlNode node in nodes) {
			try {
				ReplacePlayerData data = new ReplacePlayerData(
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					int.Parse(node.SelectSingleNode("X").InnerText),
					int.Parse(node.SelectSingleNode("Y").InnerText)
					);
				replacePlayerDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion

		#region Add KillEntity
		nodes = xmlDoc.SelectNodes("CustomLevel/KillEntity");
		foreach (XmlNode node in nodes) {
			try {
				KillEntityData data = new KillEntityData(
					float.Parse(node.SelectSingleNode("ActiveTime").InnerText),
					node.SelectSingleNode("Tag").InnerText
					);
				killDataList.Add(data);
			}
			catch (FormatException ex) {
				Debug.LogError(ex);
			}
		}
		#endregion
	}

	/// <summary>
	/// 폴더 경로에서 musicName와 동일한 이름을 가진 .mp3 파일을 불러옵니다.
	/// </summary>
	/// <returns></returns>
	IEnumerator GetAudio() {
		WWW www = null;
		try {
			www = new WWW("file://" + Model.folderPath + infoList[2] + ".mp3");
			audioClip = www.GetAudioClip();
		}
		catch (Exception) {
			yield break;
		}

		while (audioClip.loadState == AudioDataLoadState.Loading || audioClip.loadState == AudioDataLoadState.Unloaded) {
			yield return www;
		}

		audioSource.clip = audioClip;
		isReady = true;
	}
	#endregion
}

