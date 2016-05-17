using UnityEngine;
using System.Collections;

public class NormalState : PlayerState {

	public NormalState(Player player) : base(player.GetComponent<PlayerMovement>()){
		this.player = player;
		speed = 10;
		jumpForce = 400;
	}

	public override void Jump(){
		movement.jump (jumpForce);
	}
	public override void Move(){
		movement.move (speed);
	}
	public override void Attacked(){

    }

    public override void Fire() { }

}
