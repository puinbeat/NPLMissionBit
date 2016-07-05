using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public Vector3 mousePos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mousePos = Input.mousePosition;
		mousePos.z = 10;
		mousePos = Camera.main.ScreenToWorldPoint (mousePos);
		Vector3 heightCorrectedPoint = new Vector3 (mousePos.x,  transform.position.y, mousePos.z);
		transform.LookAt (heightCorrectedPoint);

		Debug.Log (mousePos);
	}
}
