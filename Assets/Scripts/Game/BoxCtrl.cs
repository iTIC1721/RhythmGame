using UnityEngine;

public class BoxCtrl : MonoBehaviour {

	private SpriteRenderer[] sprRen;

	private void Awake() {
		sprRen = gameObject.GetComponentsInChildren<SpriteRenderer>();
	}

	private void Update() {
		Color color = LevelData.Instance.levelColor;
		foreach (var boxSprRen in sprRen) {
			boxSprRen.color = color;
		}
	}
}
