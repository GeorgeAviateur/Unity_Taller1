using UnityEngine;
using System.Collections;

public class cookie : MonoBehaviour {
	void onTriggerEnter(Collider other){
		gameObject.SetActive(false);
		Debug.Log ("MM que rica galleta :P");
	}
	void Update(){}

}
