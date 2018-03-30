using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int DiceResult;
	public int DiceAmount;
	public GameObject DicePrefab;
	public Text ResultText;

	GameObject[] Dices;
	float Timer = 5.0f;
	bool canDisplay = false;
	


	// Use this for initialization
	void Start ()
	{

		ResultText.text = DiceResult.ToString();

		InvokeRepeating("DisplayResult", 5, 1);

	}

	void Update()
	{
		Dices = GameObject.FindGameObjectsWithTag("Dice");
	}
	
	//Displays the current Dice result by wiping clean the result before a search of all the dices in the scene
	//finds the dice number of each dice, and adds it all together to get the result
	void DisplayResult()
	{

			DiceResult = 0;
			for (int f = 0; f < Dices.Length; f++)
			{
				DiceResult = DiceResult + Dices[f].GetComponent<Dice>().DiceNumber;
			}
			Debug.Log("RESULT: " + DiceResult);

		ResultText.text = DiceResult.ToString();

	}

	public void SpawnDice()
	{

		for (int a = 0; a < Dices.Length; a++)
		{
			Destroy(Dices[a]);
		}

		for (int i = 0; i < DiceAmount; i++)
		{
			
			Vector3 newPosition = new Vector3(Random.Range(-7.0f, 7.0f), 15, Random.Range(-7.0f, 7.0f));
			Instantiate(DicePrefab, newPosition, Quaternion.identity);
		}
		
	}



}
