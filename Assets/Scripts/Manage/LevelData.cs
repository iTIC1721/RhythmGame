using UnityEngine;

public class LevelData : Singleton<LevelData> {

	// 레벨 이름
	public string levelName = "Level Name";
	// 레벨 디자이너
	public string levelDesigner = "Level Designer";

	// 가운데를 중심으로 양쪽에 너비와 높이 만큼의 칸이 있음
	public int levelWidth = 7;
	public int levelHeight = 7;

	// 플레이어의 최대 생명 수
	public int playerHeartMax = 10;
	// 플레이어의 현재 생명
	public int playerHeart = 10;
	// 플레이어의 무적 상태 여부
	public bool isInvincible = false;

	// 플레이어의 무적 모드 여부
	public bool invincibleMode = false;

	// 장애물 색
	public Color enemyColor = Color.white;
	// 게임판 색
	public Color levelColor = Color.white;
	// 배경색
	public Color backColor = Color.black;
	// 하트 색
	public Color heartColor = Color.red;

	// 게임 오버 여부
	public bool gameOver = false;
}
