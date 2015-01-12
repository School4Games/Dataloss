using UnityEngine;
using System.Collections;

public class TilesMove : MonoBehaviour {
	public int speed;
	public float checkup;

	// Use this for initialization
	void Start () 
	{
		speed = 5;
		checkup = 2000;
	}
	// Update is called once per frame
	void Update () {
	if (HighScore.score >= checkup) {
		speed += 3;
		checkup += checkup + checkup * .5f;
	}
	{
		transform.position += Vector3.down * Time.deltaTime * speed;
	}
}
}
