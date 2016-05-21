using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Vector3 walkDirection;
	public float speed;
	void Update(){
		this.gameObject.transform.Translate (walkDirection * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag.Equals ("Player")) {
			SoundManager.instance.PlaySound (SoundManager.Sounds.Goomba);
			Destroy (gameObject);
		}	
	}
	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag.Equals("Player")){
			string enemyType = gameObject.tag;
			Debug.Log ("You were attacked by a " + enemyType + "!");
			c.gameObject.SendMessage ("Attacked", this.gameObject);
		}
	}
	public void GoBack(){
		walkDirection = walkDirection * -1f;
	}

    void Kill()
    {
        Destroy(gameObject);
    }
}
