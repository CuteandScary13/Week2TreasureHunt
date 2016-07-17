using UnityEngine;
using System.Collections;

public class PlayerCameraFollow : MonoBehaviour {
	private char lastButtonPressed;
	public Vector3 offset;
	public int offsetUp;
	public int offsetDown;
	public float offsetSpeed;
	void Update () {
		Camera.main.transform.position = transform.position + offset;


		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			lastButtonPressed = 'S';
		} else if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			lastButtonPressed = 'W';
		}
		if (lastButtonPressed == 'S') {
			if (offset.y < offsetDown == false) {
				offset -= new Vector3 (0, offsetSpeed , 0);
			}
		} else if (lastButtonPressed == 'W') {
			if (offset.y > offsetUp == false) {
				offset += new Vector3 (0, offsetSpeed, 0);
			}
		}
	}
}
