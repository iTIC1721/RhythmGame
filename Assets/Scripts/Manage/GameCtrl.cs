using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameCtrl : MonoBehaviour {

	public MoodManager moodManager;
	public InputField inputField;
	public GameObject selectAudioUI;

	private IEnumerator getAudioCoroutine;
	private IEnumerator startCoroutine;

	public void BrowseAudioFile() {
		getAudioCoroutine = moodManager.GetAudioFileAndStartGame(inputField);
		StartCoroutine(getAudioCoroutine);
	}

	public void SetDifficulty(int difficulty) {
		moodManager.subbandBeatDetection.userDifficulty = (Difficulty)difficulty;
	}

	public void PressStartButton() {
		startCoroutine = moodManager.StartGame(moodManager.audioFileName);
		StartCoroutine(startCoroutine);
		selectAudioUI.SetActive(false);
	}

	private void Update() {
		// ESC키를 누르면 게임이 종료된다.
		if (Input.GetKeyDown(KeyCode.Escape)) {
			//Application.Quit();
		}
	}
}
