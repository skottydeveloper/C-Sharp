using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// Destroy the player if it collides with a UFO
/// 
/// </summary>

public class PlayerExplode : MonoBehaviour {

	public ParticleSystem explosionPrefab;	// an explosion particle effect to play
	public LayerMask hitLayer = -1;	// the layer that contains UFOs and their bullets

	// Handle collisions
	// This method is called whenever the object collides with another

	public void OnCollisionEnter2D(Collision2D collision) {

		// check if we collided with a UFO
		if (IsHit(collision.gameObject)) {

			// if an explosion prefab has been given, 
			// create an instance at our current location

			if (explosionPrefab != null) {
				ParticleSystem explosion = Instantiate(explosionPrefab);
				explosion.transform.position = transform.position;
			}
				
			// Destroy the ship
			gameObject.SetActive(false);
		}
	}
		
	// Test if a collision will cause an explosion by checking the layermask
	private bool IsHit(GameObject gameObject) {
		return (hitLayer.value & (1 << gameObject.layer)) != 0;
	}

}
