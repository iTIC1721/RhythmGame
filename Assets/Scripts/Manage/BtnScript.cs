using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnScript : MonoBehaviour {

	// 레벨 타입을 나타내는 열거형
	public enum LevelPlayType {
		NonDamage,
		Normal,
		Challenge
	}

	// 메인 씬에서 플레이 버튼을 누를 시 실행
	public void Main_PlayButton_Clicked() {
		SceneManager.LoadScene("LevelSelect");
	}

	// 레벨 선택 창에서 Invincible 레벨을 플레이할 시 실행
	public void LevelSelect_Invincible_Play(int type) {
		switch (type) {
			// 무적 모드
			case (int)LevelPlayType.NonDamage:
				ManageScript.Instance.LevelInitialize(true, 10);
				SceneManager.LoadScene("ProtoType");
				break;

			// 일반 모드
			case (int)LevelPlayType.Normal:
				ManageScript.Instance.LevelInitialize(false, 10);
				SceneManager.LoadScene("ProtoType");
				break;

			// 챌린지 모드
			case (int)LevelPlayType.Challenge:
				ManageScript.Instance.LevelInitialize(false, 1);
				SceneManager.LoadScene("ProtoType");
				break;
		}
	}
}
