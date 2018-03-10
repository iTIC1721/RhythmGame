using System;
using UnityEngine;
using UnityEngine.UI;

public class CommandSettingData : MonoBehaviour {

	public GameObject commandObj;

	public Dropdown typeDropDown;

	private CommandData commandData;

	public void Load() {
		commandData = commandObj.GetComponent<CommandData>();
		switch (commandData.type) {
			case CommandType.SpawnEnemy:
				typeDropDown.value = 0;
				break;

			case CommandType.SpawnLaser:
				typeDropDown.value = 1;
				break;

			case CommandType.ChangeColor:
				typeDropDown.value = 2;
				break;

			case CommandType.ResizeLevel:
				typeDropDown.value = 3;
				break;

			case CommandType.RotateLevel:
				typeDropDown.value = 4;
				break;

			case CommandType.EnlargeLevel:
				typeDropDown.value = 5;
				break;

			case CommandType.MoveLevel:
				typeDropDown.value = 6;
				break;

			case CommandType.ReplacePlayer:
				typeDropDown.value = 7;
				break;

			case CommandType.PlayerVisible:
				typeDropDown.value = 8;
				break;

			case CommandType.Kill:
				typeDropDown.value = 9;
				break;
		}
	}

	public void UpdateType(int type) {
		try {
			commandData.type = (CommandType)Enum.Parse(typeof(CommandType), type.ToString());
		}
		catch (Exception) {
			Debug.LogWarning("Can't Parse " + type + " to CommandType");
		}
	}
}
