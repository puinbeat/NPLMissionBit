using UnityEngine;
using System.Collections;

public class mop_1 : MonoBehaviour {

	float timer;
	private bool alive = true;
	public GameObject player;
	Vector3 thisPos;

	void Start () {
		timer = Time.time;
		transform.position = new Vector3 (Random.Range (player.transform.position.x - 6, player.transform.position.x + 6), -3, Random.Range(player.transform.position.x - 6, player.transform.position.x + 6));
	}

	void Update () {
//		if (timer + 2 < Time.time && alive == false) {
//			transform.position = new Vector3 (Random.Range (player.transform.position.x - 6, player.transform.position.x + 6), -3, Random.Range(player.transform.position.x - 6, player.transform.position.x + 6));
//			alive = true;
//		};
//		if (alive == true) {
//			transform.position = Vector3.MoveTowards (transform.position, player.transform.position, Time.deltaTime * 2);
//		};
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.CompareTag ("bulletFab")) {
//			gameObject.GetComponent<MeshRenderer>.enabled = false;
//			transform.position = new Vector3 (0, -2, 0);
			alive = false;
			timer = Time.time;
		};
	}
}
