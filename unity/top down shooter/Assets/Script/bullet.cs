using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	private float timer;

	void Start () {
		transform.position = player_iso.bulletPos;
		timer = Time.time;
	}

	void FixedUpdate () {
		transform.Translate (Vector3.forward * 0.8f);
		if (timer + 1 < Time.time) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.CompareTag("mop_1")) {
			transform.position = new Vector3 (100, 100, 100);
//			Destroy(gameObject);
		};
	}
}
