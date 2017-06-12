using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

	int poeni = 0;

	bool lost = false;

	public Text score;
	public Text gameover;
	public Text won; 

	// Use this for initialization
	void Start () {
		gameover.enabled = false;
		won.enabled = false;

		score.text = "Bookings missed: " + poeni;
		Debug.Log ("ziv");

		InvokeRepeating("scorehandle", 0, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R))
			restartCurrentScene ();
	}

	void scorehandle() {
		if(!lost) poeni += 1;
		score.text = "Bookings missed: " + poeni;
	}

	void OnControllerColliderHit (ControllerColliderHit col) {
		if (col.collider.gameObject.name == "floor") GameOver();
		if (col.collider.gameObject.name == "win") Win();
	
	}

	void GameOver() {
		gameover.enabled = true;
		lost = true;
	}

	void Win() {
		if (!lost) {
			won.enabled = true;
		}
	}

	public void restartCurrentScene(){
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
	}
}
