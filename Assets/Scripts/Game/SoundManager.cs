using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static SoundManager instance;
	public enum Sounds{Mushroom, Coin, FireBall}

	public AudioClip mushroom;
	public AudioClip coin;
	public AudioClip fireball;

	private AudioSource audioSource;


	void Awake(){
		if (!instance) {
			instance = this;
			audioSource = GetComponent<AudioSource> ();
		} else {
			Destroy (this);
		}
	}

	public void PlaySound(Sounds soundToPlay) {
		switch (soundToPlay) {
		case Sounds.Mushroom:
			audioSource.clip = mushroom;

			break;	
		case Sounds.Coin:
			audioSource.clip = coin;

			break;
		case Sounds.FireBall:
			audioSource.clip = fireball;

			break;

		default:
			break;
		}
		audioSource.Play();
	}
}
