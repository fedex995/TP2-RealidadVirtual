using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Vertical");
		gameObject.transform.Translate (UtilityClass.walkDirection * speed * x * Time.deltaTime);

	}
}

