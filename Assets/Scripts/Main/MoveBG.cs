using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour {
	public Vector2 speed = new Vector2(1,1);
	public Vector2 direction = new Vector2(1,0);
	private Vector2 movement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		movement = new Vector2 (
			this.speed.x * this.direction.x,
			this.speed.y * this.direction.y)*Time.deltaTime;
		if (transform.localPosition.x <= -25.5) {
			transform.localPosition.Set(51.0f, transform.localPosition.y, transform.localPosition.z);
		}

	}
	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}
