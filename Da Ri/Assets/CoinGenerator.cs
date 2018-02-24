using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour {

	// Use this for initialization
	float T;
	AudioSource AS;
	public AudioClip CoinSound;
	void Start () {

		AS = GetComponent<AudioSource>();
		T = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		
		T -= Time.deltaTime;
		if (T <= 0){
			
			gameObject.SetActive(true);
			T = 0.5f;
		}
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "Player"){

			AS.PlayOneShot(CoinSound, 0.5f);
			transform.position = Random.insideUnitCircle * 2;
			//gameObject.SetActive(false);
		}
    }
}
