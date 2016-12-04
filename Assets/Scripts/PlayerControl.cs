using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float jumpHight = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			float y_speed = Mathf.Sqrt(2.0f * Mathf.Abs(Physics.gravity.y) * this.jumpHight);
			this.GetComponent<Rigidbody2D>().velocity = Vector2.up * y_speed;
		}
	}
}
