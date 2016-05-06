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

	public void turnLeft(){
		walkDirection = Quaternion.Euler(0, -90, 0) * walkDirection;
	}
	public void turnRight(){
		walkDirection = Quaternion.Euler(0, 90, 0) * walkDirection;
	}
}