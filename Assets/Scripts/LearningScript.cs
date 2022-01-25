using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript : MonoBehaviour 
{
	public int mynumber1 = 11;
	public int mynumber2 = 9;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.Return)) AddTwoNumbers();
	}

	void AddTwoNumbers()
    {
		Debug.Log(mynumber1 + mynumber2);
    }
}
