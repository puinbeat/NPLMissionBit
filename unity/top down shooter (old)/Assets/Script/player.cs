using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	float pointOne = 0.1f;

	void Start () {
	
	}

	void FixedUpdate () {
		transform.Translate (Vector3.right * Input.GetAxisRaw ("Horizontal") * Time.deltaTime * 5);
		if(Input.GetKey(KeyCode.UpArrow)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + pointOne);
		};
		if(Input.GetKey(KeyCode.DownArrow)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - pointOne);
		};
	}
}
