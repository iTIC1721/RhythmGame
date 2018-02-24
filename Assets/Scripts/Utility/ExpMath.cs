using UnityEngine;

public static class ExpMath {

	#region Lerp
	/// <summary>
	/// Ease In
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseIn(float t, int level) {
		if (t >= 0f && t <= 1f) {
			switch (level) {
				case 1:
					return 1f - Mathf.Cos(t * Mathf.PI * 0.5f);
				case 2:
					return Mathf.Pow(t, 2f);
				case 3:
					return Mathf.Pow(t, 4f);
				case 4:
					return Mathf.Pow(t, 6f);
				case 5:
					return Mathf.Pow(t, 8f);
				default:
					return t;
			}
		}
		else if (t < 0f)
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
		if (t >= 0f && t <= 1f) {
			switch (level) {
				case 1:
					return Mathf.Sin(t * Mathf.PI * 0.5f);
				case 2:
					return Mathf.Pow(t, 0.5f);
				case 3:
					return Mathf.Pow(t, 0.25f);
				case 4:
					return Mathf.Pow(t, 1.0f / 6.0f);
				case 5:
					return Mathf.Pow(t, 0.125f);
				default:
					return t;
			}
		}
		else if (t < 0f)
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
		if (t >= 0f && t <= 1f) {
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
				default:
					return t;
			}
		}
		else if (t < 0f)
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
		if (t >= 0f && t <= 1f) {
			switch (level) {
				case 1:
					return t * (t * (2 * t - 3) + 2);
				default:
					return t;
			}
		}
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// Wobble
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float Wobble(float t, int level) {
		if (t >= 0f && t <= 1f) {
			switch (level) {
				case 1:
					return TriWave(t, 0f, 2.0f / 3.0f, 0, 1);
				case 2:
					return TriWave(t, 0f, 2.0f / 5.0f, 0, 1);
				case 3:
					return TriWave(t, 0f, 2.0f / 7.0f, 0, 1);
				case 4:
					return TriWave(t, 0f, 2.0f / 9.0f, 0, 1);
				case 5:
					return TriWave(t, 0f, 2.0f / 11.0f, 0, 1);
				default:
					return t;
			}
		}
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// SmoothWobble
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SmoothWobble(float t, int level) {
		if (t >= 0f && t <= 1f) {
			switch (level) {
				case 1:
					return 0.5f * (Mathf.Sin(Mathf.PI * (3 * t - 0.5f)) + 1f);
				case 2:
					return 0.5f * (Mathf.Sin(Mathf.PI * (5 * t - 0.5f)) + 1f);
				case 3:
					return 0.5f * (Mathf.Sin(Mathf.PI * (7 * t - 0.5f)) + 1f);
				case 4:
					return 0.5f * (Mathf.Sin(Mathf.PI * (9 * t - 0.5f)) + 1f);
				case 5:
					return 0.5f * (Mathf.Sin(Mathf.PI * (11 * t - 0.5f)) + 1f);
				default:
					return t;
			}
		}
		else if (t < 0f)
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
		if (t >= 0f && t <= 1f) {
			switch (level) {
				case 1:
					return Mathf.Abs(Mathf.Sin(1.5f * Mathf.PI * t));
				case 2:
					return Mathf.Abs(Mathf.Sin(2.5f * Mathf.PI * t));
				case 3:
					return Mathf.Abs(Mathf.Sin(3.5f * Mathf.PI * t));
				case 4:
					return Mathf.Abs(Mathf.Sin(4.5f * Mathf.PI * t));
				case 5:
					return Mathf.Abs(Mathf.Sin(5.5f * Mathf.PI * t));
				default:
					return t;
			}
		}
		else if (t < 0f)
			return 0;
		else
			return 1;
	}
	#endregion

	#region Additional
	/// <summary>
	/// t에 대한 삼각파를 반환합니다.
	/// </summary>
	/// <param name="t">입력값</param>
	/// <param name="minX">주기의 최소 x값</param>
	/// <param name="maxX">주기의 최대 x값</param>
	/// <param name="minY">주기의 최소 y값</param>
	/// <param name="maxY">주기의 최대 y값</param>
	/// <returns>t값에 대한 삼각파 함수값</returns>
	public static float TriWave(float t, float minX, float maxX, float minY, float maxY) {
		float period = maxX - minX;
		float midPointX = (minX + maxX) / 2.0f;
		if (t > maxX)
			t += period * Mathf.Ceil((minX - t) / period);
		else if (t < minX)
			t += period * Mathf.Ceil((t - maxX) / period);

		float gradient = (maxY - minY) / (midPointX - minX);
		if (t < midPointX) {
			return (gradient * (t - minX)) + minX;
		}
		else if (t > midPointX) {
			return (-gradient * (t - midPointX)) + maxX;
		}
		else {
			return maxY;
		}
	}
	#endregion
}
