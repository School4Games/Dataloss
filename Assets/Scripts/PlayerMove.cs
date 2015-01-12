using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	float depth = 5.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 

	{
		Vector3 mousePos = Input.mousePosition;
		Vector3 wantedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, depth));
		transform.position = wantedPos;
	}
}
