﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchCheck : MonoBehaviour
{
    private DistanceCheck check;
    public float distance;
    public GameObject closet;
    public float pitch;
	// Use this for initialization
	void Start () {

        check = FindObjectOfType<DistanceCheck>();
		
	}
	
	// Update is called once per frame
	void Update () {
        distance = check.distance;
        closet = check.closest;
        pitch = check.sound.pitch;
    }
}
