using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CommandData : MonoBehaviour, IDragHandler {

	#region Publics
	[NonSerialized]
	public CommandType type = CommandType.SpawnEnemy;

	[NonSerialized]
	public float activeTime = 0;

	[NonSerialized]
	public Direction spawnDir = Direction.Down;
	[NonSerialized]
	public int spawnPos = 0;
	[NonSerialized]
	public float speed = 10;
	[NonSerialized]
	public float velo = 0;
	[NonSerialized]
	public bool isHeart = false;
	[NonSerialized]
	public bool follow = false;

	[NonSerialized]
	public float time = 0;

	[NonSerialized]
	public int width = 3;
	[NonSerialized]
	public int height = 3;

	[NonSerialized]
	public ColorDataList colorDataList = ColorDataList.Back;
	[NonSerialized]
	public float r = 0;
	[NonSerialized]
	public float g = 0;
	[NonSerialized]
	public float b = 0;
	[NonSerialized]
	public LerpType lerpType = LerpType.None;
	[NonSerialized]
	public int level = 1;

	[NonSerialized]
	public float angle = 0;

	[NonSerialized]
	public float rate = 0;

	[NonSerialized]
	public float x = 0;
	[NonSerialized]
	public float y = 0;

	[NonSerialized]
	public bool visible = false;

	[NonSerialized]
	public float playerX = 0;
	[NonSerialized]
	public float playerY = 0;

	[NonSerialized]
	public string entityTag = "Enemy";
	#endregion
	
	private GameObject commandSettingObj;

	private CommandSettingData data;
	private bool clicked;

	public Image[] imageComps;

	private void Awake() {
		commandSettingObj = EditManageScript.Instance.commandSettingObj;
		data = commandSettingObj.GetComponent<CommandSettingData>();
		imageComps = gameObject.GetComponentsInChildren<Image>(true);
	}

	private void Start() {
		activeTime = (gameObject.transform.position.x / 1024.0f) * EditManageScript.Instance.musicLength;
		OpenSetting();
	}

	public void OpenSetting() {
		if (!commandSettingObj.activeSelf) 
			commandSettingObj.SetActive(true);

		data.commandObj = gameObject;
		data.Load();
	}

	public void OnDrag(PointerEventData eventData) {
		gameObject.transform.position = new Vector3(Input.mousePosition.x, 150, 0);
		activeTime = (Input.mousePosition.x / 1024) * EditManageScript.Instance.musicLength;
		OpenSetting();
	}
}
