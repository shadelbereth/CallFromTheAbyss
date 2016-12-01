using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class RevealRiddle : MonoBehaviour {

	// FirstPersonController script MUST be edited; turn m_MouseLook to public in order to use it.

	public GameObject riddle;
	public int keyNumber = 1;

	// Use this for initialization
	void Start () {
		riddle.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			other.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = 0;
			other.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = 0;
			other.GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(false);
		}
	}

	void OnTriggerStay (Collider other) {
		if (other.tag == "Player") {
			if ((!other.GetComponent<CharacterManager>().hasKey && keyNumber == 1) || (!other.GetComponent<CharacterManager>().hasKey2 && keyNumber == 2)) {
				riddle.SetActive(true);
			} else {
				riddle.SetActive(false);
				other.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = 2;
				other.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = 2;
				other.GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(true);
			}
		}
	}
	void OnTriggerExit (Collider other) {
		if (other.tag == "Player") {
			riddle.SetActive(false);
			other.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = 2;
			other.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = 2;
			other.GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(true);
		}
	}
}
