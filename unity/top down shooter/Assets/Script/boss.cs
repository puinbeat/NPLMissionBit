//using UnityEngine;
//using System.Collections;
//
//public class boss : MonoBehaviour {
//
//	public GameObject player;
//	Vector3 newPPos;
//	float timer;
//
//	void Start () {
//		timer = Time.time;
//	
//	}
//
//	void Update () {
//		if (timer + 3 < Time.time) {
//			newPPos = new Vector3 (player.transform.position.x, 1.5f, player.transform.position.z);
//			timer = Time.time;
//		};
//		transform.position = Vector3.MoveTowards (transform.position, newPPos, Time.deltaTime * 2);
//	}
//}
