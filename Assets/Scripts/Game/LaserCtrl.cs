using System.Collections;
using UnityEngine;

public class LaserCtrl : MonoBehaviour {

	private const int levelSize = 512;
	private const float spriteMaxScale = 500f;
	
	// 방향 -> 0 : 오른쪽, 1 : 아래쪽, 2 : 왼쪽, 3 : 위쪽
	public int dir = 0;
	// 시작 점
	public int spawnPos = 0;
	// 유지 시간
	public float time = 0f;

	private float alpha = 1f;

	private SpriteRenderer sprRen;

	private void Awake() {
		sprRen = gameObject.GetComponent<SpriteRenderer>();
	}

	private void Update() {
		ReplaceLaser();
		ColorUpdate();
	}

	private void OnBecameInvisible() {
		Destroy(gameObject);
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.tag == "Player" && !LevelData.Instance.isInvincible && !LevelData.Instance.invincibleMode) {
			LevelData.Instance.playerHeart -= 1;
			LevelData.Instance.isInvincible = true;
			if (LevelData.Instance.playerHeart <= 0) {
				LevelCtrl.Instance.GameOver();
			}
			Destroy(gameObject);
		}
	}

	private void ReplaceLaser() {
		switch (dir) {
			case 0:
			case 2:
				gameObject.transform.localScale = new Vector3(1000, spriteMaxScale / ((LevelData.Instance.levelHeight * 2) + 1), 1);
				gameObject.transform.position = new Vector3(0, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0);
				break;

			case 1:
			case 3:
				gameObject.transform.localScale = new Vector3(spriteMaxScale / ((LevelData.Instance.levelWidth * 2) + 1), 1000, 1);
				gameObject.transform.position = new Vector3(spawnPos * (levelSize / ((LevelData.Instance.levelWidth * 2) + 1)), 0, 0);
				break;
		}
	}

	private void ColorUpdate() {
		Color enemyColor = LevelData.Instance.enemyColor;
		sprRen.color = new Color(enemyColor.r, enemyColor.g, enemyColor.b, alpha);

		if (alpha > 0) {
			alpha -= (Time.deltaTime / time);
		}
		else {
			alpha = 0;
			Destroy(gameObject);
		}
	}
}
