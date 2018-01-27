using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelCalor : MonoBehaviour {
	public GameObject invocar;
	public bool seDerrite = false;
	public int limiteCalor = 2;
	public int limiteFrio = 0;
	public int calor = 1;

	void OnTriggerEnter2D(Collider2D este) {
		if (este.gameObject.tag == "absorber") {
			if (calor > limiteFrio) {
				calor -= 1;
			}
		}
		if (este.gameObject.tag == "recibir") {
			if (calor < limiteCalor) {
				calor += 1;
			}
		}
	}

	void FixedUpdate () {
		if (seDerrite) {
			if (calor >= limiteCalor ) {
				Instantiate (invocar, transform.position, transform.rotation);
				Destroy (this.gameObject);
			}
		} else {
			if (calor <= limiteFrio ) {
				Instantiate (invocar, transform.position, transform.rotation);
				Destroy (this.gameObject);
			}
		}

	}
}
