using UnityEngine;
using System.Collections;

public class KeyHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space")) {
			this.gameObject.rigidbody.AddForce(0, 20, 0);
		}
	}
}
