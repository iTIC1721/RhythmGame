using UnityEngine;
using UnityEngine.UI;

public class EditManageScript : MonoBehaviour {
	
	public RectTransform editorContent;
	public Scrollbar scrollbar;

	private float sizeRate = 1.12f;

	private float size = 1f;

	private void Update() {
		if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))) {
			if (Input.GetAxis("Mouse ScrollWheel") > 0) {
				// 위로 스크롤
				editorContent.localScale = new Vector3(sizeRate * editorContent.localScale.x, 1, 1);
				RectTransform[] childContents = editorContent.GetComponentsInChildren<RectTransform>();
				foreach (var content in childContents) {
					if (content == editorContent) continue;
					content.localScale = new Vector3((1 / sizeRate) * content.localScale.x, 1, 1);
				}
				size *= sizeRate;
			}
			else if (Input.GetAxis("Mouse ScrollWheel") < 0) {
				// 아래로 스크롤
				if (size >= sizeRate) {
					editorContent.localScale = new Vector3((1 / sizeRate) * editorContent.localScale.x, 1, 1);
					RectTransform[] childContents = editorContent.GetComponentsInChildren<RectTransform>();
					foreach (var content in childContents) {
						if (content == editorContent) continue;
						content.localScale = new Vector3(sizeRate * content.localScale.x, 1, 1);
					}
					size *= (1 / sizeRate);
				}
			}
		}
	}
}
