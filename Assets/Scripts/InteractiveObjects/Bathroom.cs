using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bathroom : MonoBehaviour {

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
			captureMessage.text = "I don't need to go to the bathroom. Did I check my room? Maybe upstairs?";


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
