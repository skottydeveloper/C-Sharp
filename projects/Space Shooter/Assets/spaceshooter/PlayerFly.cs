using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// Allow the player to fly the sprite around the screen using keyboard or joystick control.
/// 
/// </summary>

// requries a Rigidbody2D for physics
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerFly : MonoBehaviour {

	public float speed = 5.0f; // the speed at which the ship moves

	private Rigidbody2D rigidbody; // the ship's rigidbody component

	void Start () {
		// get the rigidbody component and store it for later use
		rigidbody = GetComponent<Rigidbody2D>();

		// disable gravity
		rigidbody.gravityScale = 0;

		// disable rotation
		rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	
	void Update () {

		// get the controller values from the Input Manager
		// these are numbers between -1 and 1

		float vx = Input.GetAxis("Horizontal");
		float vy = Input.GetAxis("Vertical");

		// set the velocity of the ship by scaling the input vector
		// by the speed value

		rigidbody.velocity = new Vector2(vx, vy) * speed;
	}
}
