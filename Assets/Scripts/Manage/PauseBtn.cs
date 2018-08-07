using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBtn : MonoBehaviour {

	public void PauseResume() {
		LevelCtrl.Instance.PauseResume();
	}

	public void MainMenu() {
		LevelCtrl.Instance.isPaused = false;
		LevelCtrl.Instance.pauseUI.SetActive(false);
		Time.timeScale = 1;
		LevelCtrl.Instance.audioSource.Stop();
		LevelCtrl.Instance.playing = false;
		LevelCtrl.Instance.KillAll();
		LevelCtrl.Instance.bChangeEnable = false;
		LevelCtrl.Instance.lChangeEnable = false;
		LevelCtrl.Instance.eChangeEnable = false;
		LevelData.Instance.backColor = Color.black;
		LevelData.Instance.levelColor = Color.white;
		LevelData.Instance.enemyColor = Color.white;
		LevelData.Instance.heartColor = Color.red;

		LevelCtrl.Instance.GameEnd();

		//SceneManager.LoadScene("LevelSelect");
	}
}
