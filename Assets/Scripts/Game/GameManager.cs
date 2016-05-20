using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public Camera camera;
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
	public void ChangePlayerSize(Vector3 vector){
		camera.transform.position += vector;
	}
}
