using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

	// 플레이어의 위치를 좌표로 표현
	[System.NonSerialized]
	public Vector2 playerPos = new Vector2(0, 0);

	// 게임판의 고정 크기
	private const int levelSize = 512;
	// 스프라이트의 기본 크기
	private const float spriteMaxScale = 500f;

	// 무적 시간
	private float invincibleTime = 1f;
	// 시간 카운트용 임시 변수
	private float tempInvTime = 0f;

	// 무적 시간 깜빡임 간격
	private float invFlickInterval = 0.08f;
	// 시간 카운트용 임시 변수
	private float tempInvFlickTime = 0f;
	// 현재 (반)투명 여부 확인
	private bool isTransparent = false;

	// 스프라이트 렌더러
	private SpriteRenderer playerSprRen;

	// 오브젝트가 생성될 때 실행
	private void Awake() {
		// 스프라이트 렌더러를 가져옴
		playerSprRen = gameObject.GetComponent<SpriteRenderer>();
	}

	// 매 프레임마다 실행
	private void Update() {
		MoveData();
		ReplacePlayer();
		Invincible();
	}

	// 플레이어 움직임 설정
	private void MoveData() {
		if (Input.GetKeyDown(KeyCode.RightArrow) && playerPos.x < LevelData.Instance.levelWidth) {
			playerPos = new Vector2(playerPos.x + 1, playerPos.y);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow) && playerPos.x > -LevelData.Instance.levelWidth) {
			playerPos = new Vector2(playerPos.x - 1, playerPos.y);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow) && playerPos.y < LevelData.Instance.levelHeight) {
			playerPos = new Vector2(playerPos.x, playerPos.y + 1);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow) && playerPos.y > -LevelData.Instance.levelHeight) {
			playerPos = new Vector2(playerPos.x, playerPos.y - 1);
		}
	}

	// 플레이어 위치 설정
	private void ReplacePlayer() {
		gameObject.transform.localScale = new Vector3(spriteMaxScale / ((LevelData.Instance.levelWidth * 2) + 1), spriteMaxScale / ((LevelData.Instance.levelHeight * 2) + 1), 1);

		if (playerPos.x > LevelData.Instance.levelWidth)
			playerPos = new Vector2(LevelData.Instance.levelWidth, playerPos.y);
		if (playerPos.x < -LevelData.Instance.levelWidth)
			playerPos = new Vector2(-LevelData.Instance.levelWidth, playerPos.y);
		if (playerPos.y > LevelData.Instance.levelHeight)
			playerPos = new Vector2(playerPos.x, LevelData.Instance.levelHeight);
		if (playerPos.y < -LevelData.Instance.levelHeight)
			playerPos = new Vector2(playerPos.x, -LevelData.Instance.levelHeight);
		gameObject.transform.position = new Vector3(playerPos.x * (levelSize / ((LevelData.Instance.levelWidth * 2) + 1)), playerPos.y * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0);
	}

	// 플레이어 무적 상태일 때 깜빡임 조정
	private void Invincible() {
		if (!LevelData.Instance.invincibleMode) {
			if (LevelData.Instance.isInvincible) {
				if (tempInvTime >= invincibleTime) {
					tempInvTime = 0;
					LevelData.Instance.isInvincible = false;
				}
				else {
					tempInvTime += Time.deltaTime;
				}

				if (tempInvFlickTime >= invFlickInterval) {
					if (!isTransparent) {
						playerSprRen.color = new Color(0.9f, 0f, 0f, 0.5f);
					}
					else {
						playerSprRen.color = new Color(0.9f, 0f, 0f, 1f);
					}
					isTransparent = !isTransparent;
					tempInvFlickTime = 0;
				}
				else {
					tempInvFlickTime += Time.deltaTime;
				}
			}
			else {
				playerSprRen.color = new Color(1f, 0f, 0f, 1f);
				tempInvFlickTime = 0f;
				isTransparent = false;
			}
		}
		else {
			playerSprRen.color = new Color(1f, 0f, 0f, 1f);
			tempInvFlickTime = 0f;
			isTransparent = false;
		}

		// I 키를 누르면 무적 모드로 변환 - 삭제 예정
		if (Input.GetKeyDown(KeyCode.I)) {
			if (!LevelData.Instance.invincibleMode)
				LevelData.Instance.invincibleMode = true;
			else
				LevelData.Instance.invincibleMode = false;
		}
	}
}
