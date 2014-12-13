using UnityEngine;
using System.Collections;

public class obstacleColisHandler : MonoBehaviour {
	static public int key;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	static public void setKey(int newKey) {
		key = newKey;
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Obstacle" || col.gameObject.name == "Cube") {
			gameObject.AddComponent<Rigidbody>();
			Vector3 force = new Vector3(20, 0, 0);
			gameObject.rigidbody.AddForce(force);
		}
	}
}
