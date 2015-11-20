using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class superCookie : cookie{
	private float cookieScore;
	private Text ScoreText;
	private List<GameObject> cookies;
	
	void Start(){

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.right,4f);
	}
}
