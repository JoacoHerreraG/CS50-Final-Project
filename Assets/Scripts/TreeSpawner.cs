using UnityEngine;

public class TreeSpawner : MonoBehaviour {

    void Update() {

    	float newTreePosition = Random.value;
    	if (transform.position.z < -15) {
    		if (newTreePosition < 0.25) {
				transform.position = new Vector3(-7.5f, 2.05f, 90f);
			} else if (newTreePosition < 0.5) {
				transform.position = new Vector3(10.4f, 3.8f, 90f);
			} else if (newTreePosition < 0.75) {
				transform.position = new Vector3(9.67f, 3.6f, 90f);
			} else {
				transform.position = new Vector3(-9.15f, 3.3f, 90f);
			}
		}
    	transform.Translate(0, 0, -ObstacleSpawner.speed * Time.deltaTime);
    }
}

