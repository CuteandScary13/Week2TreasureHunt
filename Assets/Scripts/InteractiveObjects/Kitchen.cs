using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Kitchen : MonoBehaviour {

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
			captureMessage.text = "There is nothing in the Kitchen. I believe there is an other landline upstairs.";


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
