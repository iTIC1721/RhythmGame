using System.Xml;
using UnityEngine;

public class WriteLevel : MonoBehaviour {

	XmlDocument doc;
	XmlElement root;

	#region Xml Methods
	/// <summary>
	/// Xml파일 초기화를 실행합니다
	/// </summary>
	private void InitialXml() {
		doc = new XmlDocument();
		// xml 버전, 인코틔딩, Standalone
		XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "true");
		// 해당 정보를 xml에 추가.
		doc.AppendChild(xmlDeclaration);
		// 루트를 만듭니다.
		root = doc.CreateElement("CustomLevel");
		// 루트도 추가.
		doc.AppendChild(root);
	}

	/// <summary>
	/// 장애물 스폰
	/// </summary>
	private void AddSpawnEnemy(float activeTime, int spawnDir, int spawnPos, float speed, float velo, bool isHeart) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("EnemySpawn"));		
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("SpawnDir", spawnDir.ToString());
		Item.SetAttribute("SpawnPos", spawnPos.ToString());
		Item.SetAttribute("Speed", speed.ToString());
		Item.SetAttribute("Velo", velo.ToString());
		Item.SetAttribute("IsHeart", isHeart.ToString());
	}

	/// <summary>
	/// 레이저 스폰
	/// </summary>
	private void AddSpawnLaser(float activeTime, int spawnDir, int spawnPos, float time) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("LaserSpawn"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("SpawnDir", spawnDir.ToString());
		Item.SetAttribute("SpawnPos", spawnPos.ToString());
		Item.SetAttribute("Time", time.ToString());
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
	private void AddColorChange(ColorDataList colorData, float activeTime, float r, float g, float b, float time) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("ColorChange"));
		Item.SetAttribute("ColorData", colorData.ToString());
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("R", r.ToString());
		Item.SetAttribute("G", g.ToString());
		Item.SetAttribute("B", b.ToString());
		Item.SetAttribute("Time", time.ToString());
	}

	/// <summary>
	/// 카메라 회전
	/// </summary>
	private void AddRotateLevel(float activeTime, float angle, float time) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("RotateLevel"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("Angle", angle.ToString());
		Item.SetAttribute("Time", time.ToString());
	}

	/// <summary>
	/// 카메라 확대
	/// </summary>
	private void AddEnlargeLevel(float activeTime, float rate, float time) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("EnlargeLevel"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("Rate", rate.ToString());
		Item.SetAttribute("Time", time.ToString());
	}

	/// <summary>
	/// 카메라 이동
	/// </summary>
	private void AddMoveLevel(float activeTime, float x, float y, float time) {
		XmlElement Item = (XmlElement)root.AppendChild(doc.CreateElement("MoveLevel"));
		Item.SetAttribute("ActiveTime", activeTime.ToString());
		Item.SetAttribute("X", x.ToString());
		Item.SetAttribute("Y", y.ToString());
		Item.SetAttribute("Time", time.ToString());
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
	#endregion
}
