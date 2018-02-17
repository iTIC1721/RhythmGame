using UnityEngine;
using UnityEngine.UI;

public class GameOverCtrl : MonoBehaviour {

	private Text textComp;

	private void Awake() {
		textComp = gameObject.GetComponent<Text>();
	}

	private void Update() {
		if (!LevelData.Instance.gameOver) {
			textComp.enabled = false;
		}
		else {
			textComp.enabled = true;
		}
	}
}
