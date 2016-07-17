using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GroundFloorPhone : MonoBehaviour {

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
			captureMessage.text = "This phone doesn't seem to work. Maybe there is something in the kitchen I can use.";


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
