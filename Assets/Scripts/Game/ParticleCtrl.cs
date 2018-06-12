using System.Collections;
using UnityEngine;

public class ParticleCtrl : MonoBehaviour {

	// Use this for initialization
	void Start() {
		StartCoroutine(Kill());
	}

	private IEnumerator Kill() {
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);
	}
}
