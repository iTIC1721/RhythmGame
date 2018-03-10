using UnityEngine;
using UnityEngine.UI;

public class EditManageScript : MonoBehaviour {

	public RectTransform editorContent;
	public Scrollbar scrollbar;
	public Text sizeRateText;
	public GameObject commandPrefab;

	private float sizeRate = 1.12f;
	private float contentMoveSpeed = 0.04f;

	private float size = 1f;

	private Color textColor;

	[System.NonSerialized]
	public GameObject commandSettingObj;

	private void Awake() {
		commandSettingObj = GameObject.FindGameObjectWithTag("CommandSetting");
		commandSettingObj.SetActive(false);
	}

	private void Update() {
		MouseScroll();
		LeftRightMove();
		EditorContentMouseClick();
	}

	private void MouseScroll() {
		if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))) {
			if (Input.GetAxis("Mouse ScrollWheel") > 0) {
				if (size * sizeRate <= 10000f) {
					// 위로 스크롤
					editorContent.localScale = new Vector3(sizeRate * editorContent.localScale.x, 1, 1);
					RectTransform[] childContents = editorContent.GetComponentsInChildren<RectTransform>();
					foreach (var content in childContents) {
						if (content.CompareTag("Command"))
							content.localScale = new Vector3((1 / sizeRate) * content.localScale.x, 1, 1);
					}
					size *= sizeRate;

					textColor = sizeRateText.color;
					sizeRateText.color = new Color(textColor.r, textColor.g, textColor.b, 1);
					sizeRateText.text = Mathf.Round((size * 100)).ToString() + "%";
				}
			}
			else if (Input.GetAxis("Mouse ScrollWheel") < 0) {
				if (size >= 1) {
					// 아래로 스크롤
					if (size >= sizeRate) {
						editorContent.localScale = new Vector3((1 / sizeRate) * editorContent.localScale.x, 1, 1);
						RectTransform[] childContents = editorContent.GetComponentsInChildren<RectTransform>();
						foreach (var content in childContents) {
							if (content.CompareTag("Command"))
								content.localScale = new Vector3(sizeRate * content.localScale.x, 1, 1);
						}
						size *= (1 / sizeRate);

						textColor = sizeRateText.color;
						sizeRateText.color = new Color(textColor.r, textColor.g, textColor.b, 1);
						sizeRateText.text = Mathf.Round((size * 100)).ToString() + "%";
					}
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
				GameObject commandObj = Instantiate(commandPrefab, new Vector3(Input.mousePosition.x, 150, 0), Quaternion.identity, editorContent) as GameObject;
				commandObj.transform.localScale = new Vector3(1 / size, 1, 1);
			}
		}
	}
}
