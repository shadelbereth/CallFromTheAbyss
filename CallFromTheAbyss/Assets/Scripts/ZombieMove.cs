using UnityEngine;
using System.Collections;

public class ZombieMove : MonoBehaviour {

	NavMeshAgent nav;
	Transform player;

	void Awake() {
		player = GameObject.FindWithTag("Player").transform;
		nav = GetComponent<NavMeshAgent>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination(player.position);
	}
}
