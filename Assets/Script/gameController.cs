using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameController : MonoBehaviour {
	public GameObject superCookie;
	private GameObject activeSuperCookie;
	public GameSettings gameSettings;
	public scoreController score;
	// Use this for initialization
	void Start () {
		activeSuperCookie = Instantiate (superCookie);
		StartCoroutine (ScheduleCookieDestroy());

	}
	
	IEnumerator ScheduleCookieDestroy(){
		yield return new WaitForSeconds (gameSettings.cookieSpawnTime);
		Destroy (activeSuperCookie);
		StartCoroutine (ScheduleCookieDestroy2());

	}
	IEnumerator ScheduleCookieDestroy2(){
		yield return new WaitForSeconds (gameSettings.cookieTimeLimit);
		activeSuperCookie = Instantiate (superCookie);
		activeSuperCookie.transform.position = gameSettings.cookieSpawnPoints[Random.Range (0,gameSettings.cookieSpawnPoints.Count)];
		activeSuperCookie.GetComponent<superCookie>().touched=HandledSuperCookieTouched;
		StartCoroutine (ScheduleCookieDestroy());
	}

	void HandledSuperCookieTouched(){
		Debug.Log ("tocada");
		score.SuperCookieTouched();

	}

	// Update is called once per frame
	void Update () {
	
	}
}
