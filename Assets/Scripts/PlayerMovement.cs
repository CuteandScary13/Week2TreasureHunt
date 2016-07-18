using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public GameObject front;
	public GameObject back;
	public GameObject objective;
	private Rigidbody2D PlayerRB;
	public int playerSpeed = 500;
	public GameObject particles;
	// Use this for initialization
	void Start () {
		//Assign the player's rigid body to a variable
		PlayerRB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//disableParticles ();
		//We reset the velocity of the player so that it does not constantly grow to infinity.
		PlayerRB.velocity = new Vector2 (0, 0);
		//The player can use WASD or the arrow keys to move the player avatar around.
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			enableTextFrontBox ();
			disableTextBackBox ();
			disableObjective ();
			enableParticles ();
			PlayerRB.velocity += new Vector2 (0, playerSpeed)* Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			enableTextBackBox ();
			disableTextFrontBox ();
			disableObjective ();
			enableParticles ();
			PlayerRB.velocity += new Vector2 (0, -playerSpeed)* Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			disableObjective ();
			enableParticles ();
			PlayerRB.velocity += new Vector2 (playerSpeed, 0)* Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			disableObjective ();
			enableParticles ();
			PlayerRB.velocity += new Vector2 (-playerSpeed, 0)* Time.deltaTime;
		}
		//disableParticles ();
	}

	public void enableTextFrontBox(){
		front.SetActive (true);
	}
	public void disableTextFrontBox(){
		front.SetActive (false);

	}
	public void enableTextBackBox(){
		back.SetActive (true);
	}
	public void disableTextBackBox(){
		back.SetActive (false);

	}
	public void disableObjective(){
		objective.SetActive (false);
	}
	public void enableParticles(){
		particles.SetActive (true);
	}
	/*public void disableParticles(){
		particles.SetActive (false);
		Debug.Log ("test");
	}*/
}
