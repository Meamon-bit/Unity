using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class ClickedChip : MonoBehaviour {

    Rigidbody rigidBody;
    public Vector3 force = new Vector3(0, 10, 0);
    public ForceMode forceMode = ForceMode.VelocityChange;

    // Use this for initialization
    void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody>();

    }
    public void OnUserAction()
    {
	if(transform.name == "Stage1"){
		SceneManager.LoadScene("SampleScene");
	}
	if(transform.name == "Stage2"){
		SceneManager.LoadScene("Stage2");
	}
	if(transform.name == "Stage3"){
		SceneManager.LoadScene("Stage3");
	}
    } 
}
