using UnityEngine;
using System.Collections;

public class FirstPlayChecker : MonoBehaviour {

	public GameObject tweenedObject;
	public GameObject removedObject;
	// Use this for initialization
	public string targetScene;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
			if (GameData.isFirstPlay) {
				iTween.MoveTo (tweenedObject, iTween.Hash ("position", removedObject.transform.position, "time", 2f));
				iTween.MoveTo (removedObject, iTween.Hash ("position", tweenedObject.transform.position, "time", 1f,"EaseType","linear"));
			}
			else
				Camera.main.GetComponent<ScreenFader> ().FadeOut (targetScene);
	}
}
