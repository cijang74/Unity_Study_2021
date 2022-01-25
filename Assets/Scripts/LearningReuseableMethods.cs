using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningReuseableMethods : MonoBehaviour {
	public int num1 = 2;
	public int num2 = 7;
	public int num3 = 4;

	// Use this for initialization
	void Start () {
		print(AddAndPrintTwoNumbers(num1, num2));
		print(AddAndPrintTwoNumbers(num2, num3));
		print(AddAndPrintTwoNumbers(num1, num3));
	}
	
	// Update is called once per frame
	int AddAndPrintTwoNumbers (int num1, int num2) {
		int result = num1 + num2;
		return result;
	}
}
