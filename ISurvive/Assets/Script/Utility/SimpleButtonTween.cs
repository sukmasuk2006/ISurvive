using UnityEngine;
using System.Collections;

public class SimpleButtonTween : MonoBehaviour {

	public GameObject tweenedObject;
	public GameObject removedObject;
	public bool isRemoved = true;

	// Use this for initialization
	void Start () {
	}


	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		iTween.MoveTo (tweenedObject, iTween.Hash ("position", removedObject.transform.position, "time", 0.1f,"EaseType","linear"));
		if ( isRemoved )
			iTween.MoveTo (removedObject, iTween.Hash ("position", tweenedObject.transform.position, "time", 0.1f,"EaseType","linear"));
		GameData.gameState = tweenedObject.name;
		Debug.Log("stat " + tweenedObject.name);
	}
}
