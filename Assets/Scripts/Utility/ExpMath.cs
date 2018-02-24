using UnityEngine;

public static class ExpMath {

	#region Lerp
	/// <summary>
	/// Ease In
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseIn(float t, int level) {
		if (t > 0f && t < 1f) {
			if (level == 1)
				return 1f - Mathf.Cos(t * Mathf.PI * 0.5f);
			else if (level > 1)
				return Mathf.Pow(t, (level - 1) * 2);
			else
				return t;
		}
		else if (t <= 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// Ease Out
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseOut(float t, int level) {
		if (t > 0f && t < 1f) {
			if (level == 1)
				return Mathf.Sin(t * Mathf.PI * 0.5f);
			else if (level > 1)
				return Mathf.Pow(t, 1f / ((level - 1) * 2));
			else
				return t;
		}
		else if (t <= 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// SmoothStep
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SmoothStep(float t, int level) {
		if (t > 0f && t < 1f) {
			switch (level) {
				case 1:
					return t * t * (3 - 2 * t);
				case 2:
					return t * t * t * (t * (6f * t - 15f) + 10f);
				case 3:
					return t * t * t * t * (t * (t * (-20f * t + 70f) - 84f) + 35f);
				case 4:
					return t * t * t * t * t * (t * (t * (t * (70f * t - 315f) + 540f) - 420f) + 126f);
				case 5:
					return t * t * t * t * t * t * (t * (t * (t * (t * (-252f * t + 1386f) - 3080f) + 3465f) - 1980f) + 462f);
				case 6:
					return t * t * t * t * t * t * t * (t * (t * (t * (t * (t * (924f * t - 6006f) + 16380f) - 24024f) + 20020f) - 9009f) + 1716f);
				default:
					return t;
			}
		}
		else if (t <= 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// InvSmoothStep
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float InvSmoothStep(float t, int level) {
		if (t > 0f && t < 1f) {
			switch (level) {
				case 1:
					return t * (t * (2f * t - 3f) + 2f);
				case 2:
					return 2.8f * t * (t * (t - 1.5f) + (6f / 7f));
				default:
					return t;
			}
		}
		else if (t <= 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// Bounce
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float Bounce(float t, int level) {
		if (t > 0f && t < 1f) {
			if (level > 0)
				return Mathf.Abs(Mathf.Sin((level + 0.5f) * Mathf.PI * t));
			else
				return t;
		}
		else if (t <= 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// TriWave
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float TriWave(float t, int level) {
		if (t > 0f && t < 1f) {
			if (level > 0)
				return Mathf.Abs((2 / Mathf.PI) * Mathf.Asin(Mathf.Sin(((2f * Mathf.PI) / (4.0f / ((level * 2) + 1))) * t)));
			else
				return t;
		}
		else if (t <= 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// SinWave
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SinWave(float t, int level) {
		if (t > 0f && t < 1f) {
			if (level > 0)
				return 0.5f * (Mathf.Sin(Mathf.PI * (((level * 2) + 1) * t - 0.5f)) + 1f);
			else
				return t;
		}
		else if (t <= 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// SqrWave
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SqrWave(float t, int level) {
		if (t > 0f && t < 1f) {
			if (level > 0)
				return (0.5f * Mathf.Sign(Mathf.Sin(((level * 2) + 1) * Mathf.PI * t))) + 0.5f;
			else
				return t;
		}
		else if (t <= 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// SawWave
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SawWave(float t, int level) {
		if (t > 0f && t < 1f) {
			if (level > 0)
				return (-(1 / Mathf.PI) * Mathf.Atan(1 / Mathf.Tan((Mathf.PI * t) / (1.0f / (level + 1))))) + 0.5f;
			else
				return t;
		}
		else if (t <= 0f)
			return 0;
		else
			return 1;
	}
	#endregion
}
