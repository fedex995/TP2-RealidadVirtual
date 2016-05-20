using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		Debug.Log ("You got a coin!");
		c.gameObject.SendMessage ("CollectedCoin");
		Destroy(this.gameObject);
	}
	void Update(){
		this.transform.Rotate (new Vector3 (0,2,0));
	}
}
