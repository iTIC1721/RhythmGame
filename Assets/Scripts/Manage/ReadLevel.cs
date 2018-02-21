using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

// UNDONE: 테스트 필요
public class ReadLevel : MonoBehaviour {

	#region Structs
	/// <summary>
	/// 일반적인 블럭 장애물의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct EnemyData {
		public float activeTime;

		public int spawnDir;
		public int spawnPos;
		public float speed;
		public float velo;
		public bool isHeart;

		public void Active() {
			LevelCtrl.Instance.SpawnEnemy(spawnDir, spawnPos, speed, velo, isHeart);
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
	/// 레이저 장애물의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct LaserData {
		public float activeTime;

		public int spawnDir;
		public int spawnPos;
		public float time;

		public void Active() {
			LevelCtrl.Instance.SpawnLaser(spawnDir, spawnPos, time);
		}

		public LaserData(float activeTime, int spawnDir, int spawnPos, float time) {
			this.activeTime = activeTime;
			this.spawnDir = spawnDir;
			this.spawnPos = spawnPos;
			this.time = time;
		}
	}

	/// <summary>
	/// 레벨 크기를 조정하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct ResizeLevelData {
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
	/// 배경색을 변경하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct BackColorData {
		public float activeTime;

		public float r;
		public float g;
		public float b;
		public float a;
		public float time;

		public void Active() {
			LevelCtrl.Instance.ChangeBackColor(new Color(r, g, b, a), time);
		}

		public BackColorData(float activetime, float r, float g, float b, float a, float time) {
			this.activeTime = activetime;
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
			this.time = time;
		}
	}

	/// <summary>
	/// 외벽 색을 변경하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct LevelColorData {
		public float activeTime;

		public float r;
		public float g;
		public float b;
		public float a;
		public float time;

		public void Active() {
			LevelCtrl.Instance.ChangeLevelColor(new Color(r, g, b, a), time);
		}

		public LevelColorData(float activetime, float r, float g, float b, float a, float time) {
			this.activeTime = activetime;
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
			this.time = time;
		}
	}

	/// <summary>
	/// 장애물의 색을 변경하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct EnemyColorData {
		public float activeTime;

		public float r;
		public float g;
		public float b;
		public float a;
		public float time;

		public void Active() {
			LevelCtrl.Instance.ChangeEnemyColor(new Color(r, g, b, a), time);
		}

		public EnemyColorData(float activetime, float r, float g, float b, float a, float time) {
			this.activeTime = activetime;
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
			this.time = time;
		}
	}

	/// <summary>
	/// 카메라를 회전하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct RotateLevelData {
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
	/// 레벨을 확대하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct EnlargeLevelData {
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
	/// 카메라를 이동하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct MoveLevelData {
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
	/// 플레이어의 투명 여부를 변경하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct PlayerVisibleData {
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
	/// 플레이어 위치를 변경하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct ReplacePlayerData {
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
	/// 특정 태그를 가진 엔티티를 제거하는 명령어의 생성 정보를 나타내는 구조체입니다.
	/// </summary>
	public struct KillEntityData {
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

	#region Lists
	List<EnemyData> enemyDataList = new List<EnemyData>();
	List<LaserData> laserDataList = new List<LaserData>();
	List<ResizeLevelData> resizeDataList = new List<ResizeLevelData>();
	List<BackColorData> backColDataList = new List<BackColorData>();
	List<LevelColorData> levelColDataList = new List<LevelColorData>();
	List<EnemyColorData> enemyColDataList = new List<EnemyColorData>();
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
	IEnumerator backColorCor;
	IEnumerator levelColorCor;
	IEnumerator enemyColorCor;
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
	IEnumerator BackColorCor() {
		for (int i = 0; i < backColDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(backColDataList[i].activeTime - (i > 0 ? backColDataList[i - 1].activeTime : 0));
			// 실행
			backColDataList[i].Active();
		}
	}

	/// <summary>
	/// 외벽 색 변경 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator LevelColorCor() {
		for (int i = 0; i < levelColDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(levelColDataList[i].activeTime - (i > 0 ? levelColDataList[i - 1].activeTime : 0));
			// 실행
			levelColDataList[i].Active();
		}
	}

	/// <summary>
	/// 장애물 색 변경 코루틴
	/// </summary>
	/// <returns></returns>
	IEnumerator EnemyColorCor() {
		for (int i = 0; i < enemyColDataList.Count; i++) {
			// 다음 실행까지 대기
			// 이전 실행이 있었을 경우 실행할 내용의 activeTime에서 이전 실행의 activeTime을 감한 만큼 대기
			// 이전 실행이 없었을 경우(첫 실행일 경우) 실행할 내용의 activeTime만큼 대기
			yield return new WaitForSeconds(enemyColDataList[i].activeTime - (i > 0 ? enemyColDataList[i - 1].activeTime : 0));
			// 실행
			enemyColDataList[i].Active();
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
	#endregion

	public void LoadXml() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(levelDataFile.text);

		XmlNodeList nodes = xmlDoc.SelectNodes("CharacterInfo/Character");

		foreach (XmlNode node in nodes) {
			Debug.Log("Name :: " + node.SelectSingleNode("Name").InnerText);
			Debug.Log("Level :: " + node.SelectSingleNode("Level").InnerText);
			Debug.Log("Exp :: " + node.SelectSingleNode("Experience").InnerText);
		}

		// http://wergia.tistory.com/53
		// http://phiru.tistory.com/337
		// http://phiru.tistory.com/327
	}

}

