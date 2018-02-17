using UnityEngine;

public class EnemyCtrl : MonoBehaviour {

	private const int levelSize = 512;
	private const float spriteMaxScale = 500f;

	// 방향 -> 0 : 오른쪽, 1 : 아래쪽, 2 : 왼쪽, 3 : 위쪽
	public int dir = 0;
	// 시작 점
	public int spawnPos = 0;
	// 속도
	public float speed = 10f;
	// 가속도
	public float velo = 0f;

	private SpriteRenderer sprRen;

	private void Awake() {
		sprRen = gameObject.GetComponent<SpriteRenderer>();
	}

	private void Update() {
		ReplaceEnemy();
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

	private void ReplaceEnemy() {
		gameObject.transform.localScale = new Vector3(spriteMaxScale / ((LevelData.Instance.levelWidth * 2) + 1), spriteMaxScale / ((LevelData.Instance.levelHeight * 2) + 1), 1);
		switch (dir) {
			case 0:
				gameObject.transform.position += new Vector3(-speed, 0, 0);
				break;
			case 1:
				gameObject.transform.position += new Vector3(0, speed, 0);
				break;
			case 2:
				gameObject.transform.position += new Vector3(speed, 0, 0);
				break;
			case 3:
				gameObject.transform.position += new Vector3(0, -speed, 0);
				break;
		}
		speed += velo;
	}

	private void ColorUpdate() {
		sprRen.color = LevelData.Instance.enemyColor;
	}
}
