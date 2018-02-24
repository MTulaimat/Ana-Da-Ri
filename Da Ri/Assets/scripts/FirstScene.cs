using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class FirstScene : MonoBehaviour {

	// Use this for initialization
	float Start_Time;
	float End_Time;
	float Swipe_Distance;
	float Swipe_Time;
	Vector3 Start_Position;
	Vector3 End_Position;
	public float Max_Time;
	public float Min_Swipe_Distance;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
			if (Input.touchCount > 0){

			Touch touch = Input.GetTouch(0);
			
			if (touch.phase == TouchPhase.Began){

				Start_Time = Time.time;
				Start_Position = touch.position;
			}

			else if (touch.phase == TouchPhase.Ended){

				End_Time = Time.time;
				End_Position = touch.position;

				Swipe_Distance = (End_Position - Start_Position).magnitude; 
				Swipe_Time = End_Time - Start_Time;
	
				if ((Swipe_Time < Max_Time && Swipe_Distance > Min_Swipe_Distance)){

						Swipe();
				}				
			}
		}
	}

	public void Swipe(){

		Vector2 Distance = End_Position - Start_Position;

		if (Mathf.Abs(Distance.x) > Mathf.Abs(Distance.y)){

			if (Distance.x > 0 ){
				
				Debug.Log("right SWIPUU");
			}

			else if ((Distance.x < 0)){
				 
				Debug.Log("Left SWIPUU");
			}
		}

		else if (Mathf.Abs(Distance.x) <= Mathf.Abs(Distance.y)){

			if ((Distance.y > 0)){

				Debug.Log("up SWIPUU");
			}

			else if ((Distance.y < 0)){
				
				Debug.Log("down SWIPUU");
			}	
		}
	}

	public void GoToPlay(){

		SceneManager.LoadScene("level01");
	}
	public void GoToTutorial(){

		SceneManager.LoadScene("Tutorial");
	}
}
