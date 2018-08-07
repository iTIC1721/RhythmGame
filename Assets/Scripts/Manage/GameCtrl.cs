using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameCtrl : MonoBehaviour {

	public MoodManager moodManager;
	public InputField localInputField;
	public InputField youtubeInputField;
	public GameObject selectAudioUI;

	public void BrowseAudioFile() {
		moodManager.BrowseLocalAudioFile(localInputField);
	}

	public void GetYoutubeAudio() {

	}

	public void SetDifficulty(int difficulty) {
		moodManager.subbandBeatDetection.userDifficulty = (Difficulty)difficulty;
	}

	public void PressStartButton() {
		StartCoroutine(StartButtonCoroutine());
		selectAudioUI.SetActive(false);
	}

	private IEnumerator StartButtonCoroutine() {
		yield return StartCoroutine(moodManager.GetLocalAudioFile());
		yield return StartCoroutine(moodManager.StartGame(moodManager.audioFileName));
	}

	private void Update() {
		// ESC키를 누르면 게임이 종료된다.
		if (Input.GetKeyDown(KeyCode.Escape)) {
			//Application.Quit();
		}
	}
}
