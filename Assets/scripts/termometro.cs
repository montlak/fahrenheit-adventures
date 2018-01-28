using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class termometro : MonoBehaviour {

	public GameObject termometroBar;
	public float amount = 0;
	public float initial = 0.6230746f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		reduceBar (amount);
	}

	public void reduceBar(float value) {
		Vector3 theScale = termometroBar.transform.localScale;
		value = (initial / 100) * value;
		theScale.x = value;

		termometroBar.transform.localScale = theScale;
	}
}
