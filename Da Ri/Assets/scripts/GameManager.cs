using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GotoSceneFS(){

		SceneManager.LoadScene("scene-freestyle");
	}
	public void GotoSceneGM(){

		SceneManager.LoadScene("scene-GameMode");
	}
}
