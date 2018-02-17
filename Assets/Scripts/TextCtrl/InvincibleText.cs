using UnityEngine;
using UnityEngine.UI;

public class InvincibleText : MonoBehaviour {

	Text textComp;

	private void Awake() {
		textComp = gameObject.GetComponent<Text>();
	}

	private void Update() {
		if (!LevelData.Instance.invincibleMode) {
			textComp.enabled = false;
		}
		else {
			textComp.enabled = true;
		}
	}
}
