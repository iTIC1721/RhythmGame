using System;
using UnityEngine;
using UnityEngine.UI;

public class CommandSettingData : MonoBehaviour {

	public GameObject commandObj;

	public GameObject[] tabs = new GameObject[10];

	public Dropdown typeDropDown;

	public Dropdown dirDropDown1;
	public InputField spawnPosInput1;
	public InputField speedInput;
	public InputField veloInput;
	public Toggle isHeartToggle;
	public Toggle followToggle1;

	public Dropdown dirDropDown2;
	public InputField spawnPosInput2;
	public InputField timeInput1;
	public Toggle followToggle2;

	private CommandData commandData;

	private void ReloadTabs(int tab) {
		for (int i = 0; i < tabs.Length; i++) {
			if (tabs[i] == null) continue;

			if (i == tab) {
				tabs[i].SetActive(true);
			}
			else {
				tabs[i].SetActive(false);
			}
		}
	}

	public void Load() {
		commandData = commandObj.GetComponent<CommandData>();
		switch (commandData.type) {
			case CommandType.SpawnEnemy:
				typeDropDown.value = 0;
				ReloadTabs(0);
				switch (commandData.spawnDir) {
					case Direction.Right:
						dirDropDown1.value = 0;
						break;
					case Direction.Down:
						dirDropDown1.value = 1;
						break;
					case Direction.Left:
						dirDropDown1.value = 2;
						break;
					case Direction.Up:
						dirDropDown1.value = 3;
						break;
				}
				spawnPosInput1.text = commandData.spawnPos.ToString();
				speedInput.text = commandData.speed.ToString();
				veloInput.text = commandData.velo.ToString();
				isHeartToggle.isOn = commandData.isHeart;
				followToggle1.isOn = commandData.follow;
				break;

			case CommandType.SpawnLaser:
				typeDropDown.value = 1;
				ReloadTabs(1);
				switch (commandData.spawnDir) {
					case Direction.Right:
						dirDropDown2.value = 0;
						break;
					case Direction.Down:
						dirDropDown2.value = 1;
						break;
					case Direction.Left:
						dirDropDown2.value = 2;
						break;
					case Direction.Up:
						dirDropDown2.value = 3;
						break;
				}
				spawnPosInput2.text = commandData.spawnPos.ToString();
				timeInput1.text = commandData.time.ToString();
				followToggle2.isOn = commandData.follow;
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
			Load();
		}
		catch (Exception) {
			Debug.LogWarning("Can't Parse " + type + " to CommandType");
		}
	}

	public void UpdateDirection(int dir) {
		try {
			commandData.spawnDir = (Direction)Enum.Parse(typeof(Direction), dir.ToString());
		}
		catch (Exception) {
			Debug.LogWarning("Can't Parse " + dir + " to Direction");
		}
	}

	public void UpdateSpawnPos(string spawnPos) {
		try {
			commandData.spawnPos = int.Parse(spawnPos);
		}
		catch (Exception) {
			Debug.LogWarning("Can't Parse " + spawnPos + " to integer");
		}
	}

	public void UpdateSpeed(string speed) {
		try {
			commandData.speed = float.Parse(speed);
		}
		catch (Exception) {
			Debug.LogWarning("Can't Parse " + speed + " to demial number");
		}
	}

	public void UpdateVelo(string velo) {
		try {
			commandData.velo = float.Parse(velo);
		}
		catch (Exception) {
			Debug.LogWarning("Can't Parse " + velo + " to demial number");
		}
	}

	public void UpdateIsHeart(bool isHeart) {
		commandData.isHeart = isHeart;
	}

	public void UpdateFollow(bool follow) {
		commandData.follow = follow;
	}

	public void UpdateTime(string time) {
		try {
			commandData.time = float.Parse(time);
		}
		catch (Exception) {
			Debug.LogWarning("Can't Parse " + time + " to demial number");
		}
	}
}
