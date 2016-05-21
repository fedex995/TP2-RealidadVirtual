using UnityEngine;
using System.Collections;

public abstract class PlayerState {

	public float speed;
	public float jumpForce;
	protected Player player;
	protected PlayerMovement movement;

	public abstract void Jump ();
	public abstract void Move ();
	public abstract void Attacked (GameObject enemy);
	public abstract void Fire ();
	public PlayerState(PlayerMovement movement) {
		this.movement = movement;
	}

    public abstract void SizeToNormal();
}
