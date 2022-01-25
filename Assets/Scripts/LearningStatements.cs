using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningStatements : MonoBehaviour {
	public Hashtable students = new Hashtable()
	{
		{"김재훈", 202111074}
	};

	// Use this for initialization
	void Start () {
		print((int)students["김재훈"]);

	}

	// Update is called once per frame
	void Update () {
		
	}
}
