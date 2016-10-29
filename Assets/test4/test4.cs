using UnityEngine;
using System.Collections;

public class test4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){ //左クリックされたら
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //引数の座標に向けカメラからrayを飛ばす
			RaycastHit hit = new RaycastHit();	

			if (Physics.Raycast(ray, out hit)) {	//オブジェクトお衝突判定
				GameObject selectedObj = hit.collider.gameObject;               
				print("name: " + selectedObj.name + selectedObj.transform.position); 
			}

		}
	}

}