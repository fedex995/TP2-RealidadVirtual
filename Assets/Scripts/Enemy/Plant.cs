using UnityEngine;
using System.Collections;

public class Plant : MonoBehaviour {

	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag.Equals("Player")){
			string enemyType = gameObject.tag;
			Debug.Log ("You were attacked by a " + enemyType + "!");
			c.gameObject.SendMessage ("Attacked", this.gameObject);
		}
	}

	void Kill()
	{
		Destroy(gameObject);
	}
}
