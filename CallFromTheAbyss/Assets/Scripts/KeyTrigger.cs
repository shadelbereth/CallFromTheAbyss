using UnityEngine;
using System.Collections;

public class KeyTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other) {
        if (other.tag == "Player") {
            other.GetComponent<CharacterManager>().hasKey = true;
        } 
    }
}
