using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    public GameObject blindStick;
    public GameObject[] objects;
    public float distance;
    public AudioSource sound;
    public GameObject closest = null;
    public AudioClip beep;
    public Animation anim;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        anim = GetComponent<Animation>();
        objects = GameObject.FindGameObjectsWithTag("Object");
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
        // Variable closest now contains a reference to the object closet to 'blindstick'
        distance = Vector3.Distance(blindStick.transform.position, closest.transform.position);
        // Checks if closest object against distance parameters in Distance_Detection();
        Distance_Detection();
    }
    void Distance_Detection()
    {
        if (distance > 5)
        {
            sound.pitch = 0f;
        }      
        if (distance == 5)
        {
            sound.pitch = 0.1f;
            Debug.Log("Play Low tone"); //1
        }
        if (distance < 5 && distance > 4.95)
        {
            sound.pitch = 0.2f;
            Debug.Log("Increase pitch 1 by 0.1"); //1.1
        }
        if (distance < 4.95 && distance > 4.9)
        {
            sound.pitch = 0.3f;
            Debug.Log("Increase pitch 1 by 0.1"); //1.1
        }
        if (distance < 4.9 && distance > 4.85)
        {
            sound.pitch = 0.4f;
            Debug.Log("Increase pitch 1 by 0.1"); //1.1
        }
        if (distance < 4.85 && distance > 4.8)
        {
            sound.pitch = 0.5f;
            Debug.Log("Increase pitch 1 by 0.1"); //1.1
        }
        if (distance < 4.8 && distance > 4.75)
        {
            sound.pitch = 0.6f;
            Debug.Log("Increase pitch 1 by 0.1"); //1.1
        }
        if (distance < 4.75 && distance > 4.7)
        {
            sound.pitch = 0.7f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.7 && distance > 4.65)
        {
            sound.pitch = 0.8f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.65 && distance > 4.6)
        {
            sound.pitch = 0.9f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.6 && distance > 4.55)
        {
            sound.pitch = 1f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.55 && distance > 4.5)
        {
            sound.pitch = 1.1f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.5 && distance > 4.45)
        {
            sound.pitch = 1.2f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.45 && distance > 4.4)
        {
            sound.pitch = 1.3f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.4 && distance > 4.35)
        {
            sound.pitch = 1.4f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.35 && distance > 4.3)
        {
            sound.pitch = 1.5f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.3 && distance > 4.25)
        {
            sound.pitch = 1.6f;
            Debug.Log("Increase pitch 3 by 0.1"); //1.3
        }
        if (distance < 4.25 && distance > 4.2)
        {
            sound.pitch = 1.7f;
            Debug.Log("Increase pitch 4 by 0.1"); //1.4
        }
        if (distance < 4.2 && distance > 4.15)
        {
            sound.pitch = 1.8f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.15 && distance > 4.1)
        {
            sound.pitch = 1.9f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.1 && distance > 4.05)
        {
            sound.pitch = 2f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.05 && distance > 4)
        {
            sound.pitch = 0.11f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.55 && distance > 4.5)
        {
            sound.pitch = 0.11f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.55 && distance > 4.5)
        {
            sound.pitch = 0.11f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.55 && distance > 4.5)
        {
            sound.pitch = 0.11f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.55 && distance > 4.5)
        {
            sound.pitch = 0.11f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.55 && distance > 4.5)
        {
            sound.pitch = 0.11f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
        }
        if (distance < 4.55 && distance > 4.5)
        {
            sound.pitch = 0.11f;
            Debug.Log("Increase pitch 2 by 0.1"); //1.2
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
            Debug.Log("Increase pitch 16 by 0.1"); //2.6    //This is the closest it can get to stick.
        }
    }
}
