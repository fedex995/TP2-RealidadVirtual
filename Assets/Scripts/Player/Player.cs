using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public PlayerState currentState;
	public int lives;
	// Use this for initialization
	void Start () {
		currentState = new NormalState (this);
	}
	
	// Update is called once per frame
	void Update () {
		currentState.move ();

		bool jump = Input.GetButtonDown ("Jump");
		if (jump) {
			currentState.jump ();
		}
	}

	public void CollectedMushroom(){
		currentState = new MushroomState (this);
	}
	public void CollectedStar(){
		currentState = new StarState (this);
	}
	public void CollectedFlower(){
		currentState = new FlowerState (this);
	}
	public void Attacked(){
		currentState.attacked ();
	}
}
