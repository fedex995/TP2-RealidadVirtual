using UnityEngine;
using System.Collections;

public class NormalState : PlayerState {

	public NormalState(Player player) : base(player.GetComponent<PlayerMovement>()){
		this.player = player;
		speed = 10;
		jumpForce = 400;
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
