using System.Collections;
using UnityEngine;

public class Test1 : MonoBehaviour {

	private IEnumerator testCor;

	public AudioSource audioSource;
	public AudioClip music;

	private void Start() {
		testCor = TestCoroutine();
		StartCoroutine(testCor);

		audioSource.clip = music;
		audioSource.Play();

		LevelCtrl.Instance.StartGame("Invincible", "FlArEs", 2, 2);
	}

	IEnumerator TestCoroutine() {

		yield return new WaitForSeconds(0.7f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 20f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 20f, 1f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, 0, 20f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 20f, -1f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 20f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 20f, 1f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, 0, 20f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 20f, -1f);

		yield return new WaitForSeconds(0.5f);

		LevelCtrl.Instance.SpawnEnemy(1, -2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 20f, 0f);
		
		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.SpawnEnemy(1, -1, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 20f, 0f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.SpawnEnemy(0, 0, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 20f, 0f);

		yield return new WaitForSeconds(0.6f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 20f, 0f);

		yield return new WaitForSeconds(0.55f);

		LevelCtrl.Instance.SpawnEnemy(1, 0, 20f, 0.1f);

		yield return new WaitForSeconds(0.7f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, -0.05f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, -0.05f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, -0.05f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, -0.05f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, -0.05f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, -0.05f);

		yield return new WaitForSeconds(0.15f);
		
		LevelCtrl.Instance.ResizeLevel(3, 3);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 20f, 0f);

		yield return new WaitForSeconds(0.7f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 20f, 0f);

		yield return new WaitForSeconds(0.15f);

		LevelCtrl.Instance.SpawnEnemy(1, -2, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 20f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(0, -1, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 20f, 0f);

		yield return new WaitForSeconds(0.55f);

		LevelCtrl.Instance.ResizeLevel(2, 2);

		yield return new WaitForSeconds(0.4f);

		LevelCtrl.Instance.ResizeLevel(1, 1);

		yield return new WaitForSeconds(0.4f);

		LevelCtrl.Instance.SpawnEnemy(0, -1, 30f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 30f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 30f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 30f, 0f);

		yield return new WaitForSeconds(0.43f);

		LevelCtrl.Instance.SpawnEnemy(1, -1, 30f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 30f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 30f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 30f, 0f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.KillAll();
		LevelCtrl.Instance.ResizeLevel(2, 2);

		yield return new WaitForSeconds(0.15f);

		LevelCtrl.Instance.ResizeLevel(3, 3);

		yield return new WaitForSeconds(0.1f);

		LevelCtrl.Instance.ChangeBackColor(Color.white, 3f);

		yield return new WaitForSeconds(2.6f);
		// 첫번째 Drop 구간

		LevelCtrl.Instance.EnlargeLevel(0.8f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.RotateLevel(0.05f, 0f);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);
		LevelCtrl.Instance.ResizeLevel(5, 5);
		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.5f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.5f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);

		yield return new WaitForSeconds(0.15f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.23f);

		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);

		yield return new WaitForSeconds(0.15f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.23f);

		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.18f);

		LevelCtrl.Instance.SpawnEnemy(3, -5, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 20f, 0f);

		yield return new WaitForSeconds(0.09f);

		LevelCtrl.Instance.SpawnEnemy(3, -3, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 20f, 0f);

		yield return new WaitForSeconds(0.09f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 20f, 0f);

		yield return new WaitForSeconds(0.09f);

		LevelCtrl.Instance.SpawnEnemy(1, 5, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 20f, 0f);

		yield return new WaitForSeconds(0.09f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 20f, 0f);

		yield return new WaitForSeconds(0.09f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 20f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 20f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.KillAll();
		LevelCtrl.Instance.EnlargeLevel(1.3f, 0f);
		LevelCtrl.Instance.RotateLevel(-0.07f, 0f);
		LevelCtrl.Instance.ResizeLevel(3, 3);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 26f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 26f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.95f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.95f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.95f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 26f, 0f);

		yield return new WaitForSeconds(0.5f);

		LevelCtrl.Instance.SpawnEnemy(2, 102, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 101, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(1, 98, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 99, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(0, 98, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 99, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(3, 102, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 101, 25f, 0f);

		yield return new WaitForSeconds(0.16f);

		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.27f);

		LevelCtrl.Instance.SpawnEnemy(1, 100, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(3, 100, 25f, 0f);

		yield return new WaitForSeconds(0.12f);

		LevelCtrl.Instance.SpawnEnemy(2, 100, 25f, 0f);

		yield return new WaitForSeconds(0.12f);
		
		LevelCtrl.Instance.SpawnEnemy(0, 100, 25f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.EnlargeLevel(1.1f, 1f);
		LevelCtrl.Instance.RotateLevel(0f, 1f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);

		yield return new WaitForSeconds(0.22f);

		LevelCtrl.Instance.EnlargeLevel(0.9f, 0.5f);
		LevelCtrl.Instance.RotateLevel(-0.1f, 0.5f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.03f);
		
		LevelCtrl.Instance.SpawnEnemy(0, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.03f);
		
		LevelCtrl.Instance.SpawnEnemy(0, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.EnlargeLevel(1.3f, 0.4f);
		LevelCtrl.Instance.RotateLevel(1f, 0.4f);

		yield return new WaitForSeconds(0.29f);

		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 30f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 30f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 30f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 30f, 0f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.5f);

		yield return new WaitForSeconds(0.53f);

		LevelCtrl.Instance.EnlargeLevel(1f, 0f);
		LevelCtrl.Instance.RotateLevel(0.01f, 0f);
		LevelCtrl.Instance.MoveLevel(100f, 60f, 0f);
		LevelCtrl.Instance.ResizeLevel(4, 4);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.5f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.02f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.02f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, -0.01f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.02f);

		yield return new WaitForSeconds(0.5f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.4f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);

		yield return new WaitForSeconds(0.06f);

		LevelCtrl.Instance.SpawnLaser(1, 1, 0.4f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);

		yield return new WaitForSeconds(0.06f);

		LevelCtrl.Instance.SpawnLaser(2, -1, 0.4f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);

		yield return new WaitForSeconds(0.06f);

		LevelCtrl.Instance.SpawnLaser(3, -1, 0.4f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);

		yield return new WaitForSeconds(0.1f);

		LevelCtrl.Instance.SpawnLaser(0, 4, 0.35f);
		LevelCtrl.Instance.SpawnLaser(2, -4, 0.35f);
		LevelCtrl.Instance.SpawnLaser(0, 2, 0.35f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.35f);
		LevelCtrl.Instance.SpawnLaser(1, 4, 0.35f);
		LevelCtrl.Instance.SpawnLaser(3, -4, 0.35f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.35f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.35f);

		yield return new WaitForSeconds(0.23f);

		LevelCtrl.Instance.SpawnLaser(2, 3, 0.35f);
		LevelCtrl.Instance.SpawnLaser(0, -3, 0.35f);
		LevelCtrl.Instance.SpawnLaser(2, 1, 0.35f);
		LevelCtrl.Instance.SpawnLaser(0, -1, 0.35f);
		LevelCtrl.Instance.SpawnLaser(3, 3, 0.35f);
		LevelCtrl.Instance.SpawnLaser(1, -3, 0.35f);
		LevelCtrl.Instance.SpawnLaser(3, 1, 0.35f);
		LevelCtrl.Instance.SpawnLaser(1, -1, 0.35f);

		yield return new WaitForSeconds(0.25f);

		LevelCtrl.Instance.EnlargeLevel(0.9f, 0f);
		LevelCtrl.Instance.RotateLevel(-0.01f, 0f);
		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);

		yield return new WaitForSeconds(0.06f);

		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);

		yield return new WaitForSeconds(0.06f);

		LevelCtrl.Instance.SpawnLaser(2, -2, 0.4f);
		LevelCtrl.Instance.SpawnLaser(0, 0, 0.4f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);

		yield return new WaitForSeconds(0.06f);

		LevelCtrl.Instance.SpawnLaser(3, -2, 0.4f);
		LevelCtrl.Instance.SpawnLaser(1, 0, 0.4f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);

		yield return new WaitForSeconds(0.18f);
		
		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.13f);
		
		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);

		yield return new WaitForSeconds(0.25f);

		LevelCtrl.Instance.EnlargeLevel(0.95f, 0f);
		LevelCtrl.Instance.RotateLevel(0.005f, 0f);
		LevelCtrl.Instance.SpawnLaser(2, 2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 27f, 0f);

		yield return new WaitForSeconds(0.06f);

		LevelCtrl.Instance.SpawnLaser(3, 2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 27f, 0f);

		yield return new WaitForSeconds(0.06f);

		LevelCtrl.Instance.SpawnLaser(0, -2, 0.4f);
		LevelCtrl.Instance.SpawnLaser(2, 0, 0.4f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 27f, 0f);

		yield return new WaitForSeconds(0.06f);

		LevelCtrl.Instance.SpawnLaser(1, -2, 0.4f);
		LevelCtrl.Instance.SpawnLaser(3, 0, 0.4f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 27f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.13f);

		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);

		yield return new WaitForSeconds(0.22f);

		LevelCtrl.Instance.SpawnLaser(0, 4, 0.35f);
		LevelCtrl.Instance.SpawnLaser(2, -4, 0.35f);
		LevelCtrl.Instance.SpawnLaser(0, 2, 0.35f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.35f);
		LevelCtrl.Instance.SpawnLaser(1, 4, 0.35f);
		LevelCtrl.Instance.SpawnLaser(3, -4, 0.35f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.35f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.35f);

		yield return new WaitForSeconds(0.1f);

		LevelCtrl.Instance.ChangeBackColor(Color.white, 1f);
		LevelCtrl.Instance.SpawnLaser(2, 3, 0.35f);
		LevelCtrl.Instance.SpawnLaser(0, -3, 0.35f);
		LevelCtrl.Instance.SpawnLaser(2, 1, 0.35f);
		LevelCtrl.Instance.SpawnLaser(0, -1, 0.35f);
		LevelCtrl.Instance.SpawnLaser(3, 3, 0.35f);
		LevelCtrl.Instance.SpawnLaser(1, -3, 0.35f);
		LevelCtrl.Instance.SpawnLaser(3, 1, 0.35f);
		LevelCtrl.Instance.SpawnLaser(1, -1, 0.35f);

		yield return new WaitForSeconds(0.38f);

		LevelCtrl.Instance.KillAll();
		LevelCtrl.Instance.MoveLevel(-100, -20, 0f);
		LevelCtrl.Instance.RotateLevel(-0.05f, 0f);
		LevelCtrl.Instance.ResizeLevel(5, 5);
		LevelCtrl.Instance.EnlargeLevel(0.85f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnLaser(0, 1, 0.5f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.5f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.5f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.5f);

		yield return new WaitForSeconds(0.001f);

		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.5f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.5f);

		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);

		yield return new WaitForSeconds(0.11f);

		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);

		yield return new WaitForSeconds(0.11f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);

		yield return new WaitForSeconds(0.11f);

		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);

		yield return new WaitForSeconds(0.18f);

		LevelCtrl.Instance.MoveLevel(-90, -15, 0f);
		LevelCtrl.Instance.RotateLevel(0.04f, 0f);
		LevelCtrl.Instance.EnlargeLevel(0.9f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnLaser(0, 2, 0.5f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.5f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.5f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.5f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.MoveLevel(-80, -6, 0f);
		LevelCtrl.Instance.RotateLevel(-0.1f, 0f);
		LevelCtrl.Instance.EnlargeLevel(0.8f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnLaser(0, 3, 0.5f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.5f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.5f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.5f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0f);

		yield return new WaitForSeconds(0.23f);

		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);

		yield return new WaitForSeconds(0.11f);

		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);

		yield return new WaitForSeconds(0.11f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);

		yield return new WaitForSeconds(0.11f);

		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);

		yield return new WaitForSeconds(0.2f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 25f, -0.15f);
		LevelCtrl.Instance.EnlargeLevel(2.1f, 1.2f);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 4f);
		LevelCtrl.Instance.MoveLevel(0, 0, 1.2f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 5, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 4, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, -0.15f);

		yield return new WaitForSeconds(0.01f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, -0.15f);
		LevelCtrl.Instance.EnlargeLevel(0.7f, 0.3f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.03f);

		LevelCtrl.Instance.SpawnEnemy(2, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 24f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 27f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 26f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 24f, 0f);

		yield return new WaitForSeconds(0.55f);

		LevelCtrl.Instance.KillAll();
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.RotateLevel(0f, 0f);
		LevelCtrl.Instance.EnlargeLevel(1.5f, 0f);
		LevelCtrl.Instance.MoveLevel(0f, 0f, 0f);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.7f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.7f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.7f);

		yield return new WaitForSeconds(0.55f);
		// 색 변화 구간

		LevelCtrl.Instance.EnlargeLevel(1f, 0f);
		LevelCtrl.Instance.ResizeLevel(3, 3);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.2f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(1f, 0.55f, 0.55f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(1f, 0.75f, 0.55f), 0.5f);

		yield return new WaitForSeconds(0.5f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, -0.3f);

		yield return new WaitForSeconds(0.27f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.3f);

		yield return new WaitForSeconds(0.27f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 24f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -0, 24f, -0.2f);

		yield return new WaitForSeconds(0.27f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 24f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -0, 24f, -0.2f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.EnlargeLevel(0.9f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.1f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(1f, 0.75f, 0.55f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(1f, 1f, 0.55f), 0.5f);

		yield return new WaitForSeconds(0.6f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.3f);

		yield return new WaitForSeconds(0.27f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, -0.3f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, -0.3f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.SpawnLaser(0, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, 0, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 25f, -0.3f);

		yield return new WaitForSeconds(0.29f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.3f);

		yield return new WaitForSeconds(0.29f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, -0.3f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.EnlargeLevel(0.8f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(1f, 1f, 0.55f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(0.75f, 1f, 0.55f), 0.5f);

		yield return new WaitForSeconds(0.65f);

		LevelCtrl.Instance.EnlargeLevel(1.2f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 22f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 22f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 22f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 22f, -0.2f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.4f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(0.75f, 1f, 0.55f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(0.75f, 1f, 0.75f), 0.5f);

		yield return new WaitForSeconds(0.5f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, -0.55f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, -0.55f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, -0.55f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, -0.55f);

		yield return new WaitForSeconds(0.27f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.55f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.55f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.55f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.55f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.SpawnLaser(0, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, 0, 0.3f);

		yield return new WaitForSeconds(0.29f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.EnlargeLevel(1f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, -0.3f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.2f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(0.75f, 1f, 0.75f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(0.75f, 1f, 1f), 0.5f);

		yield return new WaitForSeconds(0.27f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, -0.3f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.SpawnLaser(0, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, 0, 0.3f);

		yield return new WaitForSeconds(0.29f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, -0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, -0.3f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);

		yield return new WaitForSeconds(0.32f);

		LevelCtrl.Instance.EnlargeLevel(1.5f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.7f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(0.75f, 1f, 1f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(0.75f, 0.75f, 1f), 0.5f);

		yield return new WaitForSeconds(0.32f);

		LevelCtrl.Instance.EnlargeLevel(1.3f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.5f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(0.55f, 0.75f, 1f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(0.55f, 0.55f, 1f), 0.5f);

		yield return new WaitForSeconds(0.32f);

		LevelCtrl.Instance.EnlargeLevel(1f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 27f, -0.2f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.2f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(0.55f, 0.55f, 1f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(0.85f, 0.55f, 1f), 0.5f);

		yield return new WaitForSeconds(0.55f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 27f, -0.2f);

		yield return new WaitForSeconds(0.35f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);

		yield return new WaitForSeconds(0.22f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 27f, -0.2f);

		yield return new WaitForSeconds(0.27f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 27f, -0.2f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.EnlargeLevel(1.2f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 27f, -0.2f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.4f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(0.85f, 0.55f, 1f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(1f, 0.55f, 1f), 0.5f);

		yield return new WaitForSeconds(0.62f);
		
		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 27f, -0.2f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 27f, -0.2f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 27f, -0.2f);

		yield return new WaitForSeconds(0.29f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 27f, -0.2f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.SpawnLaser(0, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 0, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, 0, 0.3f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.EnlargeLevel(1.6f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.8f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(1f, 0.55f, 1f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(1f, 0.55f, 0.85f), 0.5f);

		yield return new WaitForSeconds(0.6f);

		LevelCtrl.Instance.EnlargeLevel(1f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);
		
		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.2f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(1f, 0.55f, 0.85f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(1f, 0.55f, 0.55f), 0.5f);

		yield return new WaitForSeconds(0.57f);

		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 27f, -0.2f);

		yield return new WaitForSeconds(0.26f);

		LevelCtrl.Instance.SpawnEnemy(0, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 25f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 27f, -0.2f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 27f, -0.2f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);

		yield return new WaitForSeconds(0.28f);

		LevelCtrl.Instance.SpawnLaser(0, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.3f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.EnlargeLevel(0.9f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnLaser(0, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.3f);
		LevelCtrl.Instance.SpawnLaser(0, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.3f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.3f);

		yield return new WaitForSeconds(0.005f);

		LevelCtrl.Instance.EnlargeLevel(1.4f, 4f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.5f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(1f, 0.55f, 0.55f), 0.5f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(1f, 0.85f, 0.55f), 0.5f);

		yield return new WaitForSeconds(0.6f);

		LevelCtrl.Instance.ChangeLevelColor(Color.white, 2.5f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 2.5f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, 0f);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0.68f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(1, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(2, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 25f, 0f);

		yield return new WaitForSeconds(0.02f);

		LevelCtrl.Instance.SpawnEnemy(3, 1, 25f, 0f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 25f, 0f);

		yield return new WaitForSeconds(0.50f);
		// BreakDown 구간

		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.EnlargeLevel(2f, 0f);
		LevelCtrl.Instance.ChangeBackColor(new Color(0.5f, 0.5f, 0.5f), 0f);

		LevelCtrl.Instance.SpawnEnemy(0, 0, 4f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 4f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 4f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 4f, -0.02f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 30f, -0.1f);

		yield return new WaitForSeconds(0.001f);

		LevelCtrl.Instance.EnlargeLevel(2.4f, 6f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(0.5f, 0.5f, 0.5f), 1f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(0.75f, 0.75f, 0.75f), 1f);

		yield return new WaitForSeconds(4.7f);

		LevelCtrl.Instance.KillAll();
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.EnlargeLevel(1.6f, 0f);
		LevelCtrl.Instance.ChangeBackColor(new Color(0.5f, 0.5f, 0.5f), 0f);

		LevelCtrl.Instance.SpawnEnemy(0, 0, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 20f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 25f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 30f, -0.1f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 30f, -0.1f);

		yield return new WaitForSeconds(0.001f);

		LevelCtrl.Instance.EnlargeLevel(2f, 6f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(0.75f, 0.75f, 0.75f), 1f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(1f, 1f, 1f), 1f);

		yield return new WaitForSeconds(2.35f);

		LevelCtrl.Instance.MoveLevel(50f, 0f, 0f);
		LevelCtrl.Instance.SpawnLaser(0, 2, 0.5f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.5f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.5f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.5f);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.7f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.7f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.7f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.MoveLevel(-50f, 0f, 0f);
		LevelCtrl.Instance.SpawnLaser(0, 1, 0.5f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.5f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.5f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.5f);
		LevelCtrl.Instance.SpawnLaser(0, 3, 0.5f);
		LevelCtrl.Instance.SpawnLaser(1, 3, 0.5f);
		LevelCtrl.Instance.SpawnLaser(2, -3, 0.5f);
		LevelCtrl.Instance.SpawnLaser(3, -3, 0.5f);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.7f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.7f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.7f);

		yield return new WaitForSeconds(0.3f);

		LevelCtrl.Instance.MoveLevel(0f, 0f, 0f);
		LevelCtrl.Instance.SpawnLaser(0, 2, 0.5f);
		LevelCtrl.Instance.SpawnLaser(1, 2, 0.5f);
		LevelCtrl.Instance.SpawnLaser(2, -2, 0.5f);
		LevelCtrl.Instance.SpawnLaser(3, -2, 0.5f);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.7f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.7f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.7f);

		yield return new WaitForSeconds(0.25f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 20f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 20f, 0.01f);

		yield return new WaitForSeconds(0.17f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 20f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 20f, 0.01f);
		LevelCtrl.Instance.ChangeLevelColor(new Color(0.8f, 0.8f, 0.8f), 1f);
		LevelCtrl.Instance.ChangeEnemyColor(new Color(0.8f, 0.8f, 0.8f), 1f);

		yield return new WaitForSeconds(0.43f);
		
		LevelCtrl.Instance.SpawnLaser(0, 1, 0.2f);
		LevelCtrl.Instance.SpawnLaser(1, 1, 0.2f);
		LevelCtrl.Instance.SpawnLaser(2, -1, 0.2f);
		LevelCtrl.Instance.SpawnLaser(3, -1, 0.2f);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 0.7f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0.7f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0.7f);

		yield return new WaitForSeconds(0.25f);

		LevelCtrl.Instance.SpawnEnemy(0, 2, 20f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 20f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 20f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 20f, 0.01f);

		yield return new WaitForSeconds(0.25f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 20f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 20f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 20f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 20f, 0.01f);

		yield return new WaitForSeconds(0.27f);
		
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 24f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 23f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 22f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 21f, 0.01f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 1f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 1f);

		yield return new WaitForSeconds(1.25f);

		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 24f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 23f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 22f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 21f, 0.01f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 1f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 1f);

		yield return new WaitForSeconds(1.22f);

		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 24f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 23f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 22f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 21f, 0.01f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 1f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 1f);

		yield return new WaitForSeconds(1.19f);

		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 24f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 23f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 22f, 0.01f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 21f, 0.01f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 1f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 1f);

		yield return new WaitForSeconds(1.14f);

		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);
		LevelCtrl.Instance.EnlargeLevel(0.6f, 5f);

		LevelCtrl.Instance.SpawnEnemy(0, 3, 5f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 6f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 3f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 5f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 6f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 5f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 6f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 3f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 8f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 3f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 5f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 3f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 0.4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 0.4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 0.4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 0.4f, -0.001f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 1f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 1f);

		yield return new WaitForSeconds(1.75f);

		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnEnemy(0, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 0.4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 0.4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 0.4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 0.4f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 0, 0.1f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 0.1f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 0.1f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 0.1f, -0.001f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.ChangeBackColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 1f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 1f);

		yield return new WaitForSeconds(0.45f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 0.7f, -0.001f);

		yield return new WaitForSeconds(1.3f);

		LevelCtrl.Instance.EnlargeLevel(1.5f, 0f);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		LevelCtrl.Instance.SpawnEnemy(0, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 0, 0.7f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 1, 10f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 10f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 10f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 10f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 10f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 10f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 10f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 10f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 20f, -0.001f);

		yield return new WaitForSeconds(0.0001f);

		LevelCtrl.Instance.EnlargeLevel(1.7f, 3f);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 1f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 1f);

		yield return new WaitForSeconds(0.53f);

		LevelCtrl.Instance.KillAll();
		LevelCtrl.Instance.EnlargeLevel(1f, 0f);
		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.PlayerVisible(false);
		LevelCtrl.Instance.ChangeBackColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 0f);

		yield return new WaitForSeconds(0.64f);
		// Drop 구간

		LevelCtrl.Instance.ReplacePlayer(new Vector2(0, 0));
		LevelCtrl.Instance.PlayerVisible(true);
		LevelCtrl.Instance.ResizeLevel(5, 5);
		LevelCtrl.Instance.ChangeBackColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeLevelColor(Color.white, 0f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.white, 0f);
		
		LevelCtrl.Instance.SpawnEnemy(0, 1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 30f, -0.001f);

		yield return new WaitForSeconds(0.001f);
		
		LevelCtrl.Instance.ChangeLevelColor(Color.black, 1f);
		LevelCtrl.Instance.ChangeEnemyColor(Color.black, 1f);

		yield return new WaitForSeconds(0.05f);

		LevelCtrl.Instance.SpawnEnemy(0, 1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -1, 15f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -2, 20f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -3, 25f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -4, 28f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, 5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, 5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, 5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, 5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(0, -5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(1, -5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(2, -5, 30f, -0.001f);
		LevelCtrl.Instance.SpawnEnemy(3, -5, 30f, -0.001f);
	}
}
