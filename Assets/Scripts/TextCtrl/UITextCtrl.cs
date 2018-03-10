using UnityEngine;
using UnityEngine.UI;

public class UITextCtrl : MonoBehaviour {

	// 텍스트 컴포넌트
	private Text textComp;

	// 오브젝트가 생성될 때 실행
	private void Awake() {
		// 텍스트 컴포넌트를 가져옴
		textComp = gameObject.GetComponent<Text>();
	}

	// 매 프레임마다 실행
	private void Update() {
		if (!LevelCtrl.Instance.isPaused) {
			// 레벨 이름과 레벨 디자이너가 표기된 텍스트 오브젝트에 맞추어 다르게 조정함
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
}
