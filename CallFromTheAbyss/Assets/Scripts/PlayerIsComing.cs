using UnityEngine;
using System.Collections;

public class PlayerIsComing : MonoBehaviour {

	public LightManager manager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit (Collider other) {
		if (other.tag == "Player") {
			manager.zombieSpawn = true;
		}
	}
}
