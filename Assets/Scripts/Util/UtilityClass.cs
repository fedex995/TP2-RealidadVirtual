using UnityEngine;
using System.Collections;

public class UtilityClass : MonoBehaviour {

	public static UtilityClass instance;
	public Player player;
    [SerializeField] private GameObject fireball;

    public GameObject Fireball { get { return this.fireball; } }

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
		Vector3 newPosition = player.getTurnPosition ();
		newPosition.y = player.transform.position.y;
		player.transform.position = newPosition;
	}

	public void setPlayerFading(){
		player.GetComponent<PlayerMovement> ().setFading (false);
	}
}