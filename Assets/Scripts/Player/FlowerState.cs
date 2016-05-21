using UnityEngine;
using System.Collections;

public class FlowerState : PlayerState
{

    private bool alreadyAttacked = false;

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
	public override void Attacked(GameObject enemy)
	{
	    if (alreadyAttacked)
	    {
	        player.ReduceLives();
	    } else alreadyAttacked = true;
	}

    public override void Fire()
    {
        var fireball = UtilityClass.instance.Fireball;
        GameObject createdFireball = GameObject.Instantiate(fireball, player.transform.position + player.transform.forward * 2f + player.transform.up * 1.5f, fireball.transform.rotation) as GameObject;
        createdFireball.GetComponent<Rigidbody>().AddForce(player.transform.forward * 700f);
		SoundManager.instance.PlaySound (SoundManager.Sounds.FireBall);
    }

    public override void SizeToNormal()
    {
        
    }
}
