using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour 
{
	public static int score;
	public float timer;
	public static int multi;
	public static int bitcount;

	// Use this for initialization
	void Start () {
		timer = 1.0f;
		multi = 1;

	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = 0.04f;
			score += multi;
				}
		if (bitcount == 8) {
			multi *= 2;
			bitcount = 0;
		}
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 400, 50), "Score: " + score);
		GUI.Label (new Rect (10, 40, 400, 50), "Mult:" + multi);
	}
}
