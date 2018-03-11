using System;
using UnityEngine;

public class Copy : MonoBehaviour {

	#region Publics
	[NonSerialized]
	public CommandType type = CommandType.SpawnEnemy;

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
	public int playerX = 0;
	[NonSerialized]
	public int playerY = 0;

	[NonSerialized]
	public string entityTag = "Enemy";
	#endregion
}
