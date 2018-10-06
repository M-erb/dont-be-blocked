using UnityEngine;

public class PlayerMovment : MonoBehaviour {

	public Rigidbody rb;
	public Transform camera;
	public float forwardForce = 1000f;
	public float sidewaysForce = 100f;

	//Use this for initialization

	//void Start () {
	//	rb.AddForce(0, 200, 5000);
	//}

	// Used with Physics. Is called once per frame
	void FixedUpdate () {
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d")) {
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a")) {
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager>().EndGame("You fell off DUDE!");
		}

	}

}
