using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public bool Active;
	
	public void SetThisActive()
	{
		if(Active == false)
		{
			gameObject.SetActive(true);
			Active = true;
		} else
		{
			gameObject.SetActive(false);
			Active = false;
		}

	}
	
	public void SetOff()
	{
		gameObject.SetActive(false);
		Active = false;
	}


}
