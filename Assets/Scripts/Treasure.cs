﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Treasure : MonoBehaviour {

	bool didPlayerWin = false;
	public Text captureMessage;
	public Transform player;
	public float placementReference = 5f;
	public GameObject textBox;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if ((player.position - transform.position).magnitude < placementReference) {
			enableTextBox();
			captureMessage.text = "Press [SPACE] to get treasure and win!";
			if (Input.GetKeyDown (KeyCode.Space)) {
				didPlayerWin = true;
			}

		} else {
			disableTextBox();
			captureMessage.text = "";
		}
		if (didPlayerWin) {
			enableTextBox();
			captureMessage.text = "YOU GOT THE TREASURE! YOU WIN!";
		}

	
	}
	public void enableTextBox(){
		textBox.SetActive (true);
	}
	public void disableTextBox(){
		textBox.SetActive (false);

	}
}
