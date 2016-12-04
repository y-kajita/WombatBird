using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour {
	public float appearRate = 5.0f;
	private float coolDown;
	public GameObject WallPrefab;
	// Use this for initialization
	void Start () {
		coolDown = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(coolDown > 0 )
		{
			this.coolDown -= Time.deltaTime;
		}

		if(coolDown <= 0)
		{
			coolDown = appearRate;

			GameObject wall = Instantiate(this.WallPrefab) as GameObject;

			float y_pos = Random.Range(-5.0f,-0.7f);

			Vector3 new_pos = new Vector3(transform.position.x,y_pos,0);

			wall.transform.position = new_pos;



		}


	}
}
