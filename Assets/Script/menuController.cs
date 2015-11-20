using UnityEngine;
using System.Collections;

public class menuController : MonoBehaviour {

	public void OpenGame(string name){
		Application.LoadLevel(name);

	}
}
