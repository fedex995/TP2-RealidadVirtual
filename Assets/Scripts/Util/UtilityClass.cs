﻿using UnityEngine;
using System.Collections;

public class UtilityClass : MonoBehaviour {

	public static UtilityClass instance;
	public Player player;

	void Awake(){
		if (!instance) {
			instance = this;
		} else {
			Destroy (this);
		}
	}

	public Vector3 walkDirection;

	public void turn(bool direction){
		if (direction) {
			player.gameObject.transform.Rotate (0, 90, 0);
		} else {
			player.gameObject.transform.Rotate (0, -90, 0);
		}
	}

	public void setPlayerFading(){
		player.GetComponent<PlayerMovement> ().setFading (false);
	}
}