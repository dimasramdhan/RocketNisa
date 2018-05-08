using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (transform.GetChild (0).gameObject, 2);
		Destroy (gameObject, 10f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
