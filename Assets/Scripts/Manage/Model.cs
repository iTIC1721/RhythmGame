using System;

/// <summary>
/// 레벨 타입을 나타내는 열거형
/// </summary>
public enum LevelPlayType {
	NonDamage,
	Normal,
	Challenge
}

/// <summary>
/// 가능한 색 변경 열거형
/// </summary>
public enum ColorDataList {
	Back,
	Level,
	Enemy
}

/// <summary>
/// 방향 열거형
/// </summary>
public enum Direction {
	Right,
	Down,
	Left,
	Up
}

/// <summary>
/// Lerp용 열거형
/// </summary>
public enum LerpType {
	None,
	EaseIn,
	EaseOut,
	SmoothStep,
	InvSmoothStep,
	Bounce,
	TriWave,
	SinWave,
	SqrWave,
	SawWave
}

public enum CommandType {
	SpawnEnemy,
	SpawnLaser,
	ChangeColor,
	ResizeLevel,
	RotateLevel,
	EnlargeLevel,
	MoveLevel,
	ReplacePlayer,
	PlayerVisible,
	Kill
}

public static class Model {
	public static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\RhythmGame\";
}
