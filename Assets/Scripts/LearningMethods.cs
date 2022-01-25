using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningMethods : MonoBehaviour 
{
	void Awake()
	{
		print("Awake function is called");
	}

	// Use this for initialization
	void Start () 
	{
		print("Start function is called");
	}
	
	// Update is called once per frame
	void Update () 
	{
		print(Time.time);
	}
}
