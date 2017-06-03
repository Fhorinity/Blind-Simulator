using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchCheck : MonoBehaviour
{
    private DistanceCheck check;
    public float pitch;
    public float distance;
    public GameObject closet;
	// Use this for initialization
	void Start () {

        check = FindObjectOfType<DistanceCheck>();
		
	}
	
	// Update is called once per frame
	void Update () {
        pitch = check.tmpPitch;
        distance = check.distance;
        closet = check.closest;
    }
}
