using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMove: MonoBehaviour {

    public float objectSpeed = 0.5f;
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(0f, 0f, objectSpeed);
	}
}
