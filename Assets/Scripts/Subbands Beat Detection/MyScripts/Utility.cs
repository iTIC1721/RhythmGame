using System;

public enum Difficulty {
	Boring,
	Easy,
	Normal,
	Hard,
	Impossible
}

public static class Utility {

	/// <summary>
	/// Return float value with Difficulty
	/// </summary>
	/// <param name="dif"></param>
	/// <returns></returns>
	public static float GetBeatSensivityOfDifficulty(Difficulty dif) {
		switch (dif) {
			case Difficulty.Boring:
				return 8f;
			case Difficulty.Easy:
				return 6.5f;
			case Difficulty.Normal:
				return 5f;
			case Difficulty.Hard:
				return 3.5f;
			case Difficulty.Impossible:
				return 2f;
			default:
				return 5f;
		}
	}

	/// <summary>
	/// Return float value with Difficulty
	/// </summary>
	/// <param name="dif"></param>
	/// <returns></returns>
	public static float GetAverageSpeedOfDifficulty(Difficulty dif) {
		switch (dif) {
			case Difficulty.Boring:
				return 10f;
			case Difficulty.Easy:
				return 12f;
			case Difficulty.Normal:
				return 15f;
			case Difficulty.Hard:
				return 18f;
			case Difficulty.Impossible:
				return 21f;
			default:
				return 15f;
		}
	}
}
