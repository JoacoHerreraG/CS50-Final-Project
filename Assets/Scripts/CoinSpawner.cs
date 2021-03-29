using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour{
	
	public GameObject[] prefabs;
	public static bool playing;

	void Start () {
		playing = true;
		StartCoroutine(SpawnCoins());
	}

	IEnumerator SpawnCoins() {
		while (playing) {

			float coinY = Random.value;
			if (coinY < 0.5) {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(Random.Range(-4.45f, 5f), 1.2f, 90f), Quaternion.Euler(0f, 0f, 0f));
			} else {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(Random.Range(-4.45f, 5f), 3f, 90f), Quaternion.Euler(0f, 0f, 0f));
			}

			yield return new WaitForSeconds(2f - ObstacleSpawner.speed / 60);
		}
	}
}
