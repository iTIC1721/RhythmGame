using UnityEngine;

public class CubesManager : MonoBehaviour {

	public CubeSound cubePrefabObject;
	public GameObject spectrumPrefabObject;
	public SubbandBeatDetection selectedBeatDetection;
	public MoodManager moodManager;

	public int cubesToSpawn;
	public float yPositionOfCubes = -10f;

	[System.NonSerialized]
	public bool isDebugMode = true;

	void Awake() {
		isDebugMode = selectedBeatDetection.debugMode;

		int j = 0;
		for (int i = 0; i < cubesToSpawn; i++) {
			CubeSound newCube = Instantiate<CubeSound>(cubePrefabObject);
			int[] toEar = { j, j + 1 };
			j += 2;
			newCube.selectedBeatDetection = selectedBeatDetection;
			newCube.cubesManager = gameObject.GetComponent<CubesManager>();
			newCube.subbandsToEar = toEar;
			newCube.smoothnessChange = 2f;
			newCube.isDebugMode = this.isDebugMode;

			if (!isDebugMode) {
				MeshRenderer renderer = newCube.gameObject.GetComponent<MeshRenderer>();
				renderer.material.color = new Color(0, 0, 0, 0);
				Debug.Log("Alpha!");
			}

			//newCube.transform.position = Vector3.right * (-cubesToSpawn + i * 2);
			newCube.transform.position = new Vector3(-cubesToSpawn + i * 2, yPositionOfCubes, 0);
			newCube.transform.SetParent(transform);
		}

		moodManager.GetCubeSounds(moodManager.cubeParent);
	}
}
