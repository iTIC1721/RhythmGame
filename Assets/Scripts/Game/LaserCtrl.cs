using System.Collections;
using UnityEngine;

public class LaserCtrl : MonoBehaviour {

	// 게임판의 고정 크기
	private const int levelSize = 512;
	// 스프라이트의 기본 크기
	private const float spriteMaxScale = 500f;
	
	// 방향 -> 0 : 오른쪽, 1 : 아래쪽, 2 : 왼쪽, 3 : 위쪽
	public Direction dir = 0;
	// 시작 점
	public int spawnPos = 0;
	// 유지 시간
	public float time = 0f;
	// 투명도
	private float alpha = 1f;

	private Color enemyColor;

	// 오브젝트의 스프라이트 렌더러
	private SpriteRenderer sprRen;

	// 오브젝트가 생성될 때 실행
	private void Awake() {
		// 스프라이트 렌더러를 가져옴
		sprRen = gameObject.GetComponent<SpriteRenderer>();
		// 색 초기화
		enemyColor = LevelData.Instance.enemyColor;
	}

	// 매 프레임마다 실행
	private void Update() {
		ReplaceLaser();
		ColorUpdate();
	}

	// 게임 화면을 벗어났을 때
	private void OnBecameInvisible() {
		Destroy(gameObject);
	}

	// 충돌이 발생했을 때
	private void OnTriggerEnter2D(Collider2D collision) {
		// 충돌한 대상이 무적이 아닌 플레이어일 때
		if (collision.CompareTag("Player") && !LevelData.Instance.isInvincible && !LevelData.Instance.invincibleMode) {
			// 플레이어의 생명을 1 감소시킴
			LevelData.Instance.playerHeart -= 1;
			HeartText.Instance.TextUpdate();
			// 무적 상태로 전환
			LevelData.Instance.isInvincible = true;
			// 생명이 없으면
			if (LevelData.Instance.playerHeart <= 0) {
				// 게임 오버
				LevelCtrl.Instance.GameOver();
			}
			// 해당 오브젝트 파괴
			Destroy(gameObject);
		}
	}

	// 게임판 사이즈에 따른 크기 설정 - 매 프레임마다 실행
	private void ReplaceLaser() {
		// 크기 설정
		switch (dir) {
			case Direction.Right:
			case Direction.Left:
				gameObject.transform.localScale = new Vector3(1000, spriteMaxScale / ((LevelData.Instance.levelHeight * 2) + 1), 1);
				gameObject.transform.position = new Vector3(0, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0);
				break;

			case Direction.Down:
			case Direction.Up:
				gameObject.transform.localScale = new Vector3(spriteMaxScale / ((LevelData.Instance.levelWidth * 2) + 1), 1000, 1);
				gameObject.transform.position = new Vector3(spawnPos * (levelSize / ((LevelData.Instance.levelWidth * 2) + 1)), 0, 0);
				break;
		}
	}

	// 색 / 투명도 변화 - 매 프레임마다 실행
	private void ColorUpdate() {
		// 색 변화
		if (LevelCtrl.Instance.eChangeEnable)
			enemyColor = LevelData.Instance.enemyColor;

		sprRen.color = new Color(enemyColor.r, enemyColor.g, enemyColor.b, alpha);

		// 투명도 변화
		if (alpha > 0) {
			alpha -= (Time.deltaTime / time);
		}
		else {
			alpha = 0;
			Destroy(gameObject);
		}
	}
}
