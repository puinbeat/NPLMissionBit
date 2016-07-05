using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

	public GameObject player;
	Vector3 rotation;

	void Start () {
		
	}
	void Update () {
		transform.position = new Vector3 (player.transform.position.x - 0.08f, player.transform.position.y + 0.7f, player.transform.position.z - 0.3f);
		transform.eulerAngles = new Vector3 (player.transform.rotation.x, 1.7f, player.transform.rotation.z);
/*		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate (0, + 10, 0);
		};
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Rotate (0, 0, - 10);
		};
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate (0, - 10, 0);
		};
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Rotate (0, 0, + 10);
		};
*/
	}
}
