using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovment movement;
	public float bounceUpForce = 5f;
	public float bounceBackForce = -3f;
	
	void OnCollisionEnter(Collision collisionInfo) {
		if (collisionInfo.collider.tag == "Obstacle") {
			movement.rb.AddForce(0, bounceUpForce, bounceBackForce, ForceMode.VelocityChange);
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame("");
		}
	}

}
