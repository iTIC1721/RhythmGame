using UnityEngine;
using UnityEngine.UI;

public class InvincibleText : MonoBehaviour {

	// 텍스트 컴포넌트
	Text textComp;

	// 오브젝트가 생성될 때 실행
	private void Awake() {
		// 텍스트 컴포넌트를 가져옴
		textComp = gameObject.GetComponent<Text>();
	}

	// 매 프레임마다 실행
	private void Update() {
		// 무적 모드 여부 표기
		if (!LevelData.Instance.invincibleMode) {
			textComp.enabled = false;
		}
		else {
			textComp.enabled = true;
		}
	}
}
