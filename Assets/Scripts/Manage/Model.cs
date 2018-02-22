using System;

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

public static class Model {
	public static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\RhythmGame\";
}
