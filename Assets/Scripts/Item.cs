using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
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
		this.speed.y * this.direction.y);
	}
	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = movement;
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			//game end title
//			Application.LoadLevel("GameOver");
			ScoreManagerScript.score ++;
			Debug.Log (ScoreManagerScript.score);
			GameObject.Destroy(gameObject);
		}
	}
}
