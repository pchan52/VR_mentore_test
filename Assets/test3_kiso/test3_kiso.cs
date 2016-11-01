using UnityEngine;
using System.Collections;

public class test3_kiso : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("printnumbers");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator printnumbers(){
		for (int i = 10; i >= 0; i--) {
			print(i);
			yield return new WaitForSeconds(0.5f);
		}
	}
}
