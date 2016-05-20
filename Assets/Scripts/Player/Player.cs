using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public PlayerState currentState;
	public int lives;
	private bool turn;
	private Vector3 turnPosition;
    public float normalSpeed;
    public float normalJumpForce;
    public float flowerSpeed;
    public float flowerJumpForce;
    public float mushroomSpeed;
    public float mushroomJumpForce;
    public float starSpeed;
    public float starJumpForce;
	private int coins;
    private Vector3 initialPosition;
    private Quaternion initialRotation;



	void Start ()
	{
	    initialPosition = transform.position;
	    initialRotation = transform.rotation;
	    currentState = new NormalState (this, normalSpeed, normalJumpForce);
		turn = false;
		coins = 0;
	}
	
	// Update is called once per frame
	void Update () {
		currentState.Move ();

		bool jump = Input.GetButtonDown ("Jump");
		if (jump) {
			currentState.Jump ();
		}

        bool fire = Input.GetButtonDown("Fire");
	    if (fire)
	    {
	        currentState.Fire();
	    }
	}

	public void CollectedMushroom(){
		currentState = new MushroomState (this, mushroomSpeed, mushroomJumpForce);
	}
	public void CollectedStar(){
		currentState = new StarState (this, starSpeed, starJumpForce);
	}
	public void CollectedFlower(){
		currentState = new FlowerState (this, flowerSpeed, flowerJumpForce);
	}
	public void Attacked(GameObject enemy){
		currentState.Attacked (enemy);
	}
	public void YouCanTurn(Vector3 position){
		turn = true;
		turnPosition = position;
	}
	public void YouCantTurn(){
		turn = false;
	}
	public bool canTurn(){
		return turn;
	}
	public Vector3 getTurnPosition (){
		return turnPosition;
	}
	public void ReduceLives(){
		lives--;
		GameManager.instance.RemoveLive (lives);
	    if (lives == 0)
	    {
	        GameManager.instance.EndGame();
	    }
	    else
	    {
	        transform.position = initialPosition;
	        transform.rotation = initialRotation;
	    }
	}
	public void CollectedCoin(){
		coins++;
		GameManager.instance.CoinCount (coins);
	}
    public int Coins { get { return this.coins; } }
}
