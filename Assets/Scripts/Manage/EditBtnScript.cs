using UnityEngine;
using UnityEngine.UI;

public class EditBtnScript : MonoBehaviour {
	
	public RectTransform editorContent;
	public Scrollbar scrollbar;

	private int sizeCount = 0;

	public void Click_UpSizeBtn() {
		editorContent.localScale = new Vector3(4.0f * editorContent.localScale.x, 1, 1);
		RectTransform[] childContents = editorContent.GetComponentsInChildren<RectTransform>();
		foreach (var content in childContents) {
			content.localScale = new Vector3(0.5f * content.localScale.x, 1, 1);
		}
		sizeCount++;
	}

	public void Click_DownSizeBtn() {
		if (sizeCount > 0) {
			editorContent.localScale = new Vector3(0.25f * editorContent.localScale.x, 1, 1);
			RectTransform[] childContents = editorContent.GetComponentsInChildren<RectTransform>();
			foreach (var content in childContents) {
				content.localScale = new Vector3(2f * content.localScale.x, 1, 1);
			}
			sizeCount--;
			scrollbar.size = 1 / Mathf.Pow(2, (sizeCount + 1));
		}
	}
}
