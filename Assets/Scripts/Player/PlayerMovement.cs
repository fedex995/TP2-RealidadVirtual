using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody rigidbody;
	private bool grounded;
	// Use this for initialization
	void Start () {
		rigidbody = gameObject.GetComponent<Rigidbody> ();
		grounded = true;
	}

	// Update is called once per frame
	void Update () {

		bool leftTurn = Input.GetButtonDown ("LeftBumper");
		bool rightTurn = Input.GetButtonDown ("RightBumper");

		if (leftTurn) {
			//UtilityClass.instance.turnLeft ();
			gameObject.transform.Rotate (0, -90, 0);
		}
		if (rightTurn) {
			//UtilityClass.instance.turnRight ();
			gameObject.transform.Rotate (0, 90, 0);
		}

	}

	void OnCollisionEnter(Collision c){
		if(c.gameObject.layer == LayerMask.NameToLayer("Floor")){
			grounded = true;
		}
	}

	void OnCollisionExit(Collision c){
		if(c.gameObject.layer == LayerMask.NameToLayer("Floor")){
			grounded = false;
		}
	}

	public void jump(float jumpForce){
		if (grounded) {
			Debug.Log ("jump!!");
			rigidbody.AddForceAtPosition (Vector3.up * jumpForce, Vector3.zero);
		}
	}
	public void move(float speed){
		float x = Input.GetAxis ("Vertical");
		gameObject.transform.Translate (UtilityClass.instance.walkDirection * speed * x * Time.deltaTime);
	}
}

