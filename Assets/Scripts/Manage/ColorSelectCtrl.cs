using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelectCtrl : MonoBehaviour {

	public SpriteRenderer playerSprite;
	public GameObject colorButtonPrefab;
	public GameObject specialButtonPrefab;
	public GameObject colorOutLinePrefab;
	public MoodManager moodManager;

	private GameObject[] colorButtons;
	private GameObject[] colorOutLines;

	// Color.clear = special button
	private readonly Color[] colors = { Color.red, new Color(1f, 0.5f, 0f), Color.yellow, Color.green, Color.cyan, Color.blue, new Color(0.6f, 0f, 0.8f), Color.magenta, new Color(0.75f, 0.75f, 0.75f), Color.gray };

	private void Start() {
		colorButtons = new GameObject[colors.Length];
		colorOutLines = new GameObject[colors.Length];
		for (int i = 0; i < colors.Length; i++) {
			// 버튼 생성
			if (colors[i] != Color.clear) {
				colorButtons[i] = (GameObject)Instantiate(colorButtonPrefab, gameObject.transform);
			}
			else {
				colorButtons[i] = (GameObject)Instantiate(specialButtonPrefab, gameObject.transform);
			}
			colorButtons[i].transform.localPosition = new Vector3((70 * i) - 415, 100, 0);

			Button button = colorButtons[i].GetComponent<Button>();

			ColorBlock cb = button.colors;
			cb.normalColor = colors[i];
			cb.highlightedColor = colors[i];
			cb.pressedColor = colors[i];
			button.colors = cb;

			int id = i;
			button.onClick.AddListener(() => SelectButton(id));

			// 외곽선 생성
			colorOutLines[i] = (GameObject)Instantiate(colorOutLinePrefab, gameObject.transform);
			colorOutLines[i].transform.localPosition = new Vector3((70 * i) - 415, 100, 0);
			colorOutLines[i].SetActive(false);
		}

		SelectButton(0);
	}

	public void SelectButton(int index) {
		if (index >= colors.Length) return;

		for (int i = 0; i < colors.Length; i++) {
			if (i != index) {
				colorOutLines[i].SetActive(false);
			}
			else {
				colorOutLines[i].SetActive(true);
				moodManager.backColor = colors[i];
			}
		}
	}
}
