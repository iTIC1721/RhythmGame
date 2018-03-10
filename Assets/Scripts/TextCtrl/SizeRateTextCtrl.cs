using UnityEngine;
using UnityEngine.UI;

public class SizeRateTextCtrl : MonoBehaviour {

	private Text textComp;
	private Color textColor;

	private float alphaInterval = 0.02f;

	private void Awake() {
		textComp = gameObject.GetComponent<Text>();
	}

	private void Update() {
		textColor = textComp.color;
		if (textColor.a > 0) {
			textComp.color = new Color(textColor.r, textColor.g, textColor.b, textColor.a - alphaInterval);
		}
		else {
			textComp.color = new Color(textColor.r, textColor.g, textColor.b, 0);
		}
	}
}
