using UnityEngine;
using System.Collections;

public class shadow1 : MonoBehaviour {

	public GameObject player;
	public float timer;

	void Start () {
		transform.position = new Vector3 (player.transform.position.x, 0, player.transform.position.z);
		timer = Time.time;
	}

	void FixedUpdate () {
//		transform.position = new Vector3 (player.transform.position.x, 0, player.transform.position.z);
//		if(Input.GetKeyDown(KeyCode.Space)) {
//			float pX = player.transform.position.x;
//			float pZ = player.transform.position.z;
//			Vector3 newPos = new Vector3 (player.transform.position.x, 0, player.transform.position.z);
//			gameObject.transform.position = newPos;
//		};
		if (timer + 0.2 < Time.time) {
			transform.position = new Vector3 (player.transform.position.x, 0, player.transform.position.z);
			timer = Time.time;
		};
	}
}
