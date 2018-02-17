using UnityEngine;
using UnityEngine.UI;

public class UITextCtrl : MonoBehaviour {

	private Text textComp;

	private void Awake() {
		textComp = gameObject.GetComponent<Text>();
	}

	private void Update() {
		if (gameObject.name == "LevelName") {
			gameObject.transform.position += new Vector3(0.2f, 0, 0);
			textComp.text = LevelData.Instance.levelName;

			if (textComp.color.a > 0f) {
				textComp.color += new Color(0, 0, 0, -0.003f);
			}
			else {
				Destroy(gameObject);
			}
		}
		else if (gameObject.name == "LevelDesigner") {
			gameObject.transform.position += new Vector3(0.3f, 0, 0);
			textComp.text = LevelData.Instance.levelDesigner;

			if (textComp.color.a > 0f) {
				textComp.color += new Color(0, 0, 0, -0.003f);
			}
			else {
				Destroy(gameObject);
			}
		}
	}
}
