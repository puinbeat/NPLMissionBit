using UnityEngine;
using System.Collections;

public class skillR_Holder: MonoBehaviour {

	float timer;
	public 

	void Start () {
		timer = Time.time;
	}

	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * 5);
		if (timer + 3 < Time.time) {
			Destroy (gameObject);
			player.castR = true;
		};
		if (player.destroyR == true) {
			Destroy (gameObject);
		};
	}
}
