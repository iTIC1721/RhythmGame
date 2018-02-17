using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

	[System.NonSerialized]
	public Vector2 playerPos = new Vector2(0, 0);

	private const int levelSize = 512;
	private const float spriteMaxScale = 500f;

	private float invincibleTime = 1f;
	private float tempInvTime = 0f;

	private float invFlickInterval = 0.08f;
	private float tempInvFlickTime = 0f;
	private bool isTransparent = false;

	private SpriteRenderer playerSprRen;

	private void Awake() {
		playerSprRen = gameObject.GetComponent<SpriteRenderer>();
	}

	private void Update() {
		MoveData();
		ReplacePlayer();
		Invincible();
	}

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

		if (Input.GetKeyDown(KeyCode.I)) {
			if (!LevelData.Instance.invincibleMode)
				LevelData.Instance.invincibleMode = true;
			else
				LevelData.Instance.invincibleMode = false;
		}
	}
}
