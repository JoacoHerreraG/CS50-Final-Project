using UnityEngine;

public class CloudSpawner : MonoBehaviour {

    void Update() {
    	if (transform.position.z < -20) {
			transform.position = new Vector3(Random.Range(-9.5f, 17.5f), Random.Range(13.4f, 18f), 90f);
		}
    	transform.Translate(0, 0, -ObstacleSpawner.speed * Time.deltaTime * 0.3f);
    }
}
