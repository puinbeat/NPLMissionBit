using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public int playerSpeedHoriz = 25;
	public int playerSpeedVert = 10;
	float onePointTwo = 1.2f;
	public float negPointTwoThree = -0.23f;
	public GameObject player_gameObject;
	public GameObject bulletFab;
	public static int playerLives = 3;
	public static int score = 0;
	float realTime;
	private bool isDead = false;

	void Start () {

		transform.eulerAngles = new Vector3 (90, 0, 0);

		transform.position = new Vector3 (0, negPointTwoThree, 0);

	}

	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeedHoriz);

		transform.Translate (Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * playerSpeedVert);

		if (transform.position.x > 17) {
			transform.position = new Vector3 (-16, transform.position.y, transform.position.z);
		}

		if (transform.position.x < -17) {
			transform.position = new Vector3 (16, transform.position.y, transform.position.z);
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			Vector3 pPosition = new Vector3 (transform.position.x, transform.position.y , transform.position.z + onePointTwo);
			Instantiate (bulletFab, pPosition, Quaternion.AngleAxis(90, Vector3.right));
		}

		if (Time.time - realTime > 1 && isDead == true) {
			transform.position = new Vector3 (0, negPointTwoThree, 0);
			isDead = false;
		}

		print("score = " + player.score + "   |   " + "lives = " + playerLives);

/*		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position = new Vector3 (transform.position.x + 10 * Time.deltaTime, transform.position.y, transform.position.z);
			transform.eulerAngles = new Vector3 (60, 270, 270);
		} else {
			transform.eulerAngles = new Vector3 (90, 0, 0);
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.position = new Vector3 (transform.position.x - 10 * Time.deltaTime, transform.position.y, transform.position.z);
			transform.eulerAngles = new Vector3 (60, 90, 90);
		} else {
			transform.eulerAngles = new Vector3 (90, 0, 0);
		}*/

	}

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.CompareTag("enemyFab")) {
			playerLives--;
			isDead = true;
			transform.position = new Vector3 (0, transform.position.y, 100);
			realTime = Time.time;
			if(playerLives == 0) {
				Destroy (this.gameObject);
			}
		}
	}
}
