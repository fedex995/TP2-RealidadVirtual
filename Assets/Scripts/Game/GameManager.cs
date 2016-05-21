using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public Camera camera;
	public Canvas canvas;
	public Player player;
	public Text coins;
	public Image[] lives;
    public float timeSeconds = 0f;

	void Awake(){
		if (!instance) {
			instance = this;
		} else {
			Destroy (this);
		}
	}

    void Update()
    {
        timeSeconds += Time.deltaTime;
    }

	public void EndGame(){
		canvas.GetComponent<FadeScreen>().StartFadeBlack();
	}

	public void WonGame()
	{
	    int score = Mathf.RoundToInt(player.Coins * (10000/timeSeconds) * player.lives);
		canvas.GetComponent<FadeScreen>().Won(score);
	}
	public void ChangePlayerSize(Vector3 vector){
		camera.transform.position += vector;
	}
	public void CoinCount(int count){
		coins.text = "x " + count;
	}
	public void RemoveLive(int liveCount){
		Color temp = new Color (0, 0, 0, 0);
		lives [liveCount].color = temp;
	}
}
