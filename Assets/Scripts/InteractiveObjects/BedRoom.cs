using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BedRoom : MonoBehaviour {

	//bool didPlayerWin = false;
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
			captureMessage.text = "This phone is not working either, and my cellphone is out of battery. I swear there should be a working phone upstairs.";


		} else {
			disableTextBox();
			captureMessage.text = "";
		}



	}
	public void enableTextBox(){
		textBox.SetActive (true);
	}
	public void disableTextBox(){
		textBox.SetActive (false);

	}
}
