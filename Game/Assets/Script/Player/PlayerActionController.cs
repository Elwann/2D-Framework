using UnityEngine;
using System.Collections;

[AddComponentMenu("2D Framework/Player/Action Controller")]
public class PlayerActionController : MonoBehaviour {
	bool facingRight = true;							// For determining which way the player is currently facing.
	
	[SerializeField] float maxSpeed = 10f;				// The fastest the player can travel in the x axis.
	[SerializeField] float jumpForce = 400f;			// Amount of force added when the player jumps.	
	
	private UserInputAction userInput;
	private Animator anim;

	void Awake(){
		if(userInput == null){
			if(GetComponent<UserInputAction>() != null){
				userInput = gameObject.GetComponent<UserInputAction>();
			} else {
				userInput = gameObject.AddComponent<UserInputAction>();
			}
		}

		if(anim == null){
			if(GetComponent<Animator>() != null){
				anim = gameObject.GetComponent<Animator>();
			} else {
				anim = gameObject.AddComponent<Animator>();
			}
		}
	}

	void FixedUpdate (){
		float xMovement = userInput.Axis.x;
		float yMovement = userInput.Axis.y;

		// Setting the speed to the animator
		anim.SetFloat("Speed", Mathf.Abs(xMovement));

		Vector2 movements = Vector2.ClampMagnitude(new Vector2(xMovement * maxSpeed, yMovement * maxSpeed), maxSpeed);
		
		// Moving the caracter
		GetComponent<Rigidbody>().velocity = new Vector3(movements.x, GetComponent<Rigidbody>().velocity.y, movements.y);
		
		// Flip the if needed
		if(xMovement > 0 && !facingRight){
			Flip();
		} else if(xMovement < 0 && facingRight){
			Flip();
		}
	}
	
	
	void Flip (){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}