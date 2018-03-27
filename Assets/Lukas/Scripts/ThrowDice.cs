using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDice : MonoBehaviour {

    //the Die spawnpoint
    public GameObject launcher;

    //different Die Prefabs
    public GameObject dFour;
    public GameObject dSix;
    public GameObject dEight;
    public GameObject dTen;
    public GameObject dTwelve;
    public GameObject dTwenty;

    public enum DiceType { dFour, dSix, dEight, dTen, dTwelve, dTwenty }

    public DiceType selectedDice;

    private GameObject diceToThrow;


    // Use this for initialization
    void Start ()
    {
        SetDiceToThrow();
	}
	
	// Update is called once per frame
	void Update ()
    {
		//if(Input.GetKeyDown(KeyCode.T))
  //      {
  //          Instantiate(dSix, gameObject.transform.position, transform.rotation);
  //      }
	}

    public void ThowDice (GameObject dice)
    {
        Instantiate(dice, launcher.transform.position, transform.rotation);
        
    }

    public void OnClick()
    {
        Instantiate(diceToThrow, launcher.transform.position, transform.rotation);
    }

    void SetDiceToThrow ()
    {
        switch (selectedDice)
        {
            case DiceType.dFour:
                diceToThrow = dFour;
                break;

            case DiceType.dSix:
                diceToThrow = dSix;
                break;

            case DiceType.dEight:
                diceToThrow = dEight;
                break;

            case DiceType.dTen:
                diceToThrow = dTen;
                break;

            case DiceType.dTwelve:
                diceToThrow = dTwelve;
                break;

            case DiceType.dTwenty:
                diceToThrow = dTwenty;
                break;

            default:
                Debug.Log("Error selecting dice type");
                break;
        }
    }

}