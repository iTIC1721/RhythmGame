using UnityEngine;
using UnityEngine.UI;

public class GameOverCtrl : MonoBehaviour {

	// 텍스트 컴포넌트
	private Text textComp;

	// 오브젝트가 생성될 때 실행
	private void Awake() {
		// 텍스트 컴포넌트를 가져옴
		textComp = gameObject.GetComponent<Text>();
	}

	// 매 프레임마다 실행
	private void Update() {
		// 게임 오버 시 표시됨
		if (!LevelData.Instance.gameOver) {
			textComp.enabled = false;
		}
		else {
			textComp.enabled = true;
		}
	}
}
