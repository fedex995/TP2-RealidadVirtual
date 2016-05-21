using UnityEngine;
using System.Collections;

public class StarState : PlayerState {

	public StarState(Player player, float speed, float jumpForce) : base(player.GetComponent<PlayerMovement>())
    {
        this.player = player;
        this.speed = speed;
        this.jumpForce = jumpForce;
		ChangePowerupCanvas ("Star");
		SoundManager.instance.StarSound ();
    }

    public override void Jump(){
		movement.jump (jumpForce);
	}
	public override void Move(){
		movement.move (speed);
	}
	public override void Attacked(GameObject enemy){
		enemy.SendMessage ("Kill");
    }

    public override void Fire() {}
    public override void SizeToNormal()
    {
        
    }

}
