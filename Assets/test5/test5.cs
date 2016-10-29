using UnityEngine;
using System.Collections;

public class test5 : MonoBehaviour {

	public GameObject rightObject;

	// Use this for initialization
	void Start () {
		Vector3 goalposition =  Vector3.Lerp (gameObject.transform.position, rightObject.transform.position, 0.5f);
		gameObject.transform.position = goalposition;
	}

	// Update is called once per frame
	void Update () {


	}
}
