using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
[Serializable]
public class GameSettings : ScriptableObject {
	public float speed;
	//public float speedBoost;
	//public float speedBoostDuration;
	
	//public float cookieScore;
	//public float speedUpCookieScore;

	public float cookieSpawnTime;
	public float cookieTimeLimit;
	public List<Vector3> cookieSpawnPoints;
}
