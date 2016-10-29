using UnityEngine;
using System.Collections;

public class test7 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (Time.deltaTime*2f, 0f, 0f); 
	
	}

	void OnTriggerEnter(Collider other){
		print (other.name);
	}
}
