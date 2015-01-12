using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour 
{
	public static int score;
	public float timer;

	// Use this for initialization
	void Start () {
		timer = 1.0f;

	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = 0.04f;
			score += 1;
				}
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 400, 50), "Score: " + score);
	}
}
