using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis("Submit") == 1) {
			Scene currentScene = SceneManager.GetActiveScene();
			if (currentScene.name == "GameOverScene") {
				PlayerController.score = 0f;
				ObstacleSpawner.playing = true;
				ObstacleSpawner.speed = 10f;
				SceneManager.LoadScene("PlayScene");	
			} else {
				SceneManager.LoadScene("PlayScene");
			}
		}
    }
}
