using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeScreen : MonoBehaviour {

	public Image myPanel;
	public Text text;
	public Text wonText;
	public Text scoreText;
	Color colorToFadeTo;
	Color colorToFadeOut;
	public float interval;
	public float alphaInterval;

	public void startFadeIn(bool direction){
		StartCoroutine(fadeIn(direction));
	}

	IEnumerator fadeIn (bool direction) {
		yield return new WaitForSeconds (interval);
		Color temp = myPanel.color;
		if (temp.a < 1) {
			temp.a = temp.a + alphaInterval;
			myPanel.color = temp;
			startFadeIn (direction);
		} else {
			UtilityClass.instance.turn (direction);
			startFadeOut ();
		}
	}
	public void startFadeOut(){
		StartCoroutine(fadeOut());
	}
	IEnumerator fadeOut () {
        yield return new WaitForSeconds (interval);
		Color temp = myPanel.color;
		if (temp.a > 0) {
			temp.a = temp.a - alphaInterval;
			myPanel.color = temp;
			startFadeOut ();
		} else {
			UtilityClass.instance.setPlayerFading ();
		}
	}
	public void StartFadeBlack(){
		StartCoroutine(FadeBlack());
	}
	IEnumerator FadeBlack(){
		yield return new WaitForSeconds (interval);
		Color temp = myPanel.color;
		if (temp.a < 1) {
			temp.a = temp.a + alphaInterval;
			myPanel.color = temp;
			StartFadeBlack ();
		} else {
			Color tempText = text.color;
			tempText.a = 1;
			text.color = tempText;
		}
	}
	public void Won(int score){
		StartCoroutine(FadeWon(score));
	}
	IEnumerator FadeWon(int score){
		yield return new WaitForSeconds (interval);
		Color temp = myPanel.color;
		if (temp.a < 1) {
			temp.a = temp.a + alphaInterval;
			myPanel.color = temp;
			Won (score);
		} else {
			Color tempText = wonText.color;
			tempText.a = 1;
            wonText.color = tempText;
			Color tempText2 = scoreText.color;
		    scoreText.text = "Score: " + score;
			tempText2.a = 1;
            scoreText.color = tempText2;
		}
	}
}
