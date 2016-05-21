using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody rigidbody;
	private Player player;
	private bool grounded;
	public Canvas canvas;
	bool fading = false;

	// Use this for initialization
	void Start () {
		rigidbody = gameObject.GetComponent<Rigidbody> ();
		grounded = true;
		player = gameObject.GetComponent<Player> ();
	}

	// Update is called once per frame
	void Update () {

		bool leftTurn = Input.GetButtonDown ("LeftBumper");
		bool rightTurn = Input.GetButtonDown ("RightBumper");

		if (leftTurn && !fading && player.canTurn()) {
			fading = true;
			canvas.GetComponent<FadeScreen>().startFadeIn(false);

		}
		if (rightTurn && !fading && player.canTurn()) {
			fading = true;
			canvas.GetComponent<FadeScreen>().startFadeIn(true);
		}

	}

	void OnCollisionEnter(Collision c)
	{
		if(c.gameObject.layer == LayerMask.NameToLayer("Floor")){
			grounded = true;
        }
	}

	void OnCollisionExit(Collision c)
    {
        if (c.gameObject.layer == LayerMask.NameToLayer("Floor")){
			grounded = false;
		}
	}

	public void jump(float jumpForce){
		if (grounded) {
			rigidbody.AddForceAtPosition (Vector3.up * jumpForce, Vector3.zero);
		}
	}
	public void move(float speed){
		float x = Input.GetAxis ("Vertical");
		gameObject.transform.Translate (UtilityClass.instance.walkDirection * speed * x * Time.deltaTime);
	}
	public void setFading(bool fading){
		this.fading = fading;
	}
    public bool Grounded { set { this.grounded = value; } }
}

