using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag.Equals ("Player")) {
			Destroy (gameObject);
		}	
	}
	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag.Equals("Player")){
			string enemyType = gameObject.tag;
			Debug.Log ("You were attacked by a " + enemyType + "!");
			c.gameObject.SendMessage ("Attacked");
		}

	}
}
