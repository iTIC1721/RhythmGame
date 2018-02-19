using UnityEngine.UI;

public class HeartText : Singleton<HeartText> {

	// 텍스트 컴포넌트
	Text textComp;

	// 오브젝트가 생성될 때 실행
	private void Awake() {
		// 텍스트 컴포넌트를 가져옴
		textComp = gameObject.GetComponent<Text>();
	}

	public void TextUpdate() {
		// 남은 생명 개수를 표기
		textComp.text = "Heart Left : " + LevelData.Instance.playerHeart;
	}
}
