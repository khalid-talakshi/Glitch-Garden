using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] musicArray;
	private AudioSource audioSource; 

	// Use this for initialization
	void Awake () {
		
		DontDestroyOnLoad(gameObject);
	
	}
	
	void Start () {
	
		audioSource = GetComponent<AudioSource>();
	
	}

	void OnLevelWasLoaded(int level) {
	
		AudioClip currentClip = musicArray[level];
	
		Debug.Log ("Playing Clip: " + musicArray[level]);
		
		if (currentClip) {
		
			audioSource.clip = currentClip;
			audioSource.loop = true;
			audioSource.Play();
			
		}
	}
}
