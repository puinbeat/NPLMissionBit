using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public float negPointTwoThree = -0.23f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.up * Time.deltaTime * 50);

		if (transform.position.z >= 18) {
			Destroy (gameObject);
		}
	
	}

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.CompareTag("enemyFab")) {
			player.score += 10;
			Destroy (this.gameObject);
		}
	}
}
