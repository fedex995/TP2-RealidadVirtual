using UnityEngine;
using System.Collections;

public class FlowerState : PlayerState {

	public FlowerState(Player player) : base(player.GetComponent<PlayerMovement>()){
		this.player = player;
		speed = 20;
		jumpForce = 500;
	}

	public override void jump(){
		movement.jump (jumpForce);
	}
	public override void move(){
		movement.move (speed);
	}
	public override void attacked(){

	}
}
