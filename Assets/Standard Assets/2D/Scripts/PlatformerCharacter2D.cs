using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class PlatformerCharacter2D : MonoBehaviour
    {
        [SerializeField] private float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
        [SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.
        [Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;  // Amount of maxSpeed applied to crouching movement. 1 = 100%
        [SerializeField] private bool m_AirControl = false;                 // Whether or not a player can steer while jumping;
        [SerializeField] private LayerMask m_WhatIsGround;                  // A mask determining what is ground to the character.
        private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.
        const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
        private bool m_Grounded;            // Whether or not the player is grounded.
        private Transform m_CeilingCheck;   // A position marking where to check for ceilings
        const float k_CeilingRadius = .01f; // Radius of the overlap circle to determine if the player can stand up
		private Transform m_MeleeCheck;     // Takes the hit box for the melee attack.
		private bool melee = false;
		[SerializeField] private float melee_range = 10f;   // Changes the length of the hit box.
        private Animator m_Anim;            // Reference to the player's animator component.
        private Rigidbody2D m_Rigidbody2D;
        private bool m_FacingRight = true;  // For determining which way the player is currently facing.

		// Weapon statistics.
		public float fireRate = 100f;
		public float Damage = 10;
		public LayerMask ToHit; // Stores the layers to hit
		private float timeToFire = 0;
		Transform firePoint;
		private float slowDuringAttack = 1f;

		// Character stats.
		private float health = 10f;

        private void Awake()
        {
            // Setting up references.
            m_GroundCheck = transform.Find("GroundCheck");
            m_CeilingCheck = transform.Find("CeilingCheck");
			m_MeleeCheck = transform.Find ("MeleeCheck");
            m_Anim = GetComponent<Animator>();
            m_Rigidbody2D = GetComponent<Rigidbody2D>();
        }


        private void FixedUpdate()
        {
            m_Grounded = false;

            // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
            // This can be done using layers instead but Sample Assets will not overwrite your project settings.
            Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject != gameObject)
                    m_Grounded = true;
            }

            m_Anim.SetBool("Ground", m_Grounded);

            // Set the vertical animation
            m_Anim.SetFloat("vSpeed", m_Rigidbody2D.velocity.y);

			// Stops the animation after one swing.
			if (this.m_Anim.GetCurrentAnimatorStateInfo (0).IsName ("PlayerMelee")) {
				// http://answers.unity3d.com/questions/362629/how-can-i-check-if-an-animation-is-being-played-or.html
				melee = false;
			}

			m_Anim.SetBool ("MeleeAttack", melee);

			//m_Anim.g
			if (Input.GetKey(KeyCode.Y)
			    || Input.GetButtonDown("Jump")
			    && Time.time > timeToFire
			    && m_Grounded
			    )
			{
					timeToFire = Time.time + 1/fireRate;
					// Debug.Log ("Swinging");
					// Debug.Log ("Swing: " + timeToFire + " time=" + Time.time + " fireRate= " + fireRate);
					Swing();
			}


        }


        public void Move(float move, bool crouch, bool jump)
        {
            // If crouching, check to see if the character can stand up
            if (!crouch && m_Anim.GetBool("Crouch"))
            {
                // If the character has a ceiling preventing them from standing up, keep them crouching
                if (Physics2D.OverlapCircle(m_CeilingCheck.position, k_CeilingRadius, m_WhatIsGround))
                {
                    crouch = true;
                }
            }

            // Set whether or not the character is crouching in the animator
            m_Anim.SetBool("Crouch", crouch);

            //only control the player if grounded or airControl is turned on
            if (m_Grounded || m_AirControl)
            {
                // Reduce the speed if crouching by the crouchSpeed multiplier
                move = (crouch ? move*m_CrouchSpeed : move);

                // The Speed animator parameter is set to the absolute value of the horizontal input.
                m_Anim.SetFloat("Speed", Mathf.Abs(move));

				if (melee) { 
					slowDuringAttack = .25f;
				} else {
					slowDuringAttack = 1f;
				}
                // Move the character
                m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed*slowDuringAttack,
				                                     m_Rigidbody2D.velocity.y);

                // If the input is moving the player right and the player is facing left...
                if (move > 0 && !m_FacingRight)
                {
                    // ... flip the player.
                    Flip();
                }
                    // Otherwise if the input is moving the player left and the player is facing right...
                else if (move < 0 && m_FacingRight)
                {
                    // ... flip the player.
                    Flip();
                }
            }
            // If the player should jump...
            if (m_Grounded && jump && m_Anim.GetBool("Ground"))
            {
                // Add a vertical force to the player.
                m_Grounded = false;
                m_Anim.SetBool("Ground", false);
                m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
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

		private void Swing () {
			//m_MeleeCheck.wrapMode = WrapMode.Once;
			m_Anim.Play("PlayerMelee");
			// melee = true;
			// Debug.Log("Swinging.");
		}

		void OnTriggerEnter (Collider col) {
			Debug.Log ("Collsion Main Trigger.");
			//		if (col.gameObject.tag == "Weapon") {
			//			health -= 10;
			//			Debug.Log("Collision Hit.");
			//			if (health <= 0) {
			//				Destroy (this.gameObject);
			//			}
			//		}
			
		}
    }
}
