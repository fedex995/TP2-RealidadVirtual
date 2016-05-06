using UnityEngine;
using System.Collections;

public abstract class PlayerState {

	public float speed;
	public float jumpForce;
	protected Player player;
	protected PlayerMovement movement;

	public abstract void jump ();
	public abstract void move ();
	public abstract void attacked ();
	public PlayerState(PlayerMovement movement) {
		this.movement = movement;
	}

}
