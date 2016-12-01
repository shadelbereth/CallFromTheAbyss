using UnityEngine;
using System.Collections;

public class ZombieApparition : MonoBehaviour {

	public GameObject zombiePrefab;
	public float destroyTime = 1f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ZombieAppears () {
		GameObject zombie = (GameObject)Instantiate(zombiePrefab, transform.position, Quaternion.identity);
		Destroy(zombie, destroyTime);
	}
}
