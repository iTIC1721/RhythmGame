using UnityEngine;

public class LevelData : Singleton<LevelData> {

	public string levelName = "Level Name";
	public string levelDesigner = "Level Designer";

	// 가운데를 중심으로 양쪽에 너비와 높이 만큼의 칸이 있음
	public int levelWidth = 2;
	public int levelHeight = 2;

	public int playerHeartMax = 10;
	public int playerHeart = 10;
	public bool isInvincible = false;

	public bool invincibleMode = false;

	public Color enemyColor = Color.white;
	public Color levelColor = Color.white;
	public Color backColor = Color.black;
	public Color heartColor = Color.red;

	public bool gameOver = false;
}
