using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		string powerType = gameObject.tag;
		Debug.Log ("You got a " + powerType + "!");
		c.gameObject.SendMessage ("Collected" + powerType);
	}
}	
