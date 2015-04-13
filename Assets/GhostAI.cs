using UnityEngine;
using System.Collections;
using System;
using Pathfinding;

 [RequireComponent (typeof (Rigidbody2D))]
 [RequireComponent (typeof (Seeker))]
public class GhostAI : MonoBehaviour {

	// What to chase.
	public Transform target;

	// How many times each second we will update our path
	public float updateRate = 2f;

	// Caching
	private Seeker seeker;
	private Rigidbody2D rb;

	//The calculated path
	public Path path;

	// The AI's speed per second
	public float speed = 300f;
	public ForceMode2D fMode;

	// The AI's Reach to a target, potential area of hitting.
	public float reach = 1.5f;
	private bool m_FacingRight = true;  // For determining which way the player is currently facing.

	[HideInInspector]
	public bool pathIsEnded = false;

	// Tha max distance from the AI to a waypoint for it to continue to the next waypoint
	public float nextWaypointDistance = 3;

	// The waypoint we are currently moving towards
	private int currentWaypoint;

	// Health.
	public float health = 10f;
	
	void Start () {

		seeker = GetComponent<Seeker> ();
		rb = GetComponent<Rigidbody2D> ();

		if (target == null) {
			Debug.LogError ("No Player found for GhostAI.");
			return;
		}

		//Start a new path to the target position and return the result
		// to the OnPathComplete Method
		seeker.StartPath (transform.position, target.position, OnPathComplete);

		StartCoroutine (UpdatePath ());
	}

	IEnumerator UpdatePath () {
		if (target == null) {
			// Insert a player search.
			return false;
		}

		seeker.StartPath (transform.position, target.position, OnPathComplete);

		yield return new WaitForSeconds (1f / updateRate);
		StartCoroutine (UpdatePath ());
	}

	public void OnPathComplete (Path p) {
		// Debug.Log ("Path Successful -> " + p.error);
		if (!p.error) {
			path = p;
			currentWaypoint = 0;
		}
	}

	void FixedUpdate () { 
		if (target == null) {
			return;
		}

		//TODO: Always look at player

		if (path == null) { 
			return ;
		}

		if (currentWaypoint >= path.vectorPath.Count) { 
			if (pathIsEnded)
				return;

			// Debug.Log ("End of path reached.");
			pathIsEnded = true;
			return;
		}

		pathIsEnded = false;
		// direction to next waypoint
		Vector3 dir = (path.vectorPath [currentWaypoint] - transform.position);
		dir.z = 0;
		//dir.y = 0;
		if (Math.Abs(dir.x) < reach ) {
			dir.x = 0;
		} else {
			dir.x /= Math.Abs (dir.x); //dir.normalized;
			dir *= speed * Time.fixedDeltaTime;
		}
		// Debug.Log ("x = " + dir.x + " y= " + dir.y + " z= " + dir.z);
		//Move the AI
		rb.AddForce (dir, fMode);
		float dist = Vector3.Distance (transform.position, path.vectorPath [currentWaypoint]);
		if (dist < nextWaypointDistance) {
			currentWaypoint++;
			return;
		}
		// If the input is moving the player right and the player is facing left...
		if (dir.x > 0 && !m_FacingRight) {
			// ... flip the player.
			Flip ();
		}
		// Otherwise if the input is moving the player left and the player is facing right...
		else if (dir.x < 0 && m_FacingRight) {
			// ... flip the player.
			Flip ();
		}

	}

	private void Flip()
	{
		// Switch the way the player is labelled as facing.
		m_FacingRight = !m_FacingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void OnCollisionEnter (Collision col) {
		Debug.Log ("Collsion.");
		if (col.gameObject.tag == "Weapon") {
			health -= 10;
			Debug.Log("Collision Hit.");
			if (health <= 0) {
				Destroy (this.gameObject);
			}
		}
	}

	void OnTriggerEnter (Collider col) {
		Debug.Log ("Collsion Trigger.");
//		if (col.gameObject.tag == "Weapon") {
//			health -= 10;
//			Debug.Log("Collision Hit.");
//			if (health <= 0) {
//				Destroy (this.gameObject);
//			}
//		}

	}
}















