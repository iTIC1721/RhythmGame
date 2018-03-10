using System;
using UnityEngine;

public class CommandData : MonoBehaviour {

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
	public Color color = Color.black;
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
	public Vector2 pos = Vector2.zero;

	[NonSerialized]
	public string entityTag = "Enemy";
	#endregion

	private EditManageScript editManage;
	private GameObject commandSettingObj;

	private CommandSettingData data;

	private void Awake() {
		editManage = GameObject.FindGameObjectWithTag("EditManager").GetComponent<EditManageScript>();
		commandSettingObj = editManage.commandSettingObj;
		data = commandSettingObj.GetComponent<CommandSettingData>();
	}

	private void Start() {
		OpenSetting();
	}

	public void OpenSetting() {
		if (!commandSettingObj.activeSelf) 
			commandSettingObj.SetActive(true);

		data.commandObj = gameObject;
		data.Load();
	}
}
