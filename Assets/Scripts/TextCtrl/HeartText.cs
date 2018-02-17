using UnityEngine;
using UnityEngine.UI;

public class HeartText : MonoBehaviour {

	Text textComp;

	private void Awake() {
		textComp = gameObject.GetComponent<Text>();
	}
	
	private void Update () {
		textComp.text = "Heart Left : " + LevelData.Instance.playerHeart;
	}
}
