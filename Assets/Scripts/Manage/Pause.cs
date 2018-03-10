using UnityEngine;

public class Pause : MonoBehaviour {
	private void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			LevelCtrl.Instance.PauseResume();
		}
	}
}
