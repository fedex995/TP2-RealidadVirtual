﻿using UnityEngine;
using System.Collections;

public class MushroomState : PlayerState {

	public MushroomState(Player player, float speed, float jumpForce) : base(player.GetComponent<PlayerMovement>())
    {
        this.player = player;
        this.speed = speed;
        this.jumpForce = jumpForce;
		GameManager.instance.ChangePlayerSize (new Vector3(0, 1, 0));
		ChangePowerupCanvas ("Mushroom");
    }

    public override void Jump(){
		movement.jump (jumpForce);
	}
	public override void Move(){
		movement.move (speed);
	}
	public override void Attacked(GameObject enemy){
		GameManager.instance.ChangePlayerSize (new Vector3(0, -1, 0));
		player.currentState = new NormalState (player, player.normalSpeed, player.normalJumpForce);
		GameManager.instance.ChangeCanvasPowerUp ("Normal");
    }

    public override void Fire() { }
    public override void SizeToNormal()
    {
        GameManager.instance.ChangePlayerSize(new Vector3(0, -1, 0));
    }
}
