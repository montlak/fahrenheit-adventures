using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour {

	IEnumerator expiracion(){
		yield return new WaitForSeconds (1);
		Destroy (this.gameObject);
	}

	void Start () {
		StartCoroutine ("expiracion");
	}

	void OnTriggerEnter2D (Collider2D este) {
		//Destroy (this.gameObject);
		if (este.gameObject.layer != 9 && este.gameObject.layer != 11) {
			Destroy (this.gameObject);
		}
	}

	void FixedUpdate () {
		transform.Translate (.3f, 0, 0, Space.Self);
	}
}
