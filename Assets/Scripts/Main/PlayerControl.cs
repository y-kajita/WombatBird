using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float jumpHight = 1;
	public Sprite fly1;
	public Sprite fly2;
	public Sprite dead;
	private float interval;
	private bool isOk;

	// Use this for initialization
	void Start () {
		interval = 0.0f;
		isOk = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			float y_speed = Mathf.Sqrt(2.0f * Mathf.Abs(Physics.gravity.y) * this.jumpHight);
			this.GetComponent<Rigidbody2D>().velocity = Vector2.up * y_speed;
			interval = Time.time + 0.3f;
		}
		if (isOk && (interval - Time.time > 0.2f || interval - Time.time < 0))
			GetComponent<SpriteRenderer> ().sprite = fly1;
		else if (isOk)
			GetComponent<SpriteRenderer> ().sprite = fly2;
		if(!isOk) {
			GetComponent<SpriteRenderer> ().sprite = dead;
		}
		if(GameManager.gameover)
			isOk = false;
		
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Ground")
		{
			//gameover
			Debug.Log("GAMEOVER");
			GameManager.gameover = true;
		}
	}
}
