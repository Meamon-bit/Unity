﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("up")){
			transform.position += transform.forward * 0.1f;
		}

		if(Input.GetKey("right")){
			transform.Rotate(0,5,0);
		}

		if(Input.GetKey("left")){
			transform.Rotate(0,-5,0);
		}
	}
}
