using UnityEngine;
using System.Collections;

public class TilesMoveMid : MonoBehaviour {
	public int speed;
	// Use this for initialization
	void Start () 
	{
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += Vector3.down * Time.deltaTime * speed;
	}
}
