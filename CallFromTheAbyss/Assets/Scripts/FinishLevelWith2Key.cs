using UnityEngine;
using System.Collections;

public class FinishLevelWith2Key : MonoBehaviour {

	public ChangeSceneManager manager;
	public string nextLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player" && other.GetComponent<CharacterManager>().hasKey && other.GetComponent<CharacterManager>().hasKey2) {
			manager.GoToScene(nextLevel);
		}
	}
}
