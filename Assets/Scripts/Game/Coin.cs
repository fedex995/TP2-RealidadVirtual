using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		Debug.Log ("You got a coin!");
		c.gameObject.SendMessage ("CollectedCoin");
		SoundManager.instance.PlaySound (SoundManager.Sounds.Coin);
		Destroy(this.gameObject);
	}
	void Update(){
		this.transform.Rotate (new Vector3 (0,2,0));
	}
}
