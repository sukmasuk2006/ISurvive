using UnityEngine;
using System.Collections;

public class SimpleButton : MonoBehaviour {

	public string targetScene;
	public bool notCoveredByAnyScreen = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (notCoveredByAnyScreen) {
				Camera.main.GetComponent<ScreenFader> ().FadeOut (targetScene);

		}
	}
}
