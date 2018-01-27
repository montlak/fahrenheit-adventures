using UnityEngine;
using System.Collections;

public class Destruido : MonoBehaviour {

	public float tiempo = 3;

	IEnumerator muriendo(){
		yield return new WaitForSeconds (tiempo);
		Destroy (this.gameObject);
	}

	void Start () {
		StartCoroutine ("muriendo");
	}
}
