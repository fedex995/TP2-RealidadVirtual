using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static SoundManager instance;
	public enum Sounds{Mushroom, Coin, FireBall, Jump, End, GameOver, Dies, Brick, Goomba}

	public AudioClip mushroom;
	public AudioClip coin;
	public AudioClip fireball;
	public AudioClip jump;
	public AudioClip gameOver;
	public AudioClip end;
	public AudioClip dies;
	public AudioClip greeting;
	public AudioClip brick;
	public AudioClip goomba;

	private AudioSource audioSource;
	public AudioSource themeSource;


	void Awake(){
		if (!instance) {
			instance = this;
			audioSource = GetComponent<AudioSource> ();
		} else {
			Destroy (this);
		}
	}
	void Start()
	{
		StartCoroutine(playEngineSound());
	}

	IEnumerator playEngineSound()
	{
		audioSource.clip = greeting;
		audioSource.Play();
		yield return new WaitForSeconds(audioSource.clip.length);

		themeSource.Play();
	}

	public void PlaySound(Sounds soundToPlay) {
		switch (soundToPlay) {
		case Sounds.Mushroom:
			audioSource.clip = mushroom;
			break;	

		case Sounds.Coin:
			audioSource.clip = coin;
			break;

		case Sounds.Goomba:
			audioSource.clip = goomba;
			break;

		case Sounds.FireBall:
			audioSource.clip = fireball;
			break;
		case Sounds.Brick:
			audioSource.clip = brick;
			break;
		
		case Sounds.Jump:
			audioSource.clip = jump;
			break;
		case Sounds.End:
			themeSource.Pause ();
			audioSource.clip = end;
			break;

		case Sounds.GameOver:
			themeSource.Pause ();
			audioSource.clip = gameOver;
			break;

		case Sounds.Dies:
			themeSource.Pause ();
			audioSource.clip = dies;
			Invoke ("ResumeThemeSound", audioSource.clip.length);
			break;
		default:
			break;
		}
		audioSource.Play();
	}
	private void ResumeThemeSound(){
		themeSource.Play ();
	}
}
