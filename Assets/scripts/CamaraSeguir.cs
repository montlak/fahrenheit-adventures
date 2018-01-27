using UnityEngine;
using System.Collections;

public class CamaraSeguir : MonoBehaviour {

	public GameObject objetivo;
	public float distanciax;
	public float distanciay;

	void FixedUpdate () {

		//this.transform.position = new Vector3 (objetivo.transform.position.x + distanciax, objetivo.transform.position.y + distanciay, this.transform.position.z);
		this.transform.position = new Vector3 (objetivo.transform.position.x + distanciax, this.transform.position.y + distanciay, this.transform.position.z);

	}
}
