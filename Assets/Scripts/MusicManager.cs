﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	void Awake () {
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load " + name);
	}

	void Start (){
		audioSource = GetComponent<AudioSource> ();
	}

	void OnLevelWasLoaded (int level) {

		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		Debug.Log ("Playing clip" + thisLevelMusic);

		// if music is attached
		if(thisLevelMusic){
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
}
