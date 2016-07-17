using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D PlayerRB;
	public int playerSpeed = 500;
	// Use this for initialization
	void Start () {
		//Assign the player's rigid body to a variable
		PlayerRB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//We reset the velocity of the player so that it does not constantly grow to infinity.
		PlayerRB.velocity = new Vector2 (0, 0);
		//The player can use WASD or the arrow keys to move the player avatar around.
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			PlayerRB.velocity += new Vector2 (0, playerSpeed)* Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			PlayerRB.velocity += new Vector2 (0, -playerSpeed)* Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			PlayerRB.velocity += new Vector2 (playerSpeed, 0)* Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			PlayerRB.velocity += new Vector2 (-playerSpeed, 0)* Time.deltaTime;
		}
	}
}
