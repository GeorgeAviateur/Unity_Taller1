using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {
	public GameObject superCookie;
	private GameObject activeSuperCookie;
	// Use this for initialization
	void Start () {
		activeSuperCookie = Instantiate (superCookie);
		StartCoroutine (ScheduleCookieDestroy());
	}
	IEnumerator ScheduleCookieDestroy(){
		yield return new WaitForSeconds (3.0f);
		Destroy (activeSuperCookie);

	}
	// Update is called once per frame
	void Update () {
	
	}
}
