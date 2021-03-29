using UnityEngine;

public class FlowerSpawner : MonoBehaviour {

    void Update() {
    	if (transform.position.z < -15) {
			transform.position = new Vector3(Random.Range(-5.5f, 5.5f), 0f, 90f);
		}
    	transform.Translate(0, 0, -ObstacleSpawner.speed * Time.deltaTime);
    }
}
