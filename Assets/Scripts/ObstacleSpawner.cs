using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
	
	public GameObject[] prefabs;
	public static float speed = 10f;
	public static bool playing;

	void Start () {
		playing = true;
		StartCoroutine(SpawnObstacles());
	}

	IEnumerator SpawnObstacles() {
		while (playing) {

			float obstacleY = Random.value;
			if (obstacleY < 0.5) {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(Random.Range(-4.45f, 5f), 0.7f, 90f), Quaternion.Euler(0f, 0f, 0f));
			} else {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(Random.Range(-4.45f, 5f), 3.7f, 90f), Quaternion.Euler(0f, 0f, 0f));
			}

			// randomly increase the speed by 1
			if (Random.Range(1, 10) == 1 && speed < 40f) {
				speed += 1f;
			}

			yield return new WaitForSeconds(1.2f - speed / 60);
		}
	}
}
