using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hapticTimePitch : MonoBehaviour
{
    public AudioSource haptic;

	// Use this for initialization
	void Start ()
    {
        haptic = GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            haptic.time++;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            haptic.time--;
        }
        if (Time.timeScale <= 0.5)
        {
            haptic.pitch = Time.timeScale;
        }
        else
        {
            haptic.pitch = 1.0f;
        }

     //   haptic.time;
        
                
       
	}
}
