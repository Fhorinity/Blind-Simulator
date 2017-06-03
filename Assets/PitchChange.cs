using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchChange : MonoBehaviour {

    // Use this for initialization
    public float startingPitch = 1;
    public AudioSource audio;


	void Start ()
    {
        
        audio.pitch = startingPitch;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.S))
        {
            startingPitch--;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            startingPitch++;
        }
	}
}
