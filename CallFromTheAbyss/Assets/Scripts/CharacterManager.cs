using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour {

	public bool hasKey = false;
	public bool hasKey2 = false;
	public int permitError;
	public ChangeSceneManager manager;
	public string defeatScene;
	public Image damagedImage;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
    bool damaged;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(damaged) {
        	damagedImage.color = flashColor;
    	} else {
        	damagedImage.color = Color.Lerp(damagedImage.color, Color.clear, flashSpeed * Time.deltaTime);
    	}

    	damaged = false; 
		
	}

	public void GainKey(int keyNumber) {
		if (keyNumber == 1) {
			hasKey = true;
		}
		if (keyNumber == 2) {
			hasKey2 = true;
		}
	}

	public void Wrong() {
		damaged = true;
		permitError --;
		if (permitError < 0) {
			manager.GoToScene(defeatScene);
		}
	}
}
