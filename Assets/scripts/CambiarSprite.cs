using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarSprite : MonoBehaviour {
	private SpriteRenderer este;
	private bool delay = false;
	private bool caminando = false;
	private bool delay2 = false;
	private bool delay3 = false;

	public Sprite[] aquel;

	IEnumerator pasos(){
		delay = true;
		yield return new WaitForSeconds (0.2f);
		if (caminando == true && delay2 == false) {
			este.sprite = aquel [1];
		}
		yield return new WaitForSeconds (0.2f);
		if (caminando == true && delay2 == false) {
			este.sprite = aquel [2];
		}
		delay = false;
	}

	IEnumerator ataque() {
		delay2 = true;
		delay3 = true;
		este.sprite = aquel [3];
		yield return new WaitForSeconds (0.3f);
		este.sprite = aquel [0];
		delay2 = false;
		yield return new WaitForSeconds (0.1f);
		delay3 = false;
	}

	void Start () {
		este = GetComponent<SpriteRenderer>();
	}

	void FixedUpdate () {
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)) {
			caminando = true;
		} else {
			caminando = false;
		}

		if (Input.GetKey(KeyCode.Z) && delay2 == false && delay3 == false) {
			StartCoroutine ("ataque");
		} else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) && delay == false && delay2 == false) {
			StartCoroutine ("pasos");
		} else if (!Input.anyKeyDown && delay == false && delay2 == false) {
			este.sprite = aquel [0];
		}
	}
}
