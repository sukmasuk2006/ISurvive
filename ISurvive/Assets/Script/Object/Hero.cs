using UnityEngine;
using System.Collections;

public class Hero : Unit {
		
	private string job;
	private string weapon;

	public Hero(string iconPath,string name,string desc,string job,int lev,float str,float agi,float intel,
	            float dex, float vit):
	base(iconPath,name,desc,lev,str,agi,intel,dex,vit){
		this.job = job;
	}

	// Use this for initialization
	/*void Start () {
		sR = GameObject.Find("BG1").GetComponent<SpriteRenderer> ();
		num = Random.Range (1, 5);
		Debug.Log ("num " + num);
		sR.sprite = (Sprite)Resources.Load("Background/BG"+num, typeof(Sprite));
	}
*/
}
