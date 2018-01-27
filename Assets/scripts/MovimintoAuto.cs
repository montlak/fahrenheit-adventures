using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimintoAuto : MonoBehaviour {
	public float velocidad;

	void FixedUpdate () {

		transform.Translate (velocidad, 0, 0, Space.World);

	}
}
