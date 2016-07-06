using UnityEngine;
using System.Collections;

public class cameraMovement_iso : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + 11, player.transform.position.z - 4);
	}
}
