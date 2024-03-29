﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class EditManageScript : Singleton<EditManageScript> {

	public RectTransform editorContent;
	public Scrollbar scrollbar;
	public Text sizeRateText;
	public GameObject commandPrefab;

	public GameObject timeBar;
	private float selectedTime = 0f;
	private bool canUpdateTimeBar = true;

	public float musicLength = 0f;

	private float sizeRate = 1.12f;
	private float contentMoveSpeed = 0.04f;

	[NonSerialized]
	public float size = 1f;

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
		UpdateTimeBar();
	}

	private void MouseScroll() {
		if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))) {
			if (Input.GetAxis("Mouse ScrollWheel") > 0) {
				if (size * sizeRate <= 10000f) {
					// 위로 스크롤
					editorContent.localScale = new Vector3(sizeRate * editorContent.localScale.x, 1, 1);
					RectTransform[] childContents = editorContent.GetComponentsInChildren<RectTransform>();
					foreach (var content in childContents) {
						if (content.CompareTag("Command") || content.CompareTag("TimeBar"))
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
							if (content.CompareTag("Command") || content.CompareTag("TimeBar"))
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

	private void UpdateTimeBar() {
		if (Input.GetMouseButtonDown(0)) {
			if ((Input.mousePosition.y >= 0 && Input.mousePosition.y <= 20) || (Input.mousePosition.y >= 280 && Input.mousePosition.y <= 768)) {
				canUpdateTimeBar = false;
			}
			else {
				canUpdateTimeBar = true;
				scrollbar.interactable = false;
			}
		}
		else if (Input.GetMouseButtonUp(0)) {
			canUpdateTimeBar = true;
			scrollbar.interactable = true;
		}

		if (Input.GetMouseButton(0) && canUpdateTimeBar) {
			if ((Input.mousePosition.y >= 20 && Input.mousePosition.y <= 280) && (Input.mousePosition.x >= 0 && Input.mousePosition.x <= 1024)) {
				timeBar.transform.position = new Vector3(Input.mousePosition.x, 150, 0);
				selectedTime = ((gameObject.transform.localPosition.x + 512) / 1024) * musicLength;
			}
		}
	}
}
