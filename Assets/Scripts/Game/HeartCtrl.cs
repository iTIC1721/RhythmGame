﻿using UnityEngine;

public class HeartCtrl : MonoBehaviour {

	private const int levelSize = 512;
	private const float spriteMaxScale = 500f;

	// 방향 -> 0 : 오른쪽, 1 : 아래쪽, 2 : 왼쪽, 3 : 위쪽
	public Direction dir = 0;
	// 시작 점
	public int spawnPos = 0;
	// 속도
	public float speed = 10f;
	// 가속도
	public float velo = 0f;

	private SpriteRenderer sprRen;
	private Transform heartTransform;
	private SpriteRenderer heartSprRen;

	private void Awake() {
		sprRen = gameObject.GetComponent<SpriteRenderer>();
		heartTransform = gameObject.GetComponentInChildren<Transform>();
		// TODO: 하트 스프라이트 만들기 및 프리팹에 추가
		heartSprRen = gameObject.GetComponentInChildren<SpriteRenderer>();
		// 색 초기화
		sprRen.color = LevelData.Instance.enemyColor;
	}

	// 매 프레임마다 실행
	private void Update() {
		if (!LevelCtrl.Instance.isPaused) {
			ReplaceEnemy();
			ColorUpdate();
		}
	}

	private void OnBecameInvisible() {
		Destroy(gameObject);
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			if (LevelData.Instance.playerHeart < LevelData.Instance.playerHeartMax) {
				LevelData.Instance.playerHeart += 1;
				HeartText.Instance.TextUpdate();
			}
			Destroy(gameObject);
		}
	}

	private void ReplaceEnemy() {
		gameObject.transform.localScale = new Vector3(spriteMaxScale / ((LevelData.Instance.levelWidth * 2) + 1), spriteMaxScale / ((LevelData.Instance.levelHeight * 2) + 1), 1);
		switch (dir) {
			case Direction.Right:
				gameObject.transform.position += new Vector3(-speed, 0, 0);
				break;
			case Direction.Down:
				gameObject.transform.position += new Vector3(0, speed, 0);
				break;
			case Direction.Left:
				gameObject.transform.position += new Vector3(speed, 0, 0);
				break;
			case Direction.Up:
				gameObject.transform.position += new Vector3(0, -speed, 0);
				break;
		}
		speed += velo;
	}

	private void ColorUpdate() {
		if (LevelCtrl.Instance.eChangeEnable)
			sprRen.color = LevelData.Instance.enemyColor;
		heartSprRen.color = LevelData.Instance.heartColor;
	}
}
