using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

	AudioSource AS;
	// Use this for initialization
	void Start () {
		
		AS = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	 void OnTriggerEnter2D(Collider2D col) {
        
		if (col.gameObject.tag == "Player"){

			//AS.mute = false;
		}
    }
	void OnTriggerExit2D(Collider2D col) {
        
		if (col.gameObject.tag == "Player"){

			//AS.mute = true;
		}
    }
}
