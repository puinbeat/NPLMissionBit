using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

	public GameObject player;

	void Start () {
		
	}
	void Update () {
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + 11, player.transform.position.z - 4);
	}
}
