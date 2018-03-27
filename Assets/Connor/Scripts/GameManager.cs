using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public int DiceResult;

	// Use this for initialization
	void Start () {
		DiceResult = 0;
	}
	
	
	void DisplayResult()
	{
		Debug.Log("RESULT: " + DiceResult);
	}

}
