using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	public float speed;
	public int score;
	public Text ScoreText;
	public bool TurnRight;
	float currentAngle;
	public float RotSpeed;
	public GameObject Key;
	public GameObject coin;
	// Use this for initialization
	void Start () {
		
		speed = 50;
		RotSpeed = 300;
	}
	
	// Update is called once per frame
	void Update () {
		
		KeySpawn();

		transform.Translate(Vector3.up * Time.deltaTime/2);

	if (TurnRight){

		if (currentAngle == 0){

			transform.rotation = Quaternion.RotateTowards(transform.rotation,
		 	Quaternion.Euler(0,0, 270), RotSpeed*Time.deltaTime);
		}
		else if (currentAngle == 270){

			transform.rotation = Quaternion.RotateTowards(transform.rotation,
		 	Quaternion.Euler(0,0, 180), RotSpeed*Time.deltaTime);
		}
				
		else if (currentAngle == 180){

			transform.rotation = Quaternion.RotateTowards(transform.rotation,
		 	Quaternion.Euler(0,0, 90), RotSpeed*Time.deltaTime);
		}

		else if (currentAngle == 90){

			transform.rotation = Quaternion.RotateTowards(transform.rotation,
		 	Quaternion.Euler(0,0, 0), RotSpeed*Time.deltaTime);
		}
	}

	else {

		if (currentAngle == 0){

			transform.rotation = Quaternion.RotateTowards(transform.rotation,
		 	Quaternion.Euler(0,0, 90), RotSpeed*Time.deltaTime);
		}
		else if (currentAngle == 270){

			transform.rotation = Quaternion.RotateTowards(transform.rotation,
		 	Quaternion.Euler(0,0, 0), RotSpeed*Time.deltaTime);
		}
				
		else if (currentAngle == 180){

			transform.rotation = Quaternion.RotateTowards(transform.rotation,
		 	Quaternion.Euler(0,0, 270), RotSpeed*Time.deltaTime);
		}

		else if (currentAngle == 90){

			transform.rotation = Quaternion.RotateTowards(transform.rotation,
		 	Quaternion.Euler(0,0, 180), RotSpeed*Time.deltaTime);
		}
	}

	if (Input.GetKeyDown(KeyCode.RightArrow)){

		GoRight();
	}
	if (Input.GetKeyDown(KeyCode.LeftArrow)){

		GoLeft();
	}

}
	public void GoRight(){

		currentAngle = transform.eulerAngles.z;
		Debug.Log(currentAngle);
		TurnRight = true;
	}
	public void GoLeft(){

		currentAngle = transform.eulerAngles.z;
		Debug.Log(currentAngle);
		TurnRight = false;
	}

    void OnTriggerEnter2D(Collider2D col) {
        
		if (col.gameObject.tag == "Collectable"){
			
			IncrementScore(1);
		}

		if (col.gameObject.tag == "wall"){

			Debug.Log("you lost");
		}
    }

	void IncrementScore(int s){

		score = int.Parse (ScoreText.text.ToString());
		score += s;
		ScoreText.text = score.ToString();
	}

	public void KeySpawn(){

		if (score >= 10){

			Key.SetActive(true);
			coin.SetActive(false);
		}
	}
}