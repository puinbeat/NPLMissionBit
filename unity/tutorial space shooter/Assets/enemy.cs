using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	public float negPointTwoThree = -0.23f;
	public float currentSpeed;
	public GameObject enemyFab;

	// Use this for initialization
	void Start () {
		currentSpeed = Random.Range (2, 18);		
		transform.position = new Vector3 (Random.Range(-16.0f, 16.0f), 0, 22);
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, negPointTwoThree, transform.position.z - currentSpeed * Time.deltaTime);
		if(transform.position.z < -3.5) {
			transform.position = new Vector3 (Random.Range(-16.0f, 16.0f), 0, 22);
		}
	}

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.CompareTag("bulletFab") ||collider.gameObject.CompareTag("Player")) {
			transform.position = new Vector3 (Random.Range(-16.0f, 16.0f), 0, 22);
		}
	}

}
