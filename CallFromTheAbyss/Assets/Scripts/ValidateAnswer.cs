using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ValidateAnswer : MonoBehaviour {

	public string[] answers;
	public Text textAnswer;
	public CharacterManager player;
	public int keyNumber = 1;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ValidationProcess () {
		if (ValidatePlayerAnswer()) {
			player.GainKey(keyNumber);
		}
		else {
			player.Wrong();
		}
	}

	bool ValidatePlayerAnswer () {
		string playerAnswer = textAnswer.text;
		foreach (string answer in answers) {
			if (playerAnswer == answer) {
				return true;
			}
		}
		return false;
	}
}
