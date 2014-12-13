using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	private const float OBSTACLE_TOP = 1.7f;
	private const float OBSTACLE_BOTT0M = -1.7f;

	public bool enabled = true;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private float getYPos() {
		if (Random.Range (0, 100) < 50) {
			return OBSTACLE_TOP;
		} else {
			return OBSTACLE_BOTT0M;
		}
	}

	public void Restore() {
		Destroy(this.gameObject.transform.GetComponent<Rigidbody>());
		this.enabled = true;
		this.gameObject.transform.rotation = Quaternion.identity;

		Vector3 obstaclePos = new Vector3 (0, 0, 0);
		obstaclePos.x = this.gameObject.transform.position.x * (-1);
		obstaclePos.y = this.getYPos();

		this.gameObject.transform.position = obstaclePos;
	}

	public void Init() {
		Vector3 obstaclePos = new Vector3 (0, 0, 0);
		obstaclePos.y = getYPos ();
		this.gameObject.transform.position = obstaclePos;
		this.gameObject.name = "Obstacle";
	}
}
