using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	private float timer;

	void Start () {
		transform.position = player_iso.bulletPos;
		timer = Time.time;
	}

	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * 10);
		if (timer + 1 < Time.time) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.CompareTag("mop_1")) {
			Destroy(gameObject);
		};
	}
}
