using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text gameover_text;
	public GameObject gameover_button;
	public static bool gameover;
	float endtime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameover) {
			Time.timeScale = 0.0f;
		}
		gameover_text.enabled = gameover;
		gameover_button.SetActive(gameover);
	}
	public void BackToTitle(){
		Debug.Log ("Back");
		SceneManager.LoadScene(SceneName.Title);
		gameover = false;
	}
}
