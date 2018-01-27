using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntar : MonoBehaviour {
	private int inclinacion = 0;
	private bool delay = false;

	public SpriteRenderer este;
	public Sprite[] aquel;

	IEnumerator esperar(){
		delay = true;
		yield return new WaitForSeconds (.3f);
		delay = false;
	}

	void FixedUpdate () {
		if (Input.GetKey (KeyCode.UpArrow) && inclinacion < 1 && !delay) {
			transform.Rotate (0, 0, 45);
			inclinacion += 1;
			StartCoroutine ("esperar");
		} else if (Input.GetKey (KeyCode.DownArrow) && inclinacion > -1 && !delay) {
			transform.Rotate (0, 0, -45);
			inclinacion -= 1;
			StartCoroutine ("esperar");
		}
		if (inclinacion == 0) {
			este.sprite = aquel [0];
		} else if (inclinacion == 1) {
			este.sprite = aquel [1];
		} else if (inclinacion == -1) {
			este.sprite = aquel [2];
		}
	}
}
