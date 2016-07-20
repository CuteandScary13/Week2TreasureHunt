using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinCon : MonoBehaviour {

	public Text message;
	public Transform player;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((player.position - transform.position).magnitude < 5f) {
			message.text = "Hoorah!";
		}
	}
}
