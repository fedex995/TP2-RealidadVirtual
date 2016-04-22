using UnityEngine;
using System.Collections;

public class UtilityClass : MonoBehaviour {

	public static UtilityClass instance;

	void Awake(){
		if (!instance) {
			instance = this;
		} else {
			Destroy (this);
		}
	}

	public Vector3 walkDirection;

}