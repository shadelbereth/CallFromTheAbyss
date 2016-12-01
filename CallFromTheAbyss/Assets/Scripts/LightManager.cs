using UnityEngine;
using System.Collections;

public class LightManager : MonoBehaviour {

	public Light[] lighting;
	MeshRenderer lightMesh;
	float intensity;
	public float minTime = 3f;
	public float maxTime = 12f;
	float timer;
	public ZombieApparition zombieScript;
	public bool zombieSpawn = false;

	// Use this for initialization
	void Start () {
		lightMesh = GetComponent<MeshRenderer>();
		intensity = lighting[0].intensity;
	}
	
	// Update is called once per frame
	void Update () {
		if (zombieSpawn) {
			StartCoroutine("PowerBreak");
			timer = Random.Range(minTime, maxTime);
		}
		if (timer > 0) {
			timer -= Time.deltaTime;
		}
		else {
			StartCoroutine("PowerBreak");
			timer = Random.Range(minTime, maxTime);
		}
	}

	IEnumerator PowerBreak () {
		foreach (Light light in lighting) {
			light.intensity = 0;
		}
		lightMesh.materials[0].SetColor("_Color", Color.black);
		lightMesh.materials[0].SetColor("_EmissionColor", Color.black);
		yield return new WaitForSeconds(1f);
		if (zombieSpawn) {
			zombieScript.ZombieAppears();
			zombieSpawn = false;
		}
		lightMesh.materials[0].SetColor("_Color", Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 1)));
		lightMesh.materials[0].SetColor("_EmissionColor", Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 1)));
		for (float i = 0; i < intensity / 4; i += 0.2f) {
			foreach (Light light in lighting) {
				light.intensity = i;
			}
			yield return null;
		}
		lightMesh.materials[0].SetColor("_Color", Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1)));
		lightMesh.materials[0].SetColor("_EmissionColor", Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1)));
		for (float i = lighting[0].intensity; i > intensity / 8; i -= 0.3f) {
			foreach (Light light in lighting) {
				light.intensity = i;
			}
			yield return null;
		}
		yield return new WaitForSeconds(0.5f);
		lightMesh.materials[0].SetColor("_Color", Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 1)));
		lightMesh.materials[0].SetColor("_EmissionColor", Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 1)));
		for (float i = lighting[0].intensity; i < intensity; i += 0.1f) {
			foreach (Light light in lighting) {
				light.intensity = i;
			}
			yield return new WaitForSeconds(.01f);
		}
		lightMesh.materials[0].SetColor("_Color", Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 1)));
		lightMesh.materials[0].SetColor("_EmissionColor", Color.white);
	}
}
