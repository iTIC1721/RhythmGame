using UnityEngine;

public class CameraCtrl : MonoBehaviour {

	private Camera cameraComp;

	private void Awake() {
		cameraComp = gameObject.GetComponent<Camera>();
	}

	private void Update() {
		cameraComp.backgroundColor = LevelData.Instance.backColor;
	}
}
