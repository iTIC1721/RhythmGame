using UnityEngine;

public class BoxCtrl : MonoBehaviour {

	// 스프라이트 렌더러
	private SpriteRenderer[] sprRen;

	// 오브젝트가 생성될 때 실행
	private void Awake() {
		// 모든 스프라이트 렌더러를 가져옴
		sprRen = gameObject.GetComponentsInChildren<SpriteRenderer>();
	}

	// 매 프레임마다 실행
	private void Update() {
		// 게임판의 색 설정
		Color color = LevelData.Instance.levelColor;
		foreach (var boxSprRen in sprRen) {
			boxSprRen.color = color;
		}
	}
}
