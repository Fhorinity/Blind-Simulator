using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    public GameObject blindStick;
    public GameObject[] objects;
    public float distance;
    [HideInInspector]
    private float pitch = 1f;
    public AudioSource sound;
    public GameObject closest = null;
    private bool pitchCounter;
    public float tmpPitch;
    public AudioClip beep;

    void Start()
    {
        pitchCounter = true;
        sound = GetComponent<AudioSource>();
        objects = GameObject.FindGameObjectsWithTag("Object");
        print(pitch);
        sound.Play();
        sound.pitch = 1;
       // sound.pitch = pitch;
        print(pitch);
    }
    void Update()
    {
        float closestDistance = Mathf.Infinity;
        foreach (GameObject obj in objects)
        {
            var distance = Vector3.Distance(obj.transform.position, transform.position);
            if (distance < closestDistance)
            {
                closest = obj;
                closestDistance = distance;
            }
        }
        // Varable closest now contains a reference to the object closet to 'blindstick'
        distance = Vector3.Distance(blindStick.transform.position, closest.transform.position);
        // Checks if closest object against distance parameters in Distance_Detection();
        Checker();
        Distance_Detection();
    }
    void Checker()
    {
        //if (pitchCounter)
        //{
        //    pitch++;
        //}
        //else if (!pitchCounter)
        //{
        //    pitch--;
        //}
    }
    void Distance_Detection()
    {
          tmpPitch = pitch;
        if (distance > 5)
        {
            sound.pitch = 0f;
            //sound.Stop();
        }
        
        if (distance == 5)
        {
            // pitchCounter = true;
            //sound.Play();
            sound.pitch = 1f;
            Debug.Log("Play Low tone"); //1
        }
        if (distance < 5 && distance > 4.75)
        {
            sound.pitch = 1.1f;
            Debug.Log("Increase pitch 1 by 0.1"); //1.1
        }
        if (distance < 4.75 && distance > 4.5)
        {
            sound.pitch = 1.2f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.5 && distance > 4.25)
        {
            sound.pitch = 1.3f;
            Debug.Log("Increase pitch 3 by 0.1"); //1.3
        }
        if (distance < 4.25 && distance > 4)
        {
            sound.pitch = 1.4f;
            Debug.Log("Increase pitch 4 by 0.1"); //1.4
        }
        if (distance < 4 && distance > 3.75)
        {
            sound.pitch = 1.5f;
            Debug.Log("Increase pitch 5 by 0.1"); //1.5
        }
        if (distance < 3.75 && distance > 3.5)
        {
            sound.pitch = 1.6f;
            Debug.Log("Increase pitch 6 by 0.1"); //1.6
        }
        if (distance < 3.5 && distance > 3.25)
        {
            sound.pitch = 1.7f;
            Debug.Log("Increase pitch 7 by 0.1"); //1.7
        }
        if (distance < 3.25 && distance > 3)
        {
            sound.pitch = 1.8f;
            Debug.Log("Increase pitch 8 by 0.1"); //1.8
        }
        if (distance < 3 && distance > 2.75)
        {
            sound.pitch = 1.9f;
            Debug.Log("Increase pitch 9 by 0.1"); //1.9
        }
        if (distance < 2.75 && distance > 2.5)
        {
            sound.pitch = 2f;
            Debug.Log("Increase pitch 10 by 0.1"); //2
        }
        if (distance < 2.5 && distance > 2.25)
        {
            sound.pitch = 2.1f;
            Debug.Log("Increase pitch 11 by 0.1"); //2.1
        }
        if (distance < 2.25 && distance > 2)
        {
            sound.pitch = 2.2f;
            Debug.Log("Increase pitch 12 by 0.1"); //2.2
        }
        if (distance < 2 && distance > 1.75)
        {
            sound.pitch = 2.3f;
            Debug.Log("Increase pitch 13 by 0.1"); //2.3
        }
        if (distance < 1.75 && distance > 1.5)
        {
            sound.pitch = 2.4f;
            Debug.Log("Increase pitch 14 by 0.1"); //2.4
        }
        if (distance < 1.5 && distance > 1.25)
        {
            sound.pitch = 2.5f;
            Debug.Log("Increase pitch 15 by 0.1"); //2.5
        }
        if (distance < 1.25 && distance > 1 || distance < 1)
        {
            sound.pitch = 2.6f;
            //  pitchCounter = false;
            Debug.Log("Increase pitch 16 by 0.1"); //2.6    //This is the closest it can get to stick.
        }
    }
}
