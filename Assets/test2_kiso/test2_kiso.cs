using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class test2_kiso : MonoBehaviour {

	List<int> numbers = new List<int> ();

	// Use this for initialization
	void Start () {
		numbers.Add(3);
		numbers.Add (6);
		numbers.Add (9);
		numbers.Add (12);
		printList (numbers);
		numbers.RemoveAt (2);
		printList (numbers);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void printList( List<int> numbers){
		for (int i = 0; i < numbers.Count; i++) {
			print (numbers [i]);
		}
	}
}