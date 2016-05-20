using UnityEngine;
using System.Collections;

public class FlowerState : PlayerState {

	public FlowerState(Player player, float speed, float jumpForce) : base(player.GetComponent<PlayerMovement>()){
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

	}

    public override void Fire()
    {
        var fireball = UtilityClass.instance.Fireball;
        GameObject createdFireball = GameObject.Instantiate(fireball, player.transform.position, fireball.transform.rotation) as GameObject;
    }
}
