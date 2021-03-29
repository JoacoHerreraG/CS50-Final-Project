using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreCount : MonoBehaviour
{
	private Text text;

	void Start () {
		text = GetComponent<Text>();
	}
	
	void Update () {
		text.text = "Score: " + Mathf.FloorToInt(PlayerController.score);
	}
}
