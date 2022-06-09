using UnityEngine;

public class Movement : MonoBehaviour
{

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	private float forwardForce = 500f;  // Variable that determines the forward force
	private float sidewaysForce = 20f;  // Variable that determines the sideways force

	// We marked this as "Fixed"Update because we
	// are using it to mess with physics.
	void FixedUpdate()
	{
		if (Input.GetKey("w")) {
			rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
		if (Input.GetKey("s")) {
			rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
		}

		if (Input.GetKey("d"))  // If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -2f)
        {
			FindObjectOfType<GameManager>().EndGame();
        }
	}
}

// player position-> translate-> new position-