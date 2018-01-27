using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour {
	//private Animator animador;

	private bool saltando = false;
	private bool delay = false;

	IEnumerator salt(){
		delay = true;
		yield return new WaitForSeconds (.3f);
		delay = false;
	}

	/*void Start () {
		animador = GetComponent<Animator> ();
	}

	public void finAnSalto () {
		animador.SetBool ("saltando",false);
	}*/

	void FixedUpdate () {

		if (Input.GetKey(KeyCode.Space) && saltando == false && delay == false) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 10), ForceMode2D.Impulse);
			saltando = true;
			//animador.SetBool ("saltando",true);
			StartCoroutine ("salt");
		}
		if (delay == false) {
			bool enSuelo = Physics2D.Raycast (transform.position, new Vector2 (0, -1), 1.2f, 1 << LayerMask.NameToLayer ("Suelo"));
			if (enSuelo) {
				saltando = false;
			}
		}
	}
}
