using System;

public enum Difficulty {
	Boring,
	Easy,
	Normal,
	Hard,
	Impossible,
	Korean
}

public enum UITextType {
	LevelName,
	LevelDescription
}

public static partial class Utility {

	/// <summary>
	/// Return float value with Difficulty
	/// </summary>
	/// <param name="dif"></param>
	/// <returns></returns>
	public static float GetBeatSensivityOfDifficulty(Difficulty dif) {
		switch (dif) {
			case Difficulty.Boring:
				return 9f;
			case Difficulty.Easy:
				return 6f;
			case Difficulty.Normal:
				return 4.3f;
			case Difficulty.Hard:
				return 2.5f;
			case Difficulty.Impossible:
				return 1f;
			case Difficulty.Korean:
				return 0.0001f;
			default:
				return 4f;
		}
	}
}
