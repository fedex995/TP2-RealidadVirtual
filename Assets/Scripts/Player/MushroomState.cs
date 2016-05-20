﻿using UnityEngine;
using System.Collections;

public class MushroomState : PlayerState {

	public MushroomState(Player player, float speed, float jumpForce) : base(player.GetComponent<PlayerMovement>())
    {
        this.player = player;
        this.speed = speed;
        this.jumpForce = jumpForce;
    }

    public override void Jump(){
		movement.jump (jumpForce);
	}
	public override void Move(){
		movement.move (speed);
	}
	public override void Attacked(){
		player.currentState = new NormalState (player, player.normalSpeed, player.normalJumpForce);
    }

    public override void Fire() { }
}
