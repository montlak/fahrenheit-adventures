using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {

	public GameObject copo;


	void Awake () {
		
	}

	void FixedUpdate () {
		int randomNumber = Random.Range (1, 100);
		if (randomNumber > 50) {
			Camera cam = Camera.main;
			float ancho = cam.orthographicSize;
			float valorXRandom = Random.Range (ancho * -1f, ancho*3);
			float snowSize = Random.Range (0.5f, 1.5f);
			copo.transform.localScale = new Vector3(snowSize, snowSize, 0);
			Instantiate (copo, new Vector3 (valorXRandom, 6f, -1), Quaternion.identity);
		}
	}
}