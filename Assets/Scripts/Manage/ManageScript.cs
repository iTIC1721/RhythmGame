using UnityEngine;

public class ManageScript : Singleton<ManageScript> {

	private static ManageScript instance = null;

	private void Awake() {
		if (instance) {
			DestroyImmediate(gameObject);
			return;
		}
		instance = this;
		DontDestroyOnLoad(gameObject);
	}

	public void LevelInitialize(bool invinciblemode, int heartMax) {
		LevelData.Instance.invincibleMode = invinciblemode;
		LevelData.Instance.playerHeartMax = heartMax;
		LevelData.Instance.playerHeart = heartMax;
	}
}
