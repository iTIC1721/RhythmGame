using System.Collections;
using System.IO;
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
		moodManager.GetYoutubeAudioFile(youtubeInputField);
	}

	public void SetDifficulty(int difficulty) {
		moodManager.subbandBeatDetection.userDifficulty = (Difficulty)difficulty;
	}

	public void PressStartButton() {
		if (MoodManager.audioPath != "") {
			StartCoroutine(StartButtonCoroutine());
			selectAudioUI.SetActive(false);
		}
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

	private void OnApplicationQuit() {
		LevelCtrl.Instance.GameEnd();
		foreach (var path in moodManager.paths) {
			if (File.Exists(path)) {
				try {
					File.Delete(path);
				}
				catch {

				}
			}
		}
	}
}
