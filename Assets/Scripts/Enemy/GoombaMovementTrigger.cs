using UnityEngine;
using System.Collections;

public class GoombaMovementTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		if(c.gameObject.tag.Equals("Goomba")){
			c.gameObject.SendMessage ("GoBack");
		}
	}
}

