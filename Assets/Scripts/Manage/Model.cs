﻿using System;

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
	EaseIn1,
	EaseIn2,
	EaseOut1,
	EaseOut2,
	SmoothStep1,
	SmoothStep2,
	SmoothStep3,
	SmoothStep4,
	SmoothStep5,
	SmoothStep6
}

public static class Model {
	public static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\RhythmGame\";
}
