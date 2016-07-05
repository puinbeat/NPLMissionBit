using UnityEngine;
using System.Collections;

public class player_iso : MonoBehaviour {

	float pointOne = 0.1f;
	public GameObject shadow1;
	public GameObject bulletFab;
	public GameObject gunHead;
	public Vector3 mousePos;
	public GameObject skillRFab;
	public static Vector3 bulletPos;
	float bulletTimer;
	float timerE;
	bool castE = true;
	bool firstE = true;
	float timerR;
	public static bool castR = true;
	public static bool destroyR = false;


	void Start () {
		bulletTimer = Time.time;
		shadow1.transform.position = new Vector3 (0, -2, 0);
	}

	void FixedUpdate () {
		
		bulletPos = new Vector3 (gunHead.transform.position.x, gunHead.transform.position.y, gunHead.transform.position.z);

		// movement
		if (Input.GetKey(KeyCode.D)) {
			transform.position = new Vector3 (transform.position.x + pointOne, transform.position.y, transform.position.z);
		};
		if (Input.GetKey(KeyCode.A)) {
			transform.position = new Vector3 (transform.position.x - pointOne, transform.position.y, transform.position.z);
		};
		if (Input.GetKey(KeyCode.W)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + pointOne);
		};
		if (Input.GetKey(KeyCode.S)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - pointOne);
		};

		// rotation
		mousePos = Input.mousePosition;
		mousePos.z = 10;
		mousePos = Camera.main.ScreenToWorldPoint (mousePos);
		Vector3 heightCorrectedPoint = new Vector3 (mousePos.x,  transform.position.y, mousePos.z);
		transform.LookAt (heightCorrectedPoint);

//		if (Input.GetKey(KeyCode.RightArrow)) {
//			transform.eulerAngles = new Vector3 (0, 0, 0);
////			bulletPos = new Vector3 (transform.position.x + 1.1f, 0.43f, transform.position.z - 0.5f);
//		};
//		if (Input.GetKey(KeyCode.DownArrow)) {
//			transform.eulerAngles = new Vector3 (0, 90, 0);
//		};
//		if (Input.GetKey(KeyCode.LeftArrow)) {
//			transform.eulerAngles = new Vector3 (0, 180, 0);
//		};
//		if (Input.GetKey(KeyCode.UpArrow)) {
//			transform.eulerAngles = new Vector3 (0, 270, 0);
//		};
//		if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)) {
//			transform.eulerAngles = new Vector3 (0, 315, 0);
//		};
//		if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow)) {
//			transform.eulerAngles = new Vector3 (0, 45, 0);
//		};
//		if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)) {
//			transform.eulerAngles = new Vector3 (0, 135, 0);
//		};
//		if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow)) {
//			transform.eulerAngles = new Vector3 (0, 225, 0);
//		};

		// skill Q
		if (Input.GetKeyDown(KeyCode.Q) && Input.GetKey(KeyCode.D)) {
			transform.position = new Vector3 (transform.position.x + 3, transform.position.y, transform.position.z);
		};
		if (Input.GetKeyDown(KeyCode.Q) && Input.GetKey(KeyCode.A)) {
			transform.position = new Vector3 (transform.position.x - 3, transform.position.y, transform.position.z);
		};
		if (Input.GetKeyDown(KeyCode.Q) && Input.GetKey(KeyCode.W)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 3);
		};
		if (Input.GetKeyDown(KeyCode.Q) && Input.GetKey(KeyCode.S)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 3);
		};

		// skill E
		if (Input.GetKeyDown(KeyCode.E) && firstE == true && castE == true) {
			shadow1.transform.position = transform.position;
			firstE = false;
			timerE = Time.time;
		};
		if (Input.GetKey(KeyCode.E) && firstE == false && castE == true && timerE + 0.5 < Time.time) {
//			transform.position = shadow1.transform.position;
			transform.position = Vector3.MoveTowards (transform.position, shadow1.transform.position, Time.deltaTime * 10);
		};
		if (Input.GetKeyUp (KeyCode.E) && firstE == false && castE == true && timerE + 0.5 < Time.time) {
			firstE = true;
			castE = false;
			shadow1.transform.position = new Vector3 (0, -2, 0);
		};
		if (timerE + 4 < Time.time) {
			firstE = true;
			castE = true;
			shadow1.transform.position = new Vector3 (0, -2, 0);
		};

		// skill R
		if (Input.GetKeyDown(KeyCode.R) && castR == false && timerR + 0.1 < Time.time) {
			transform.position = GameObject.Find("skillRFab(Clone)").transform.position;
			castR = true;
			destroyR = true;
			timerR = Time.time;
		};

		// Instantiate
		if (Input.GetKey(KeyCode.Space) && bulletTimer + 0.1 < Time.time) {
			Instantiate (bulletFab, transform.position, transform.rotation);
			bulletTimer = Time.time;
		};
		if (Input.GetKeyDown(KeyCode.R) && castR == true && timerR + 0.1 < Time.time) {
			Instantiate (skillRFab, transform.position, transform.rotation);
			castR = false;
			destroyR = false;
			timerR = Time.time;
		};
		Debug.Log (mousePos);
	}
}
