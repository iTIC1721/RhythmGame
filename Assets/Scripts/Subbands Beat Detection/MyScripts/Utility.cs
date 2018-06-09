using System;

public enum Difficulty {
	Boring,
	Easy,
	Normal,
	Hard,
	Impossible
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
				return 13f;
			case Difficulty.Easy:
				return 10f;
			case Difficulty.Normal:
				return 7f;
			case Difficulty.Hard:
				return 4f;
			case Difficulty.Impossible:
				return 1f;
			default:
				return 7f;
		}
	}
}
