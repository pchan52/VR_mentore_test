using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {

	string name = "池田光";
	float height = 170;
	float weight = 65;
	float BMI;

	// Use this for initialization
	void Start () {
		BMI = calcBMI (height, weight);
		if (BMI < 18.5) {
			print (name + "さんは痩せ型です");
		} else if (25 <= BMI) { 
			print (name + "さんは肥満です");
		} else {
			print (name + "さんは普通です");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	float calcBMI(float height, float weight){
		float height_m = height/100;
		return weight / (height_m * height_m);
	
	}

}
