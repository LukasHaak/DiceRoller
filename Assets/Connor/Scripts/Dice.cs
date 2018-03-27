using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour {

	public GameObject[] Faces;
	public Vector3[] RayDirections;
	Vector3 RayDirection;
	public GameObject GameManager;

	int DiceNumber;
	float Timer = 3.0f;
	bool CanDisplayResult = false;
	


	void Start(){

		

	}
	
	// Update is called once per frame
	void Update () {
		
		for(int i = 0; i < Faces.Length; i++)
		{

			RayDirection = (transform.position - Faces[i].transform.position).normalized;
			Debug.DrawRay(transform.position, RayDirection * 10, Color.green);
			RayDirections[i] = RayDirection;
			
		}

		for (int f = 0; f < RayDirections.Length; f++)
		{
			if (Vector3.Dot(RayDirections[f], Vector3.down) < -0.95f)
			{
				DiceNumber = (Faces.Length - f);
			}
		
		}

		
	}




	void FixedUpdate()
	{
		if (Timer >= 0)
		{
			Timer -= Time.deltaTime;
			CanDisplayResult = false;
		}
		else { DisplayDiceRoll(); }
	}





	void DisplayDiceRoll()
	{
		var GameManagerScript = GameManager.GetComponent<GameManager>();

		if (CanDisplayResult == false)
		{
			GameManagerScript.Invoke("DisplayResult", 1.0f);
			GameManagerScript.DiceResult = GameManagerScript.DiceResult + DiceNumber;
			CanDisplayResult = true;
		}
	}
	



}
