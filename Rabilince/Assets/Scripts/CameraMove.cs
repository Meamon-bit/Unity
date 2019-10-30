using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 PlayerPosi = GameObject.Find("Player").transform.position;
		transform.position = PlayerPosi;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
