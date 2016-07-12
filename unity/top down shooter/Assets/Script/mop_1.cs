using UnityEngine;
using System.Collections;

public class mop_1 : MonoBehaviour {


	void Start () {
		
	}

	void FixedUpdate () {
		transform.position = Vector3.MoveTowards (transform.position, player_iso.playerPosition, Time.deltaTime * 2);
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.CompareTag ("bulletFab")) {
			Destroy (this.gameObject);
			player_iso.spawEnemy -= 1;
		};
	}
}
