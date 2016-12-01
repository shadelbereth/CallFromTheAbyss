using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class ChangeAudioMixerSnapshot : MonoBehaviour {

	public AudioMixerSnapshot ambiant;
	public AudioMixerSnapshot sound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		sound.TransitionTo(1f);
	}

	void OnTriggerExit (Collider other) {
		ambiant.TransitionTo(1f);
	}
}
