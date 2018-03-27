using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceCalculator : MonoBehaviour {

    public GameObject[] diceInPlay;
    public int totalRolled;

	// Use this for initialization
	void Start ()
    {
       //diceInPlay = GameObject.FindGameObjectsWithTag("dice");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetTotalRolled();
        }
	}

    void GetTotalRolled ()
    {
        totalRolled = 0;
        diceInPlay = GameObject.FindGameObjectsWithTag("dice");

        foreach (var myDice in diceInPlay)
        {
            totalRolled += myDice.GetComponent<diceBase>().selectedVector;
        }
    }
}
