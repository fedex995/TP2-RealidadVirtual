using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			string powerType = gameObject.tag;
			Debug.Log ("You got a " + powerType + "!");
			c.gameObject.SendMessage ("Collected" + powerType);

			switch (powerType) {
			case "Mushroom":
				SoundManager.instance.PlaySound (SoundManager.Sounds.Mushroom);
				break;

			default:
				break;

			}

			Destroy(this.gameObject);
		}

	}
}	
