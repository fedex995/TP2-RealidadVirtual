using UnityEngine;
using System.Collections;

public class TurnTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		if(c.gameObject.tag.Equals("Player")){
			c.gameObject.SendMessage ("YouCanTurn", this.gameObject.transform.position);
		}
	}
	void OnTriggerExit(Collider c){
		if(c.gameObject.tag.Equals("Player")){
			c.gameObject.SendMessage ("YouCantTurn");
		}
	}
}
