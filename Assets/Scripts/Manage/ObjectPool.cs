using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : Singleton<ObjectPool> {

	// 장애물 오브젝트 프리팹
	#region Prefabs
	public GameObject enemyPrefab;
	public GameObject laserPrefab;
	public GameObject heartPrefab;
	#endregion

	// 풀링된 오브젝트를 저장하는 리스트
	#region PooledObjLists
	public List<GameObject> pooledEnemyObj = new List<GameObject>();
	public List<GameObject> pooledLaserObj = new List<GameObject>();
	public List<GameObject> pooledHeartObj = new List<GameObject>();
	#endregion

	/// <summary>
	/// 장애물의 종류를 지정하는 열거형
	/// </summary>
	public enum EnemyType {
		Enemy,
		Laser,
		Heart
	}

	/// <summary>
	/// 오브젝트 풀을 초기화한다.
	/// </summary>
	/// <param name="count">각 오브젝트를 생성할 수</param>
	/// <param name="parent">풀링될 오브젝트의 부모 오브젝트</param>
	public void InitializePool(int count, Transform parent = null) {
		for (int i = 0; i < count; i++) {
			pooledEnemyObj.Add(CreateObj(EnemyType.Enemy, parent));			
			pooledLaserObj.Add(CreateObj(EnemyType.Laser, parent));			
			pooledHeartObj.Add(CreateObj(EnemyType.Heart, parent));
		}
	}

	/// <summary>
	/// 오브젝트 풀에 풀링할 오브젝트를 생성한다.
	/// </summary>
	/// <param name="enemyType">오브젝트의 종류</param>
	/// <param name="parent">풀링될 오브젝트의 부모 오브젝트</param>
	/// <returns>생성된 오브젝트</returns>
	public GameObject CreateObj(EnemyType enemyType, Transform parent = null) {
		switch (enemyType) {
			case EnemyType.Enemy:
				GameObject enemyObj = Instantiate(enemyPrefab);
				enemyObj.transform.SetParent(parent);
				enemyObj.SetActive(false);
				enemyObj.tag = "Pooled";
				return enemyObj;

			case EnemyType.Laser:
				GameObject laserObj = Instantiate(laserPrefab);
				laserObj.transform.SetParent(parent);
				laserObj.SetActive(false);
				laserObj.tag = "Pooled";
				return laserObj;

			case EnemyType.Heart:
				GameObject heartObj = Instantiate(heartPrefab);
				heartObj.transform.SetParent(parent);
				heartObj.SetActive(false);
				heartObj.tag = "Pooled";
				return heartObj;

			default:
				Debug.LogError("Invalid EnemyType");
				return null;
		}
	}

	/// <summary>
	/// 오브젝트를 풀에서 가져온다.
	/// </summary>
	/// <param name="enemyType">오브젝트의 종류</param>
	/// <param name="poolParent">풀링될 오브젝트의 부모 오브젝트</param>
	/// <returns>풀에서 가져온 오브젝트</returns>
	public GameObject PopFromPool(EnemyType enemyType, Vector3 position, Transform poolParent = null, Transform spawnParent = null) {
		switch (enemyType) {
			case EnemyType.Enemy:
				if (pooledEnemyObj.Count == 0)
					pooledEnemyObj.Add(CreateObj(EnemyType.Enemy, poolParent));

				GameObject enemyObj = pooledEnemyObj[0];
				pooledEnemyObj.RemoveAt(0);

				enemyObj.SetActive(true);
				enemyObj.transform.SetParent(spawnParent);
				enemyObj.tag = "Enemy";
				enemyObj.transform.position = position;

				return enemyObj;

			case EnemyType.Laser:
				if (pooledLaserObj.Count == 0)
					pooledLaserObj.Add(CreateObj(EnemyType.Laser, poolParent));

				GameObject laserObj = pooledLaserObj[0];
				pooledLaserObj.RemoveAt(0);

				laserObj.SetActive(true);
				laserObj.transform.SetParent(spawnParent);
				laserObj.tag = "Laser";
				laserObj.transform.position = position;

				return laserObj;

			case EnemyType.Heart:
				if (pooledHeartObj.Count == 0)
					pooledHeartObj.Add(CreateObj(EnemyType.Heart, poolParent));

				GameObject heartObj = pooledHeartObj[0];
				pooledHeartObj.RemoveAt(0);

				heartObj.SetActive(true);
				heartObj.transform.SetParent(spawnParent);
				heartObj.tag = "Heart";
				heartObj.transform.position = position;

				return heartObj;

			default:
				Debug.LogError("Invalid EnemyType");
				return null;
		}
	}

	/// <summary>
	/// 오브젝트를 다시 풀로 되돌린다.
	/// </summary>
	/// <param name="item">되돌릴 오브잭트</param>
	/// <param name="parent">풀링될 오브젝트의 부모 오브젝트</param>
	public void PushToPool(GameObject item, Transform parent = null) {
		switch (item.tag) {
			case "Enemy":
				pooledEnemyObj.Add(item);
				item.transform.SetParent(parent);
				item.SetActive(false);
				item.tag = "Pooled";
				break;

			case "Laser":
				pooledLaserObj.Add(item);
				item.transform.SetParent(parent);
				item.SetActive(false);
				item.tag = "Pooled";
				break;

			case "Heart":
				pooledHeartObj.Add(item);
				item.transform.SetParent(parent);
				item.SetActive(false);
				item.tag = "Pooled";
				break;

			default:
				Debug.LogError("Invalid EnemyType");
				break;
		}
	}
}
