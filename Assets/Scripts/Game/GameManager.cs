using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public Canvas canvas;
	public Player player;

	void Awake(){
		if (!instance) {
			instance = this;
		} else {
			Destroy (this);
		}
	}
	public void EndGame(){
		canvas.GetComponent<FadeScreen>().StartFadeBlack();
		Debug.Log ("ended game");
	}

}
