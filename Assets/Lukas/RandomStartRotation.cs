using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStartRotation : MonoBehaviour {



	// Use this for initialization
	void Start ()
    {
        gameObject.transform.rotation = Random.rotation;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
