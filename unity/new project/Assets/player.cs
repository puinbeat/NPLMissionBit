using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float pointOne = 0.1f;
	private float timer;

	void Start () {
		transform.position = new Vector3 (0, 1, 0);
	}

	void Update () {
		transform.Translate (Vector3.right * Input.GetAxis ("Horizontal"));
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + pointOne);
		};
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - pointOne);
		};
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.CompareTag ("cube")) {
			if () {
				
			};
		};
	}

}
