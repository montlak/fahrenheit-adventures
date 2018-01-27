using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectar : MonoBehaviour {

	void Start () {
		
	}

	void FixedUpdate () {
		bool detectando = Physics2D.Raycast (transform.position, new Vector2 (0, -1), 8f, 1 << LayerMask.NameToLayer ("Objetivo"));
		if (detectando){
			Debug.Log("te pones bien cachonda");
		}
	}
}
