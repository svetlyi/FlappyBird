using UnityEngine;
using System.Collections;

public class MainApplication : MonoBehaviour {
	static private int countLife = 3;

	private const int OBJ_COUNT = 5;
	private const float OBSTACLE_TOP = 1.7f;
	private const float OBSTACLE_BOTT0M = -1.7f;
	private GameObject[] obstacles = new GameObject[5];
	private int score = 0;

	public GameObject prefab;
	public float speed = 0.09f;

	// Use this for initialization
	void Start () {
		Vector3 newPos = new Vector3 (0, 0, 0);
		for (int i=0; i<OBJ_COUNT; i++) {
			newPos.y = getYPos();
			newPos.x = i*3.6f;
				//on future
				//Vector3 newPos = new Vector3 (Random.Range (-4.0F, 2.0F), 4, Random.Range (-8.0F, 0F));
			GameObject newobj = Instantiate (this.prefab, newPos, transform.rotation) as GameObject;
			newobj.name = "Obstacle";
			obstacles[i] = newobj;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (countLife > 0) {
			Vector3 oldObjPos;

			foreach (GameObject obstacle in obstacles) {
				if (obstacle != null) {
					oldObjPos = obstacle.transform.position;
					if (oldObjPos.x < -9) {
						oldObjPos.x = oldObjPos.x * (-1);
						oldObjPos.y = getYPos ();
						this.score++;
					}
					oldObjPos.x -= speed;
					obstacle.transform.position = oldObjPos;
				}
			}
			speed += 0.00001f;
		}
	}

	private float getYPos() {
		if (Random.Range (0, 100) < 50) {
			return OBSTACLE_TOP;
		} else {
			return OBSTACLE_BOTT0M;
		}
	}

	static public void decCountLife() {
		countLife--;
	}

	void OnGUI() {
		Rect rect = new Rect (10,10,150,100);
		if (countLife > 0) {
			GUI.Label (rect, "Count life: " + countLife);
		} else {
			GUI.Label (rect, "GameOver. Score: " + this.score);
		}
	}
}
