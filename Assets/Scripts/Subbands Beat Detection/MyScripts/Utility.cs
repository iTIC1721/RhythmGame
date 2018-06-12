using System;

public enum Difficulty {
	Boring,
	Easy,
	Normal,
	Hard,
	Impossible,
	Korean
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
				return 4f;
			case Difficulty.Hard:
				return 2f;
			case Difficulty.Impossible:
				return 0.5f;
			case Difficulty.Korean:
				return 0.0001f;
			default:
				return 4f;
		}
	}
}
