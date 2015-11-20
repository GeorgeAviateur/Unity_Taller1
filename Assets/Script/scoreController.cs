using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class scoreController : MonoBehaviour {
	private float cookieScore;
	private Text totalScore;
	private GameObject[] cookies;
	
	void Start(){
		totalScore = FindObjectOfType (typeof(Text)) as Text;
		cookies = GameObject.FindGameObjectsWithTag ("Cookie");
		foreach(GameObject cookie in cookies){
			cookie.GetComponent<cookie>().touched += HandleCookedTouched;
		}
	}

	void HandleCookedTouched(){
		cookieScore += 1;

	}
	// Update is called once per frame
	void Update () {
		totalScore.text = "Su puntaje es: "+cookieScore;
		Debug.Log (cookieScore);
	}
	public void SuperCookieTouched(){
		cookieScore += 1;

	}
}