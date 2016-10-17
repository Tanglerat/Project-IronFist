using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {
	public string zpress;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("z")) {
			GetComponent<Animator>().SetTrigger(zpress);
	}
}
}