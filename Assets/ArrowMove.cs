using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
	int NumberOfCommands = 5;
    int CurrentNumber = 0;
    float PositionArrowY = 49f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
        	CurrentNumber = (CurrentNumber + 1) % NumberOfCommands;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
        	CurrentNumber = (CurrentNumber + NumberOfCommands - 1) % NumberOfCommands;
        }
        PositionArrowY = 49 + CurrentNumber*29;

		transform.position = new Vector3(transform.position.x, PositionArrowY, transform.position.z);
		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log(CurrentNumber);
		}
	}
}
