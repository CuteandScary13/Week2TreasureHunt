﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UseStaticStair : MonoBehaviour {

	public Text captureMessage;
	public Transform player;
	public float placementReference = 5f;
	//public GameObject textBox;
	//Take coordinates from Unity, instead of having to write new scripts for each stair case.
	public float xcord;
	public float ycord;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ((player.position - transform.position).magnitude < placementReference) {
			//enableTextBox();
			captureMessage.text = "Press [SPACE] to go up the stairs.";
			if (Input.GetKeyDown (KeyCode.Space)) {
				player.position = new Vector3 (xcord, ycord, 1);				
			}


		} else {
			//disableTextBox();
			captureMessage.text = "";
		}


	}
//	public void enableTextBox(){
//		textBox.SetActive (true);
//	}
//	public void disableTextBox(){
//		textBox.SetActive (false);
//
//	}

}
