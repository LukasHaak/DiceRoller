using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceBase : MonoBehaviour {


    public int selectedVector;

    public int[] dieNumber;
    public Vector3[] vectorPoints;  //Number of sides, as it's one vector per side.

	// Use this for initialization
	void Start ()
    {
        //gameObject

        int dieSize = vectorPoints.Length;

        dieNumber = new int[dieSize];

        dieNumber[0] = vectorPoints.Length;

		for(int i = 1; i < vectorPoints.Length; i++)
        {
            dieNumber[i] = i;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        float currentBest = -1;

        for(int i = 0; i < vectorPoints.Length; ++i)
        {
            var vectorValue = vectorPoints[i];
            var worldSpaceValueVector = this.transform.localToWorldMatrix.MultiplyVector(vectorValue);

            float dot = Vector3.Dot(worldSpaceValueVector, Vector3.up);

            if (dot > currentBest)
            {
                currentBest = dot;
                selectedVector = dieNumber[i];
            }
        }
		
	}

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        foreach (var valueVector in vectorPoints)
        {
            var worldSpaceValueVector = this.transform.localToWorldMatrix.MultiplyVector(valueVector);

            Gizmos.DrawLine(this.transform.position, this.transform.position + worldSpaceValueVector);
        }
    }
}
