using UnityEngine;
using System.Collections;

public class LogoSceneController : MonoBehaviour {

	private const int DELAY = 2;
	public GameObject tweenedObject;
	public GameObject removedObject;
	// Use this for initialization
	void Start () {
		StartCoroutine (alp());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	public IEnumerator alp(){
		yield return new WaitForSeconds(DELAY);
		iTween.MoveTo (tweenedObject, iTween.Hash ("position", removedObject.transform.position, "time", 1f));
		iTween.MoveTo (removedObject, iTween.Hash ("position", tweenedObject.transform.position, "time", 1f,"EaseType","linear"));
	}
}
