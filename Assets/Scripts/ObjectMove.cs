using UnityEngine;
using System.Collections;

public class ObjectMove : MonoBehaviour 
{
	public int speedup;
	public int speed;
	public float checkup;

	// Use this for initialization
	void Start () {
		checkup = 2000;
		speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (HighScore.score >= checkup) {
			speed += 2;
			checkup += checkup + checkup * .5f;
				}

		transform.position += Vector3.down * Time.deltaTime * speed;
	}
}
