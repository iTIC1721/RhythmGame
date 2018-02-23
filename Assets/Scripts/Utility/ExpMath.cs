using UnityEngine;

public static class ExpMath {

	/// <summary>
	/// 1단계 Ease In
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseIn1(float t) {
		if (t >= 0f && t <= 1f)
			return 1f - Mathf.Cos(t * Mathf.PI * 0.5f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 2단계 Ease In
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseIn2(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 2f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 3단계 Ease In
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseIn3(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 4f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 4단계 Ease In
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseIn4(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 6f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 5단계 Ease In
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseIn5(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 8f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 6단계 Ease In
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseIn6(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 10f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 1단계 Ease Out
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseOut1(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Sin(t * Mathf.PI * 0.5f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 2단계 Ease Out
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseOut2(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 0.5f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 3단계 Ease Out
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseOut3(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 0.25f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 4단계 Ease Out
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseOut4(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 1.0f / 6.0f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 5단계 Ease Out
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseOut5(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 0.125f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 6단계 Ease Out
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float EaseOut6(float t) {
		if (t >= 0f && t <= 1f)
			return Mathf.Pow(t, 0.1f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 1단계 SmoothStep
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SmoothStep1(float t) {
		if (t >= 0f && t <= 1f)
			return t * t * (3 - 2 * t);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 2단계 SmoothStep
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SmoothStep2(float t) {
		if (t >= 0f && t <= 1f)
			return t * t * t * (t * (6f * t - 15f) + 10f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 3단계 SmoothStep
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SmoothStep3(float t) {
		if (t >= 0f && t <= 1f)
			return t * t * t * t * (t * (t * (-20f * t + 70f) - 84f) + 35f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 4단계 SmoothStep
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SmoothStep4(float t) {
		if (t >= 0f && t <= 1f)
			return t * t * t * t * t * (t * (t * (t * (70f * t -315f) + 540f) - 420f) + 126f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 5단계 SmoothStep
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SmoothStep5(float t) {
		if (t >= 0f && t <= 1f)
			return t * t * t * t * t * t * (t * (t * (t * (t * (-252f * t + 1386f) - 3080f) + 3465f) - 1980f) + 462f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 6단계 SmoothStep
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float SmoothStep6(float t) {
		if (t >= 0f && t <= 1f)
			return t * t * t * t * t * t * t * (t * (t * (t * (t * (t * (924f * t - 6006f) + 16380f) - 24024f) + 20020f) - 9009f) + 1716f);
		else if (t < 0f)
			return 0;
		else
			return 1;
	}

	/// <summary>
	/// 1단계 InvSmoothStep
	/// </summary>
	/// <param name="t"></param>
	/// <returns></returns>
	public static float InvSmoothStep1(float t) {
		if (t >= 0f && t <= 1f) {
			return t * (t * (2 * t - 3) + 2);
		}
		else if (t < 0f)
			return 0;
		else
			return 1;
	}
}
