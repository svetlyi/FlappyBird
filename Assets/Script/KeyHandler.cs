using UnityEngine;
using System.Collections;

public class KeyHandler : MonoBehaviour {
	public GameObject light;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 lightPos = transform.position;
		lightPos.z = -3;
		light.transform.position = lightPos;
		if (Input.GetKey("space") || (Input.touchCount == 1)) {
			this.gameObject.rigidbody.AddForce(0, 20, 0);
		}
	}
}
