using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	public float velocidad = 0;

	private bool mirandoDerecha = true;
	//private Animator animador;

	/*void Start () {
		animador = GetComponent<Animator> ();
	}*/

	void FixedUpdate () {
		if (Input.GetKey(KeyCode.RightArrow)){
			if (mirandoDerecha == false){
				transform.Rotate(new Vector3(0,180,0));
				mirandoDerecha = true;
			}
			//animador.SetBool ("caminando",true);
			transform.Translate(Vector3.right * velocidad * Time.deltaTime, Space.World);
		}
		else if (Input.GetKey(KeyCode.LeftArrow)){
			if (mirandoDerecha == true){
				transform.Rotate(new Vector3(0,180,0));
				mirandoDerecha = false;
			}
			//animador.SetBool ("caminando",true);
			transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.World);
		} 
		/*else {
			animador.SetBool ("caminando",false);
		}*/
	}

}
