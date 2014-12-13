using UnityEngine;
using System.Collections;

public class CollisionHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Obstacle" && col.gameObject.GetComponent<Obstacle>().enabled) {
			col.gameObject.GetComponent<Obstacle>().enabled = false;

			MainApplication.decCountLife();
			col.gameObject.AddComponent<Rigidbody>();
			Vector3 force = new Vector3(20, 0, 0);
			col.gameObject.rigidbody.AddForce(force);
		}
	}
}
