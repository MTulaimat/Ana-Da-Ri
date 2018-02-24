using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

	/*
	script for tutorial:

-Hi there, this a tutorial for Da Ri,  a Game for visually impaired people.

- now i am going to play a sound on your left side
*plays sound*

- now i am going to play a sound on your right side
*plays sound*

- now i am going to play a sound infront of you
*plays sound*

- here's an example of a moving sound around you

- here's an example of sound coming at you

- you should always follow the music

- this sound means you're getting closer to a wall, walls should be avoided 

- press the right half of the screen to turn right

- press the left half of the screen to turn left

 */
	// Use this for initialization
	public GameObject player;
	public GameObject Coin;
	public GameObject Wall;
	public AudioClip[] AC = new AudioClip[20];
	public AudioClip PlayerClip;
	public AudioClip CoinClip;
	public AudioClip WallClip;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
