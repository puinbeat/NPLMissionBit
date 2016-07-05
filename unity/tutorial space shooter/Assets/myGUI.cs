using UnityEngine;
using System.Collections;

public class myGUI : MonoBehaviour {

	void OnGUI() {
		GUI.Box (new Rect (1150, 800, 200, 50), "score = " + player.score + "   |   " + "lives = " + player.playerLives);
	}

}
