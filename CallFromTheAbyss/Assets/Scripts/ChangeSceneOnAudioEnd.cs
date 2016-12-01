using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeSceneOnAudioEnd : MonoBehaviour {

	public string nextScene;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!audio.isPlaying) {
			StartCoroutine("ChangeWithDelay");
		}
	}

	IEnumerator ChangeWithDelay () {
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(nextScene);
	}
}
