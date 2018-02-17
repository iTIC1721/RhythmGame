using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelCtrl : Singleton<LevelCtrl> {
	
	public GameObject enemyPrefab;
	public GameObject laserPrefab;
	public GameObject heartPrefab;
	public GameObject mainCamera;
	public GameObject player;

	[NonSerialized]
	public bool playing = true;

	private const int levelSize = 512;
	private const int cameraSize = 375;

	private SpriteRenderer playerSprRen;
	private PlayerCtrl playerCtrl;
	private Camera cameraComp;

	private bool bChangeEnable = false;
	private Color bOriginalColor = Color.black;
	private Color bChangeColor = Color.black;
	private float bChangeTime = 0f;
	private float bTempTime = 0f;

	private bool lChangeEnable = false;
	private Color lOriginalColor = Color.black;
	private Color lChangeColor = Color.white;
	private float lChangeTime = 0f;
	private float lTempTime = 0f;

	private bool eChangeEnable = false;
	private Color eOriginalColor = Color.black;
	private Color eChangeColor = Color.white;
	private float eChangeTime = 0f;
	private float eTempTime = 0f;

	private bool rotateEnable = false;
	private float rotateOriginalAngle = 0f;
	private float rotateAngle = 0f;
	private float rotateTime = 0f;
	private float tempRotTime = 0f;

	private bool enlargeEnable = false;
	private float enlargeOriginalSize = 0f;
	private float enlargeRate = 0f;
	private float enlargeTime = 0f;
	private float tempEnlTime = 0f;

	private bool moveEnable = false;
	private Vector3 originalVector = Vector3.zero;
	private Vector3 moveVector = Vector3.zero;
	private float moveTime = 0f;
	private float tempMoveTime = 0f;

	private AudioSource audioSource;

	private void Awake() {
		playerSprRen = player.GetComponent<SpriteRenderer>();
		playerCtrl = player.GetComponent<PlayerCtrl>();
		cameraComp = mainCamera.GetComponent<Camera>();
		audioSource = GameObject.Find("Manager").GetComponent<AudioSource>();
	}

	private void Update() {
		if (playing) {
			// ChangeBackColor 메소드
			if (bChangeEnable) {
				if (bTempTime < bChangeTime) {
					//LevelData.Instance.backColor += bColorChangeInterval;
					LevelData.Instance.backColor = Color.Lerp(
						bOriginalColor, 
						bChangeColor, 
						bTempTime / bChangeTime);
					bTempTime += Time.deltaTime;
				}
				else {
					LevelData.Instance.backColor = bChangeColor;
					bChangeEnable = false;
					bTempTime = 0;
				}
				//Debug.Log("changing");
			}

			// ChangeLevelColor 메소드
			if (lChangeEnable) {
				if (lTempTime < lChangeTime) {
					//LevelData.Instance.levelColor += lColorChangeInterval;
					LevelData.Instance.levelColor = Color.Lerp(
						lOriginalColor, 
						lChangeColor, 
						lTempTime / lChangeTime);
					lTempTime += Time.deltaTime;
				}
				else {
					LevelData.Instance.levelColor = lChangeColor;
					lChangeEnable = false;
					lTempTime = 0;
				}
				//Debug.Log("changing");
			}

			// ChangeEnemyColor 메소드
			if (eChangeEnable) {
				if (eTempTime < eChangeTime) {
					//LevelData.Instance.enemyColor += eColorChangeInterval;
					LevelData.Instance.enemyColor = Color.Lerp(
						eOriginalColor, 
						eChangeColor, 
						eTempTime / eChangeTime);
					eTempTime += Time.deltaTime;
				}
				else {
					LevelData.Instance.enemyColor = eChangeColor;
					eChangeEnable = false;
					eTempTime = 0;
				}
				//Debug.Log("changing");
			}

			// RotateLevel 메소드
			if (rotateEnable) {
				if (tempRotTime < rotateTime) {
					//mainCamera.transform.localRotation = new Quaternion(mainCamera.transform.localRotation.x, mainCamera.transform.localRotation.y, mainCamera.transform.localRotation.z + rotateAngleInterval, mainCamera.transform.localRotation.w);
					mainCamera.transform.localRotation = Quaternion.Lerp(
						new Quaternion(mainCamera.transform.localRotation.x, mainCamera.transform.localRotation.y, rotateOriginalAngle, mainCamera.transform.localRotation.w), 
						new Quaternion(mainCamera.transform.localRotation.x, mainCamera.transform.localRotation.y, rotateAngle, mainCamera.transform.localRotation.w), 
						tempRotTime / rotateTime);
					tempRotTime += Time.deltaTime;
				}
				else {
					mainCamera.transform.localRotation = new Quaternion(mainCamera.transform.localRotation.x, mainCamera.transform.localRotation.y, rotateAngle, mainCamera.transform.localRotation.w);
					rotateEnable = false;
					tempRotTime = 0;
				}
			}

			// EnlargeLevel 메소드
			if (enlargeEnable) {
				if (tempEnlTime < enlargeTime) {
					//cameraComp.orthographicSize += enlargeRateInterval;
					cameraComp.orthographicSize = Mathf.Lerp(
						enlargeOriginalSize, 
						enlargeRate * cameraSize, 
						tempEnlTime / enlargeTime);
					tempEnlTime += Time.deltaTime;
				}
				else {
					cameraComp.orthographicSize = enlargeRate * cameraSize;
					enlargeEnable = false;
					tempEnlTime = 0f;
				}
			}

			// MoveLevel 메소드
			if (moveEnable) {
				if (tempMoveTime < moveTime) {
					//mainCamera.transform.position += new Vector3(moveXInterval, moveYInterval, 0);
					mainCamera.transform.position = Vector3.Lerp(
						originalVector, 
						moveVector, 
						tempMoveTime / moveTime);
					tempMoveTime += Time.deltaTime;
				}
				else {
					mainCamera.transform.position = moveVector;
					moveEnable = false;
					tempMoveTime = 0f;
				}
			}
		}
	}

	public void StartGame(string levelName, string levelDesigner, int width, int height) {
		LevelData.Instance.levelName = levelName;
		LevelData.Instance.levelDesigner = levelDesigner;
		LevelData.Instance.levelWidth = width;
		LevelData.Instance.levelHeight = height;
		playerCtrl.playerPos = Vector2.zero;
		playing = true;
	}

	/// <summary>
	/// Enemy 오브젝트를 지정한 위치에 생성한다.
	/// spawnPos를 100 ± n으로 설정하면 플레이어의 위치 ± n에서 생성한다.
	/// </summary>
	/// <param name="spawnDir">생성될 방향</param>
	/// <param name="spawnPos">생성될 위치</param>
	/// <param name="speed">Enemy 오브젝트의 속도</param>
	/// <param name="velo">Enemy 오브젝트의 가속도</param>
	public void SpawnEnemy(int spawnDir, int spawnPos, float speed, float velo, bool isHeart = false) {
		if (playing) {
			EnemyCtrl enemyCtrl;
			HeartCtrl heartCtrl;

			if (spawnDir > 3 || spawnDir < 0) {
				Debug.LogWarning("Invalid Direction");
			}
			else {
				switch (spawnDir) {
					case 0:
						if (spawnPos >= 100 - LevelData.Instance.levelHeight && spawnPos <= 100 + LevelData.Instance.levelHeight)
							spawnPos = (int)playerCtrl.playerPos.y + (spawnPos - 100);

						if (spawnPos > LevelData.Instance.levelWidth || spawnPos < -LevelData.Instance.levelWidth) {
							Debug.LogWarning("Invalid Position");
						}
						else {
							if (!isHeart) {
								GameObject enemy = Instantiate(enemyPrefab, new Vector3(256, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0), Quaternion.identity);
								enemyCtrl = enemy.GetComponent<EnemyCtrl>();
								enemyCtrl.dir = 0;
								enemyCtrl.spawnPos = spawnPos;
								enemyCtrl.speed = speed;
								enemyCtrl.velo = velo;
							}
							else {
								GameObject heart = Instantiate(heartPrefab, new Vector3(256, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0), Quaternion.identity);
								heartCtrl = heart.GetComponent<HeartCtrl>();
								heartCtrl.dir = 0;
								heartCtrl.spawnPos = spawnPos;
								heartCtrl.speed = speed;
								heartCtrl.velo = velo;
							}

							//Debug.Log(spawnDir.ToString() + " " + spawnPos.ToString() + " " + speed.ToString() + " " + velo.ToString() + " complete");
						}
						break;
					case 1:
						if (spawnPos >= 100 - LevelData.Instance.levelWidth && spawnPos <= 100 + LevelData.Instance.levelWidth)
							spawnPos = (int)playerCtrl.playerPos.x + (spawnPos - 100);

						if (spawnPos > LevelData.Instance.levelHeight || spawnPos < -LevelData.Instance.levelHeight) {
							Debug.LogWarning("Invalid Position");
						}
						else {
							if (!isHeart) {
								GameObject enemy = Instantiate(enemyPrefab, new Vector3(spawnPos * (levelSize / ((LevelData.Instance.levelWidth * 2) + 1)), -256, 0), Quaternion.identity);
								enemyCtrl = enemy.GetComponent<EnemyCtrl>();
								enemyCtrl.dir = 1;
								enemyCtrl.spawnPos = spawnPos;
								enemyCtrl.speed = speed;
								enemyCtrl.velo = velo;
							}
							else {
								GameObject heart = Instantiate(heartPrefab, new Vector3(spawnPos * (levelSize / ((LevelData.Instance.levelWidth * 2) + 1)), -256, 0), Quaternion.identity);
								heartCtrl = heart.GetComponent<HeartCtrl>();
								heartCtrl.dir = 1;
								heartCtrl.spawnPos = spawnPos;
								heartCtrl.speed = speed;
								heartCtrl.velo = velo;
							}

							//Debug.Log(spawnDir.ToString() + " " + spawnPos.ToString() + " " + speed.ToString() + " " + velo.ToString() + " complete");
						}
						break;
					case 2:
						if (spawnPos >= 100 - LevelData.Instance.levelHeight && spawnPos <= 100 + LevelData.Instance.levelHeight)
							spawnPos = (int)playerCtrl.playerPos.y + (spawnPos - 100);

						if (spawnPos > LevelData.Instance.levelWidth || spawnPos < -LevelData.Instance.levelWidth) {
							Debug.LogWarning("Invalid Position");
						}
						else {
							if (!isHeart) {
								GameObject enemy = Instantiate(enemyPrefab, new Vector3(-256, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0), Quaternion.identity);
								enemyCtrl = enemy.GetComponent<EnemyCtrl>();
								enemyCtrl.dir = 2;
								enemyCtrl.spawnPos = spawnPos;
								enemyCtrl.speed = speed;
								enemyCtrl.velo = velo;
							}
							else {
								GameObject heart = Instantiate(heartPrefab, new Vector3(-256, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0), Quaternion.identity);
								heartCtrl = heart.GetComponent<HeartCtrl>();
								heartCtrl.dir = 2;
								heartCtrl.spawnPos = spawnPos;
								heartCtrl.speed = speed;
								heartCtrl.velo = velo;
							}

							//Debug.Log(spawnDir.ToString() + " " + spawnPos.ToString() + " " + speed.ToString() + " " + velo.ToString() + " complete");
						}
						break;
					case 3:
						if (spawnPos >= 100 - LevelData.Instance.levelWidth && spawnPos <= 100 + LevelData.Instance.levelWidth)
							spawnPos = (int)playerCtrl.playerPos.x + (spawnPos - 100);

						if (spawnPos > LevelData.Instance.levelHeight || spawnPos < -LevelData.Instance.levelHeight) {
							Debug.LogWarning("Invalid Position");
						}
						else {
							if (!isHeart) {
								GameObject enemy = Instantiate(enemyPrefab, new Vector3(spawnPos * (levelSize / ((LevelData.Instance.levelWidth * 2) + 1)), 256, 0), Quaternion.identity);
								enemyCtrl = enemy.GetComponent<EnemyCtrl>();
								enemyCtrl.dir = 3;
								enemyCtrl.spawnPos = spawnPos;
								enemyCtrl.speed = speed;
								enemyCtrl.velo = velo;
							}
							else {
								GameObject heart = Instantiate(heartPrefab, new Vector3(spawnPos * (levelSize / ((LevelData.Instance.levelWidth * 2) + 1)), 256, 0), Quaternion.identity);
								heartCtrl = heart.GetComponent<HeartCtrl>();
								heartCtrl.dir = 3;
								heartCtrl.spawnPos = spawnPos;
								heartCtrl.speed = speed;
								heartCtrl.velo = velo;
							}

							//Debug.Log(spawnDir.ToString() + " " + spawnPos.ToString() + " " + speed.ToString() + " " + velo.ToString() + " complete");
						}
						break;
				}
			}
		}
	}

	/// <summary>
	/// Laser 오브젝트를 지정한 위치에 생성한다.
	/// spawnPos를 100 ± n으로 설정하면 플레이어의 위치 ± n에서 생성한다.
	/// </summary>
	/// <param name="spawnDir">생성될 방향</param>
	/// <param name="spawnPos">생성될 위치</param>
	/// <param name="time">유지 시간</param>
	public void SpawnLaser(int spawnDir, int spawnPos, float time) {
		if (playing) {
			if (spawnDir > 3 || spawnDir < 0) {
				Debug.LogWarning("Invalid Direction");
			}
			else {
				switch (spawnDir) {
					case 0:
						if (spawnPos >= 100 - LevelData.Instance.levelHeight && spawnPos <= 100 + LevelData.Instance.levelHeight)
							spawnPos = (int)playerCtrl.playerPos.y + (spawnPos - 100);

						if (spawnPos > LevelData.Instance.levelWidth || spawnPos < -LevelData.Instance.levelWidth) {
							Debug.LogWarning("Invalid Position");
						}
						else {
							GameObject enemy = Instantiate(laserPrefab, new Vector3(0, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0), Quaternion.identity);
							LaserCtrl laserCtrl = enemy.GetComponent<LaserCtrl>();
							laserCtrl.dir = 0;
							laserCtrl.spawnPos = spawnPos;
							laserCtrl.time = time;

							//Debug.Log(spawnDir.ToString() + " " + spawnPos.ToString() + " " + speed.ToString() + " " + velo.ToString() + " complete");
						}
						break;
					case 1:
						if (spawnPos >= 100 - LevelData.Instance.levelWidth && spawnPos <= 100 + LevelData.Instance.levelWidth)
							spawnPos = (int)playerCtrl.playerPos.x + (spawnPos - 100);

						if (spawnPos > LevelData.Instance.levelHeight || spawnPos < -LevelData.Instance.levelHeight) {
							Debug.LogWarning("Invalid Position");
						}
						else {
							GameObject enemy = Instantiate(laserPrefab, new Vector3(spawnPos * (levelSize / ((LevelData.Instance.levelWidth * 2) + 1)), 0, 0), Quaternion.identity);
							LaserCtrl laserCtrl = enemy.GetComponent<LaserCtrl>();
							laserCtrl.dir = 1;
							laserCtrl.spawnPos = spawnPos;
							laserCtrl.time = time;

							//Debug.Log(spawnDir.ToString() + " " + spawnPos.ToString() + " " + speed.ToString() + " " + velo.ToString() + " complete");
						}
						break;
					case 2:
						if (spawnPos >= 100 - LevelData.Instance.levelHeight && spawnPos <= 100 + LevelData.Instance.levelHeight)
							spawnPos = (int)playerCtrl.playerPos.y + (spawnPos - 100);

						if (spawnPos > LevelData.Instance.levelWidth || spawnPos < -LevelData.Instance.levelWidth) {
							Debug.LogWarning("Invalid Position");
						}
						else {
							GameObject enemy = Instantiate(laserPrefab, new Vector3(0, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0), Quaternion.identity);
							LaserCtrl laserCtrl = enemy.GetComponent<LaserCtrl>();
							laserCtrl.dir = 2;
							laserCtrl.spawnPos = spawnPos;
							laserCtrl.time = time;

							//Debug.Log(spawnDir.ToString() + " " + spawnPos.ToString() + " " + speed.ToString() + " " + velo.ToString() + " complete");
						}
						break;
					case 3:
						if (spawnPos >= 100 - LevelData.Instance.levelWidth && spawnPos <= 100 + LevelData.Instance.levelWidth)
							spawnPos = (int)playerCtrl.playerPos.x + (spawnPos - 100);

						if (spawnPos > LevelData.Instance.levelHeight || spawnPos < -LevelData.Instance.levelHeight) {
							Debug.LogWarning("Invalid Position");
						}
						else {
							GameObject enemy = Instantiate(laserPrefab, new Vector3(spawnPos * (levelSize / ((LevelData.Instance.levelWidth * 2) + 1)), 0, 0), Quaternion.identity);
							LaserCtrl laserCtrl = enemy.GetComponent<LaserCtrl>();
							laserCtrl.dir = 3;
							laserCtrl.spawnPos = spawnPos;
							laserCtrl.time = time;

							//Debug.Log(spawnDir.ToString() + " " + spawnPos.ToString() + " " + speed.ToString() + " " + velo.ToString() + " complete");
						}
						break;
				}
			}
		}
	}

	/// <summary>
	/// 레벨의 칸 수를 조정한다.
	/// </summary>
	/// <param name="width">중심으로부터의 가로 칸 수</param>
	/// <param name="height">중심으로부터의 세로 칸 수</param>
	public void ResizeLevel(int width, int height) {
		if (playing) {
			LevelData.Instance.levelWidth = width;
			LevelData.Instance.levelHeight = height;

			GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
			foreach (GameObject enemyObj in enemies) {
				EnemyCtrl enemyCtrl = enemyObj.GetComponent<EnemyCtrl>();
				// TODO: 좌표 줄이기 수정
				switch (enemyCtrl.dir) {
					case 0:
						enemyObj.transform.position = new Vector3(enemyObj.transform.position.x, enemyCtrl.spawnPos * (levelSize / ((height * 2) + 1)), 0);
						break;
					case 1:
						enemyObj.transform.position = new Vector3(enemyCtrl.spawnPos * (levelSize / ((width * 2) + 1)), enemyObj.transform.position.y, 0);
						break;
					case 2:
						enemyObj.transform.position = new Vector3(enemyObj.transform.position.x, enemyCtrl.spawnPos * (levelSize / ((height * 2) + 1)), 0);
						break;
					case 3:
						enemyObj.transform.position = new Vector3(enemyCtrl.spawnPos * (levelSize / ((width * 2) + 1)), enemyObj.transform.position.y, 0);
						break;
				}
			}
		}
	}

	/// <summary>
	/// 배경색을 지정된 시간동안 서서히 바꾼다.
	/// </summary>
	/// <param name="color">바꿀 색상</param>
	/// <param name="time">바꿀 시간</param>
	public void ChangeBackColor(Color color, float time) {
		if (playing) {
			bChangeEnable = true;
			bChangeColor = color;
			bOriginalColor = LevelData.Instance.backColor;
			bChangeTime = time;
			bTempTime = 0;
		}
	}

	/// <summary>
	/// 벽의 색을 지정된 시간동안 서서히 바꾼다.
	/// </summary>
	/// <param name="color">바꿀 색상</param>
	/// <param name="time">바꿀 시간</param>
	public void ChangeLevelColor(Color color, float time) {
		if (playing) {
			lChangeEnable = true;
			lChangeColor = color;
			lOriginalColor = LevelData.Instance.levelColor;
			lChangeTime = time;
			lTempTime = 0;
		}
	}

	/// <summary>
	/// Enemy의 색을 지정된 시간동안 서서히 바꾼다.
	/// </summary>
	/// <param name="color">바꿀 색상</param>
	/// <param name="time">바꿀 시간</param>
	public void ChangeEnemyColor(Color color, float time) {
		if (playing) {
			eChangeEnable = true;
			eChangeColor = color;
			eOriginalColor = LevelData.Instance.enemyColor;
			eChangeTime = time;
			eTempTime = 0;
		}
	}

	/// <summary>
	/// 게임 플레이 화면을 일정 각도 회전시킨다.
	/// </summary>
	/// <param name="angle">회전시킬 각도</param>
	/// <param name="time">회전시킬 시간</param>
	public void RotateLevel(float angle, float time) {
		if (playing) {
			rotateEnable = true;
			rotateAngle = angle;
			rotateOriginalAngle = mainCamera.transform.rotation.z;
			rotateTime = time;
			tempRotTime = 0;
		}
	}

	/// <summary>
	/// 게임 플레이 화면을 일정 비율 확대시킨다.
	/// 숫자가 작을수록 화면이 커진다.
	/// </summary>
	/// <param name="rate">확대시킬 비율</param>
	/// <param name="time">확대시킬 시간</param>
	public void EnlargeLevel(float rate, float time) {
		if (playing) {
			enlargeEnable = true;
			enlargeRate = rate;
			enlargeOriginalSize = cameraComp.orthographicSize;
			enlargeTime = time;
			tempEnlTime = 0;
		}
	}

	/// <summary>
	/// 게임 플레이 화면을 이동시킨다.
	/// </summary>
	/// <param name="x">이동시킬 x좌표</param>
	/// <param name="y">이동시킬 y좌표</param>
	/// <param name="time">이동시킬 시간</param>
	public void MoveLevel(float x, float y, float time) {
		if (playing) {
			moveEnable = true;
			moveVector = new Vector3(-x, -y, -10);
			originalVector = mainCamera.transform.position;
			moveTime = time;
			tempMoveTime = 0;
		}
	}

	/// <summary>
	/// 플레이어를 투명화시킨다.
	/// </summary>
	public void PlayerVisible(bool visible) {
		if (playing) {
			playerSprRen.enabled = visible;
		}
	}

	/// <summary>
	/// 플레이어를 지정한 위치로 강제 이동시킨다.
	/// </summary>
	/// <param name="pos">이동시킬 위치</param>
	public void ReplacePlayer(Vector2 pos) {
		if (playing) {
			playerCtrl.playerPos = pos;
		}
	}

	/// <summary>
	/// 플레이어를 지정한 위치로 강제 이동시킨다.
	/// </summary>
	/// <param name="pos">이동시킬 위치</param>
	public void ReplacePlayer(int x, int y) {
		if (playing) {
			playerCtrl.playerPos = new Vector2(x, y);
		}
	}

	/// <summary>
	/// 현재 존재하는 모든 엔티티를 제거한다.
	/// </summary>
	public void KillAll() {
		if (playing) {
			foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy")) {
				Destroy(enemy);
			}
			foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Laser")) {
				Destroy(enemy);
			}
			foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Heart")) {
				Destroy(enemy);
			}
		}
	}

	/// <summary>
	/// 현재 존재하는 특정 엔티티를 전부 제거한다.
	/// </summary>
	/// <param name="tag">제거할 엔티티 태그</param>
	public void KillEntity(string tag) {
		if (playing) {
			foreach (GameObject enemy in GameObject.FindGameObjectsWithTag(tag)) {
				Destroy(enemy);
			}
		}
	}

	/// <summary>
	/// 플레이어의 하트가 전부 소진되었을 때 발동시킨다.
	/// </summary>
	public void GameOver() {
		if (playing) {
			audioSource.Stop();
			playing = false;
			KillAll();
			LevelData.Instance.gameOver = true;
			LevelData.Instance.backColor = Color.black;
			LevelData.Instance.levelColor = Color.black;
			LevelData.Instance.enemyColor = Color.black;
			LevelData.Instance.heartColor = Color.black;
			StartCoroutine(GameOverCoroutine());
		}
	}

	private IEnumerator GameOverCoroutine() {
		yield return new WaitForSeconds(3f);

		// 게임 초기화
		LevelData.Instance.gameOver = false;
		LevelData.Instance.backColor = Color.black;
		LevelData.Instance.levelColor = Color.white;
		LevelData.Instance.enemyColor = Color.white;
		LevelData.Instance.heartColor = Color.red;
		SceneManager.LoadScene("LevelSelect");
	}
}
