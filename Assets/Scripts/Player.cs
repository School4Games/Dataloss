using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	private float left;
	private float mid;
	private float right;

	public bool isLeft;
	public bool isMid;
	public bool isRight;


	void Start()
	{
		left = 3.5f;
		mid = 0f;
		right = -3.5f;

		transform.position = new Vector2 (mid, -6.5f);

		isLeft = false;
		isMid = true;
		isRight = false;

	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.A) && isMid) 
		{

			transform.position = new Vector2 (left, -6.5f);
			isLeft = true;
			isMid = false;
			isRight = false;
		}

		if (Input.GetKeyDown (KeyCode.D) && isMid) 
		{
			transform.position = new Vector2 (right, -6.5f);
			isLeft = false;
			isMid = false;
			isRight = true;
		}
		if (Input.GetKeyDown (KeyCode.D) && isLeft) 
		{
			transform.position = new Vector2 (mid, -6.5f);
			isLeft = false;
			isMid = true;
			isRight = false;

		}
		if (Input.GetKeyDown (KeyCode.A) && isRight) 
		{
			transform.position = new Vector2 (mid, -6.5f);
			isLeft = false;
			isMid = true;
			isRight = false;
			
		}
	}
	/*
	void FixedUpdate ()
	{
			float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f);
		rigidbody2D.velocity = movement * 10;

			
	}
	*/
}
