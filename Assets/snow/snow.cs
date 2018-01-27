using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snow : MonoBehaviour {

	public GameObject point;
	Rigidbody2D rb;
	Rigidbody2D rb_point;

	void Awake () {
		rb = this.GetComponent<Rigidbody2D>();
		rb_point = point.GetComponent<Rigidbody2D>();
		rb.AddForce(new Vector2 (-5, 0), ForceMode2D.Impulse);
	}

	void FixedUpdate () {
		if (rb.transform.position.y <= rb_point.transform.position.y) {
			Debug.Log ("Entro");
			this.destroy ();
		}
	}

	public void destroy() {
		Destroy (this.gameObject);
	}
}
