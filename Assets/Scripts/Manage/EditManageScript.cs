using UnityEngine;
using UnityEngine.UI;

public class EditManageScript : MonoBehaviour {

	private const string MouseScrollWheel = "Mouse ScrollWheel";

	public RectTransform editorContent;
	public Scrollbar scrollbar;
	public GameObject commandPrefab;

	private float sizeRate = 1.12f;
	private float contentMoveSpeed = 0.04f;

	private float size = 1f;

	private void Update() {
		MouseScroll();
		LeftRightMove();
		EditorContentMouseClick();
	}

	private void MouseScroll() {
		if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))) {
			if (Input.GetAxis(MouseScrollWheel) > 0) {
				// 위로 스크롤
				editorContent.localScale = new Vector3(sizeRate * editorContent.localScale.x, 1, 1);
				RectTransform[] childContents = editorContent.GetComponentsInChildren<RectTransform>();
				foreach (var content in childContents) {
					if (content == editorContent) continue;
					content.localScale = new Vector3((1 / sizeRate) * content.localScale.x, 1, 1);
				}
				size *= sizeRate;
			}
			else if (Input.GetAxis(MouseScrollWheel) < 0) {
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

	private void LeftRightMove() {
		if (Input.GetKey(KeyCode.RightArrow)) {
			scrollbar.value += contentMoveSpeed / size;
		}
		else if (Input.GetKey(KeyCode.LeftArrow)) {
			scrollbar.value -= contentMoveSpeed / size;
		}
	}

	private void EditorContentMouseClick() {
		if (Input.GetMouseButtonDown(1)) {
			if (Input.mousePosition.y >= 0 && Input.mousePosition.y <= 300) {
				GameObject commandObj = Instantiate(commandPrefab, new Vector3(Input.mousePosition.x, 160, 0), Quaternion.identity, editorContent) as GameObject;
				commandObj.transform.localScale = new Vector3(1 / size, 1, 1);
			}
		}
	}
}
