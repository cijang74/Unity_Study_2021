using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningReusableMethodsWithReturn : MonoBehaviour {
	int num1 = 2;
	int num2 = 3;

	// Use this for initialization
	void Start () {
		int sumResult = AddTwoNumbers(num1, num2);
		DisplayResult(sumResult);

	}
	
	int AddTwoNumbers(int num1, int num2)
    {
		int result = num1 + num2;
		return result;
    }

	void DisplayResult(int total)
    {
		print("합의 결과는 " + total);
    }
}
