using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnScript : MonoBehaviour {

	public enum LevelPlayType {
		NonDamage,
		Normal,
		Challenge
	}

	public void Main_PlayButton_Clicked() {
		SceneManager.LoadScene("LevelSelect");
	}

	public void LevelSelect_Invincible_Play(int type) {
		switch (type) {
			case (int)LevelPlayType.NonDamage:
				ManageScript.Instance.LevelInitialize(true, 10);
				SceneManager.LoadScene("ProtoType");
				break;

			case (int)LevelPlayType.Normal:
				ManageScript.Instance.LevelInitialize(false, 10);
				SceneManager.LoadScene("ProtoType");
				break;

			case (int)LevelPlayType.Challenge:
				ManageScript.Instance.LevelInitialize(false, 1);
				SceneManager.LoadScene("ProtoType");
				break;
		}
	}
}
