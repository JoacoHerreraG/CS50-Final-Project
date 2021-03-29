using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    void Update() {

    	if (transform.position.z < -7) {
			Destroy(gameObject);
		}
    	transform.Translate(0, 0, -ObstacleSpawner.speed * Time.deltaTime);
    }
}
