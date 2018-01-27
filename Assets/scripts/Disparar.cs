using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {
	private bool delay = false;

	public GameObject[] proyectil;

	IEnumerator esperar() {
		delay = true;
		yield return new WaitForSeconds (0.05f);
		delay = false;
	}

	void FixedUpdate () {
		if (Input.GetKey(KeyCode.Z) && delay == false) {
			Instantiate (proyectil[0], transform.position, transform.rotation);
			StartCoroutine ("esperar");
		} else if (Input.GetKey(KeyCode.X) && delay == false) {
			Instantiate (proyectil[1], transform.position, transform.rotation);
			StartCoroutine ("esperar");
		}
	}
}
