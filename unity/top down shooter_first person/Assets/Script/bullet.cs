using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	private float timer;

	void Start () {
		transform.position = player.bulletPos;
		transform.rotation = player.bulletRotation;
		timer = Time.time;
	}

	void FixedUpdate () {
		transform.Translate (Vector3.right * Time.deltaTime * 50);
		if (timer + 2 < Time.time) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.CompareTag("mop_1")) {
			Destroy(gameObject);
		};
	}
}
