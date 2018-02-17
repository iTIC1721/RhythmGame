using UnityEngine;

public class ManageScript : Singleton<ManageScript> {

	private static ManageScript instance = null;

	// 모든 씬에 존재하는 유일한 오브젝트로 설정
	private void Awake() {
		if (instance) {
			DestroyImmediate(gameObject);
			return;
		}
		instance = this;
		DontDestroyOnLoad(gameObject);
	}

	// 레벨 초기화
	public void LevelInitialize(bool invinciblemode, int heartMax) {
		LevelData.Instance.invincibleMode = invinciblemode;
		LevelData.Instance.playerHeartMax = heartMax;
		LevelData.Instance.playerHeart = heartMax;
	}
}
