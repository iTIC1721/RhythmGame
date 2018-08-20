using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAudioCtrl : MonoBehaviour {

	public List<Button> audioButtons;
	public List<GameObject> panels;

	private readonly Color selectedColor = new Color(0.7f, 0.7f, 0.7f, 200f / 255f);
	private readonly Color unSelectedColor = new Color(1, 1, 1, 100f / 255f);

	private void Start() {
		if (audioButtons.Capacity != panels.Capacity) throw new Exception("AudioButtons and Panels do not have the same capacity.");

		SelectButton(0);
	}

	public void SelectButton(int index) {
		if (index < audioButtons.Capacity) {
			for (int i = 0; i < audioButtons.Capacity; i++) {
				if (i != index) {
					ColorBlock cb = audioButtons[i].colors;
					cb.normalColor = unSelectedColor;
					cb.pressedColor = unSelectedColor;
					cb.highlightedColor = unSelectedColor;
					audioButtons[i].colors = cb;

					panels[i].SetActive(false);
				}
				else {
					ColorBlock cb = audioButtons[i].colors;
					cb.normalColor = selectedColor;
					cb.pressedColor = selectedColor;
					cb.highlightedColor = selectedColor;
					audioButtons[i].colors = cb;

					panels[i].SetActive(true);
				}
			}
		}
	}
}
