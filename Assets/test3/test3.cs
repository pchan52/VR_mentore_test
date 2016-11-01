using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test3 : MonoBehaviour {

	enum  Zibun{
		Tech,
		CampChan,
		Toukyouto,
	}
		
	public Text[] text = new Text[4] ;

	// Use this for initialization
	void Start () {
		Zibun Myouzi = Zibun.Tech;
		Zibun Namae = Zibun.CampChan;
		Zibun Zyuusyo = Zibun.Toukyouto;

		text[0].text =  "苗字:"+Myouzi ;
		text[1].text = "名前:" +Namae ;
		text[2].text = "住所:"+ Zyuusyo ;

		text[3].text = "1~100の和:" + AllFigurSum (100);
	}

	int AllFigurSum(int n){
		int answer = 0;
		for (int r = 1; r <= 100; r++) {
			answer += r;
		}
		return answer;
	}
}
