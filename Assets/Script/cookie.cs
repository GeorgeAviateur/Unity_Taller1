using UnityEngine;
using System;
using System.Collections;

public class cookie : MonoBehaviour {
	public Action touched;


	void OnTriggerEnter(Collider other){
		gameObject.SetActive(false);
		if (touched != null)
			touched ();

	}


}
