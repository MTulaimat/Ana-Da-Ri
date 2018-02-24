using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSound : MonoBehaviour {

	// Use this for initialization
	public GameObject Player;
	AudioSource AS;
	void Start () {
		
		transform.localPosition = Vector3.zero;
		AS = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (gameObject.tag == "HorWall"){

			transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
		}
		
		else if (gameObject.tag == "VerWall"){

			transform.position = new Vector3(transform.position.x, Player.transform.position.y, transform.position.z);
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
        
		if (col.gameObject.tag == "Player"){

			AS.mute = false;
		}
    }
	void OnTriggerExit2D(Collider2D col) {
        
		if (col.gameObject.tag == "Player"){

			AS.mute = true;
		}
	}
}
