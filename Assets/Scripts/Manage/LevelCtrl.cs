using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelCtrl : Singleton<LevelCtrl> {
	
	// 블럭 장애물 프리팹
	public GameObject enemyPrefab;
	// 레이저 장애물 프리팹
	public GameObject laserPrefab;
	// 하트 프리팹
	public GameObject heartPrefab;
	// 메인 카메라 오브젝트
	public GameObject mainCamera;
	// 플레이어 오브젝트
	public GameObject player;

	// 플레이어 생존 여부 확인용 변수
	[NonSerialized]
	public bool playing = true;

	// 게임판의 고정 크기
	private const int levelSize = 512;
	// 카메라의 기본 사이즈
	private const int cameraSize = 375;

	// 플레이어 오브젝트의 스프라이트 렌더러를 받아오기 위한 변수
	private SpriteRenderer playerSprRen;
	// 플레이어 오브젝트의 PlayerCtrl 스크립트를 받아오기 위한 변수
	private PlayerCtrl playerCtrl;
	// 메인 카메라 오브젝트의 Camera 컴포넌트를 받아오기 위한 변수
	private Camera cameraComp;

	// 배경 색 변화 여부
	private bool bChangeEnable = false;
	// 변화 전 배경색
	private Color bOriginalColor = Color.black;
	// 변화 후 배경색
	private Color bChangeColor = Color.black;
	// 변화 시간
	private float bChangeTime = 0f;
	// 시간 카운트용 임시 변수
	private float bTempTime = 0f;

	// 게임판 색 변화 여부
	private bool lChangeEnable = false;
	// 변화 전 게임판 색
	private Color lOriginalColor = Color.black;
	// 변화 후 게임판 색
	private Color lChangeColor = Color.white;
	// 변화 시간
	private float lChangeTime = 0f;
	// 시간 카운트용 임시 변수
	private float lTempTime = 0f;

	// 장애물 색 변화 여부
	private bool eChangeEnable = false;
	// 변화 전 장애물 색
	private Color eOriginalColor = Color.black;
	// 변화 후 장애물 색
	private Color eChangeColor = Color.white;
	// 변화 시간
	private float eChangeTime = 0f;
	// 시간 카운트용 임시 변수
	private float eTempTime = 0f;

	// 카메라 회전 여부
	private bool rotateEnable = false;
	// 회전 전 카메라 각도
	private float rotateOriginalAngle = 0f;
	// 회전 후 카메라 각도
	private float rotateAngle = 0f;
	// 회전 시간
	private float rotateTime = 0f;
	// 시간 카운트용 임시 변수
	private float tempRotTime = 0f;

	// 게임판 확대 여부
	private bool enlargeEnable = false;
	// 확대 전 게임판 크기
	private float enlargeOriginalSize = 0f;
	// 확대 후 게임판 크기
	private float enlargeRate = 0f;
	// 확대 시간
	private float enlargeTime = 0f;
	// 시간 카운트용 임시 변수
	private float tempEnlTime = 0f;

	// 게임판 이동 여부
	private bool moveEnable = false;
	// 이동 전 게임판 위치
	private Vector3 originalVector = Vector3.zero;
	// 이동 후 게임판 위치
	private Vector3 moveVector = Vector3.zero;
	// 이동 시간
	private float moveTime = 0f;
	// 시간 카운트용 임시 변수
	private float tempMoveTime = 0f;

	// 오디오 플레이어 컴포넌트를 받아오기 위한 변수
	private AudioSource audioSource;

	// 오브젝트가 생성되었을 때 실행
	private void Awake() {
		// 플레이어 오브젝트의 스프라이트 렌더러를 가져옴
		playerSprRen = player.GetComponent<SpriteRenderer>();
		// 플레이어 오브젝트의 PlayerCtrl 스크립트를 가져옴
		playerCtrl = player.GetComponent<PlayerCtrl>();
		// 메인 카메라의 Camera 컴포넌트를 가져옴
		cameraComp = mainCamera.GetComponent<Camera>();
		// 오디오 플레이어 컴포넌트를 가져옴
		audioSource = GameObject.Find("Manager").GetComponent<AudioSource>();
	}

	// 매 프레임마다 실행
	private void Update() {
		// 플레이어가 생존 중일때만 실행
		if (playing) {
			// ChangeBackColor 메소드
			// 배경색 변화가 활성화될 경우
			if (bChangeEnable) {
				// 변화 시간이 다 지나지 않았을 경우
				if (bTempTime < bChangeTime) {
					// 배경색을 본래 색에서 바꿀 색으로 지정된 시간동안 변화시킴
					LevelData.Instance.backColor = Color.Lerp(
						bOriginalColor, 
						bChangeColor, 
						bTempTime / bChangeTime);
					// 시간 카운트
					bTempTime += Time.deltaTime;
				}
				// 변화 시간이 다 지났을 경우
				else {
					// 배경색을 지정된 색으로 변경
					LevelData.Instance.backColor = bChangeColor;
					// 변화 활성화를 해제
					bChangeEnable = false;
					// 임시 변수 초기화
					bTempTime = 0;
				}
				//Debug.Log("changing");
			}

			// ChangeLevelColor 메소드
			// 게임판 색 변화가 활성화될 경우
			if (lChangeEnable) {
				// 변화 시간이 다 지나지 않았을 경우
				if (lTempTime < lChangeTime) {
					// 게임판 색을 본래 색에서 바꿀 색으로 지정된 시간동안 변화시킴
					LevelData.Instance.levelColor = Color.Lerp(
						lOriginalColor, 
						lChangeColor, 
						lTempTime / lChangeTime);
					// 시간 카운트
					lTempTime += Time.deltaTime;
				}
				// 변화 시간이 다 지났을 경우
				else {
					// 게임판 색을 지정된 색으로 변경
					LevelData.Instance.levelColor = lChangeColor;
					// 변화 활성화를 해제
					lChangeEnable = false;
					// 임시 변수 초기화
					lTempTime = 0;
				}
				//Debug.Log("changing");
			}

			// ChangeEnemyColor 메소드
			// 장애물 색 변화가 활성화될 경우
			if (eChangeEnable) {
				// 변화 시간이 다 지나지 않았을 경우
				if (eTempTime < eChangeTime) {
					// 장애물 색을 본래 색에서 바꿀 색으로 지정된 시간동안 변화시킴
					LevelData.Instance.enemyColor = Color.Lerp(
						eOriginalColor, 
						eChangeColor, 
						eTempTime / eChangeTime);
					// 시간 카운트
					eTempTime += Time.deltaTime;
				}
				// 변화 시간이 다 지났을 경우
				else {
					// 장애물 색을 지정된 색으로 변경
					LevelData.Instance.enemyColor = eChangeColor;
					// 변화 활성화를 해제
					eChangeEnable = false;
					// 임시 변수 초기화
					eTempTime = 0;
				}
				//Debug.Log("changing");
			}

			// RotateLevel 메소드
			// 카메라 회전이 활성화될 경우
			if (rotateEnable) {
				// 회전 시간이 다 지나지 않았을 경우
				if (tempRotTime < rotateTime) {
					// 카메라의 각도를 본래 각도에서 바꿀 각도로 지정된 시간동안 변화시킴
					mainCamera.transform.localRotation = Quaternion.Lerp(
						new Quaternion(mainCamera.transform.localRotation.x, mainCamera.transform.localRotation.y, rotateOriginalAngle, mainCamera.transform.localRotation.w), 
						new Quaternion(mainCamera.transform.localRotation.x, mainCamera.transform.localRotation.y, rotateAngle, mainCamera.transform.localRotation.w), 
						tempRotTime / rotateTime);
					// 시간 카운트
					tempRotTime += Time.deltaTime;
				}
				// 회전 시간이 다 지났을 경우
				else {
					// 카메라 각도를 지정된 각도로 변경
					mainCamera.transform.localRotation = new Quaternion(mainCamera.transform.localRotation.x, mainCamera.transform.localRotation.y, rotateAngle, mainCamera.transform.localRotation.w);
					// 변화 활성화를 해제
					rotateEnable = false;
					// 임시 변수 초기화
					tempRotTime = 0;
				}
			}

			// EnlargeLevel 메소드
			// 게임판 확대가 활성화된 경우
			if (enlargeEnable) {
				// 확대 시간이 다 지나지 않았을 경우
				if (tempEnlTime < enlargeTime) {
					// 카메라의 시야 크기를 본래 크기에서 바꿀 크기로 지정된 사간동안 변화시킴
					cameraComp.orthographicSize = Mathf.Lerp(
						enlargeOriginalSize, 
						enlargeRate * cameraSize, 
						tempEnlTime / enlargeTime);
					// 시간 카운트
					tempEnlTime += Time.deltaTime;
				}
				// 확대 시간이 다 지났을 경우
				else {
					// 카메라 시야 크기를 지정된 크기로 변경
					cameraComp.orthographicSize = enlargeRate * cameraSize;
					// 변화 활성화를 해제
					enlargeEnable = false;
					// 임시 변수 초기화
					tempEnlTime = 0f;
				}
			}

			// MoveLevel 메소드
			// 게임판 이동이 활성화된 경우
			if (moveEnable) {
				// 이동 시간이 다 지나지 않았을 경우 
				if (tempMoveTime < moveTime) {
					// 카메라의 위치를 본래 위치에서 바꿀 위치로 지정된 사간동안 변화시킴
					mainCamera.transform.position = Vector3.Lerp(
						originalVector, 
						moveVector, 
						tempMoveTime / moveTime);
					// 시간 카운트
					tempMoveTime += Time.deltaTime;
				}
				// 이동 시간이 다 지났을 경우
				else {
					// 카메라 위치를 지정된 위치로 변경
					mainCamera.transform.position = moveVector;
					// 변화 활성화를 해제
					moveEnable = false;
					// 임시 변수 초기화
					tempMoveTime = 0f;
				}
			}
		}
	}

	/// <summary>
	/// 게임을 시작한다.
	/// </summary>
	/// <param name="levelName">레벨의 이름</param>
	/// <param name="levelDesigner">레벨의 디자이너</param>
	/// <param name="width">초기 게임판 너비</param>
	/// <param name="height">초기 게임판 높이</param>
	public void StartGame(string levelName, string levelDesigner, int width, int height) {
		// 게임 이름을 지정된 값으로 설정한다.
		LevelData.Instance.levelName = levelName;
		// 게임 디자이너를 지정된 값으로 설정한다.
		LevelData.Instance.levelDesigner = levelDesigner;
		// 초기 너비를 지정된 값으로 설정한다.
		LevelData.Instance.levelWidth = width;
		// 초기 높이를 지정된 값으로 설정한다.
		LevelData.Instance.levelHeight = height;
		// 플레이어를 가운데에 위치시킴
		playerCtrl.playerPos = Vector2.zero;
		// 플레이어 생존 시작
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
		// 생존 중일때만 작동한다.
		if (playing) {
			// 장애물의 EnemyCtrl 스크립트를 받아오기 위해 사용되는 변수
			EnemyCtrl enemyCtrl;
			// 하트의 HeartCtrl 스크립트를 받아오기 위해 사용되는 변수
			HeartCtrl heartCtrl;

			// 방향이 바른 값이 아닌 경우
			if (spawnDir > 3 || spawnDir < 0) {
				Debug.LogWarning("Invalid Direction");
			}
			// 올바른 방향일 경우
			else {
				switch (spawnDir) {
					// 오른쪽
					case 0:
						// 플레이어와의 상대적 위치에서 소환될 경우
						if (spawnPos >= 100 - LevelData.Instance.levelHeight && spawnPos <= 100 + LevelData.Instance.levelHeight)
							// 플레이어의 위치에 맞춰 스폰 위치 설정
							spawnPos = (int)playerCtrl.playerPos.y + (spawnPos - 100);

						// 스폰 위치가 올바르지 않을 때
						if (spawnPos > LevelData.Instance.levelWidth || spawnPos < -LevelData.Instance.levelWidth) {
							Debug.LogWarning("Invalid Position");
						}
						// 스폰 위치가 올바른 값일 때
						else {
							// 장애물인 경우
							if (!isHeart) {
								// 장애물을 지정된 위치에 스폰
								GameObject enemy = Instantiate(enemyPrefab, new Vector3(256, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0), Quaternion.identity);
								// 스폰된 장애물의 EnemyCtrl 스크립트를 가져옴
								enemyCtrl = enemy.GetComponent<EnemyCtrl>();
								// 방향 설정
								enemyCtrl.dir = 0;
								// 스폰 위치 설정
								enemyCtrl.spawnPos = spawnPos;
								// 속도 설정
								enemyCtrl.speed = speed;
								// 가속도 설정
								enemyCtrl.velo = velo;
							}
							// 하트인 경우
							else {
								// 하트를 지정된 위치에 스폰
								GameObject heart = Instantiate(heartPrefab, new Vector3(256, spawnPos * (levelSize / ((LevelData.Instance.levelHeight * 2) + 1)), 0), Quaternion.identity);
								// 스폰된 하트의 HeartCtrl 스크립트를 가져옴
								heartCtrl = heart.GetComponent<HeartCtrl>();
								// 방향 설정
								heartCtrl.dir = 0;
								// 스폰 위치 설정
								heartCtrl.spawnPos = spawnPos;
								// 속도 설정
								heartCtrl.speed = speed;
								// 가속도 설정
								heartCtrl.velo = velo;
							}

							//Debug.Log(spawnDir.ToString() + " " + spawnPos.ToString() + " " + speed.ToString() + " " + velo.ToString() + " complete");
						}
						break;
					// 아래쪽
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
					// 왼쪽
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
					// 위쪽
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
