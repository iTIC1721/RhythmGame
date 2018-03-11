using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;

public class WriteLevel : MonoBehaviour {

	#region Publics
	public string levelName = "Level Name";
	public string levelDesigner = "Level Designer";
	public string composer = "Composer";
	public string musicName = "Music";
	#endregion

	public GameObject editorContent;

	XmlDocument doc;
	XmlElement root;

	#region Xml Methods
	/// <summary>
	/// Xml파일 초기화를 실행합니다
	/// </summary>
	private void InitialXml() {
		doc = new XmlDocument();
		// xml 버전, 인코딩, Standalone
		XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
		// 해당 정보를 xml에 추가
		doc.AppendChild(xmlDeclaration);
		// 루트 생성
		root = doc.CreateElement("CustomLevel");
		// 루트 추가
		doc.AppendChild(root);

		// 기본 정보 추가
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("Info"));
		Item.SetAttribute("LevelName", levelName);
		Item.SetAttribute("LevelDesigner", levelDesigner);
		Item.SetAttribute("MusicName", musicName);
		Item.SetAttribute("Composer", composer);
	}

	/// <summary>
	/// 장애물 스폰
	/// </summary>
	private void AddSpawnEnemy(float activeTime, int spawnDir, int spawnPos, float speed, float velo, bool isHeart, bool follow) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("EnemySpawn"));		
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("SpawnDir", spawnDir.ToString());
		Item.SetAttribute("SpawnPos", spawnPos.ToString());
		Item.SetAttribute("Speed", speed.ToString());
		Item.SetAttribute("Velo", velo.ToString());
		Item.SetAttribute("IsHeart", isHeart.ToString());
		Item.SetAttribute("Follow", follow.ToString());
	}

	/// <summary>
	/// 레이저 스폰
	/// </summary>
	private void AddSpawnLaser(float activeTime, int spawnDir, int spawnPos, float time, bool follow) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("LaserSpawn"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("SpawnDir", spawnDir.ToString());
		Item.SetAttribute("SpawnPos", spawnPos.ToString());
		Item.SetAttribute("Time", time.ToString());
		Item.SetAttribute("Follow", follow.ToString());
	}

	/// <summary>
	/// 사이즈 조절
	/// </summary>
	private void AddResizeLevel(float activeTime, int width, int height) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("ResizeLevel"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("Width", width.ToString());
		Item.SetAttribute("Height", height.ToString());
	}

	/// <summary>
	/// 색 변경
	/// </summary>
	private void AddColorChange(ColorDataList colorData, float activeTime, float r, float g, float b, float time, LerpType lerpType, int level) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("ColorChange"));
		Item.SetAttribute("ColorData", colorData.ToString());
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("R", r.ToString());
		Item.SetAttribute("G", g.ToString());
		Item.SetAttribute("B", b.ToString());
		Item.SetAttribute("Time", time.ToString());
		Item.SetAttribute("LerpType", lerpType.ToString());
		Item.SetAttribute("Level", level.ToString());
	}

	/// <summary>
	/// 카메라 회전
	/// </summary>
	private void AddRotateLevel(float activeTime, float angle, float time, LerpType lerpType, int level) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("RotateLevel"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("Angle", angle.ToString());
		Item.SetAttribute("Time", time.ToString());
		Item.SetAttribute("LerpType", lerpType.ToString());
		Item.SetAttribute("Level", level.ToString());
	}

	/// <summary>
	/// 카메라 확대
	/// </summary>
	private void AddEnlargeLevel(float activeTime, float rate, float time, LerpType lerpType, int level) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("EnlargeLevel"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("Rate", rate.ToString());
		Item.SetAttribute("Time", time.ToString());
		Item.SetAttribute("LerpType", lerpType.ToString());
		Item.SetAttribute("Level", level.ToString());
	}

	/// <summary>
	/// 카메라 이동
	/// </summary>
	private void AddMoveLevel(float activeTime, float x, float y, float time, LerpType lerpType, int level) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("MoveLevel"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("X", x.ToString());
		Item.SetAttribute("Y", y.ToString());
		Item.SetAttribute("Time", time.ToString());
		Item.SetAttribute("LerpType", lerpType.ToString());
		Item.SetAttribute("Level", level.ToString());
	}

	/// <summary>
	/// 플레이어 투명
	/// </summary>
	private void AddPlayerVisible(float activeTime, bool visible) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("PlayerVisible"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("Visible", visible.ToString());
	}

	/// <summary>
	/// 플레이어 이동
	/// </summary>
	private void AddReplacePlayer(float activeTime, int x, int y) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("ReplacePlayer"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("X", x.ToString());
		Item.SetAttribute("Y", y.ToString());
	}

	/// <summary>
	/// 엔티티 제거
	/// </summary>
	private void AddKillEntity(float activeTime, string tag) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("KillEntity"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("Tag", tag);
	}

	/// <summary>
	/// Xml 파일 저장
	/// </summary>
	private void SaveXml() {
		//폴더 유무 확인 후 생성
		DirectoryInfo diInfo = new DirectoryInfo(Model.folderPath);
		if (!diInfo.Exists)
			diInfo.Create();

		//파일 생성
		string filePath = Model.folderPath + levelName + ".xml";
		doc.Save(filePath);
	}
	#endregion

	#region SaveMethods
	public void Save() {
		InitialXml();
		GetContents();
		SaveXml();
	}

	private void GetContents() {
		CommandData[] commandDatas = editorContent.GetComponentsInChildren<CommandData>();
		List<CommandData>[] dataLists = new List<CommandData>[10];

		// 리스트 배열 초기화
		for (int i = 0; i < 10; i++) {
			dataLists[i] = new List<CommandData>();
		}

		// 모든 command들을 종류별로 리스트에 담음
		foreach (CommandData commandData in commandDatas) {
			dataLists[(int)commandData.type].Add(commandData);
		}

		// activeTime 순서대로 정렬
		foreach (var list in dataLists) {
			list.Sort(delegate (CommandData A, CommandData B) {
				if (A.activeTime > B.activeTime) return 1;
				else if (A.activeTime < B.activeTime) return -1;
				return 0;
			});
		}

		for (int i = 0; i < 10; i++) {
			foreach (var item in dataLists[i]) {
				switch (i) {
					case 0:
						AddSpawnEnemy(item.activeTime, (int)item.spawnDir, item.spawnPos, item.speed, item.velo, item.isHeart, item.follow);
						break;
					case 1:
						AddSpawnLaser(item.activeTime, (int)item.spawnDir, item.spawnPos, item.time, item.follow);
						break;
					case 2:
						AddColorChange(item.colorDataList, item.activeTime, item.r, item.g, item.b, item.time, item.lerpType, item.level);
						break;
					case 3:
						AddResizeLevel(item.activeTime, item.width, item.height);
						break;
					case 4:
						AddRotateLevel(item.activeTime, item.angle, item.time, item.lerpType, item.level);
						break;
					case 5:
						AddEnlargeLevel(item.activeTime, item.rate, item.time, item.lerpType, item.level);
						break;
					case 6:
						AddMoveLevel(item.activeTime, item.x, item.y, item.time, item.lerpType, item.level);
						break;
					case 7:
						AddReplacePlayer(item.activeTime, item.playerX, item.playerY);
						break;
					case 8:
						AddPlayerVisible(item.activeTime, item.visible);
						break;
					case 9:
						AddKillEntity(item.activeTime, item.tag);
						break;
				}
			}
		}
	}
	#endregion
}
