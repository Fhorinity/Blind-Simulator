using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    public GameObject blindStick;
    public GameObject[] objects;
    public float distance;
    public AudioSource sound;
    public AudioSource haptic;
    public AudioClip[] hapt_clip;
    public GameObject closest = null;
    public Animation anim;
    private int num;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        haptic = GetComponent<AudioSource>();
        anim = GetComponent<Animation>();
        objects = GameObject.FindGameObjectsWithTag("Object");
        
        
    }
    void Update()
    {
        //haptic.clip = hapt_clip[num];
        //haptic.Play();
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

    void Distance_Detection() // 80 Checks that haptics will play - Not including >5 Each haptic pulse decreases from 0.5 of a second by 0.00625 of a second a total of 80 times to cover the covers
    {
        if (distance > 5)
        {
            sound.pitch = 0f;
            num = 0;
        }
        if (distance <= 5 && distance > 4.95)
        {
            sound.pitch = 0.05f;
            num = 1;
            Debug.Log("0.05 Pitch");
        }
        if (distance < 4.95 && distance > 4.9)
        {
            sound.pitch = 0.1f;
            num = 2;
            Debug.Log("0.1 Pitch");
        }
        if (distance < 4.9 && distance > 4.85)
        {
            sound.pitch = 0.15f;
            num = 3;
            Debug.Log("0.15 Pitch");
        }
        if (distance < 4.85 && distance > 4.8)
        {
            sound.pitch = 0.2f;
            num = 4;
            Debug.Log("0.2 Pitch");
        }
        if (distance < 4.8 && distance > 4.75)
        {
            sound.pitch = 0.25f;
            num = 5;
            Debug.Log("0.25 Pitch"); 
        }
        if (distance < 4.75 && distance > 4.7)
        {
            sound.pitch = 0.3f;
            num = 6;
            Debug.Log("0.3 Pitch");
        }
        if (distance < 4.7 && distance > 4.65)
        {
            sound.pitch = 0.35f;
            num = 7;
            Debug.Log("0.35 Pitch");
        }
        if (distance < 4.65 && distance > 4.6)
        {
            sound.pitch = 0.4f;
            num = 8;
            Debug.Log("0.4 Pitch");
        }
        if (distance < 4.6 && distance > 4.55)
        {
            sound.pitch = 0.45f;
            num = 9;
            Debug.Log("0.45 Pitch");
        }
        if (distance < 4.55 && distance > 4.5)
        {
            sound.pitch = 0.5f;
            num = 10;
            Debug.Log("0.5 Pitch");
        }
        if (distance < 4.5 && distance > 4.45)
        {
            sound.pitch = 0.55f;
            num = 11;
            Debug.Log("0.55 Pitch");
        }
        if (distance < 4.45 && distance > 4.4)
        {
            sound.pitch = 0.6f;
            num = 12;
            Debug.Log("0.6 Pitch");
        }
        if (distance < 4.4 && distance > 4.35)
        {
            sound.pitch = 0.65f;
            num = 13;
            Debug.Log("0.65 Pitch");
        }
        if (distance < 4.35 && distance > 4.3)
        {
            sound.pitch = 0.7f;
            num = 14;
            Debug.Log("0.7 Pitch");
        }
        if (distance < 4.3 && distance > 4.25)
        {
            sound.pitch = 0.75f;
            num = 15;
            Debug.Log("0.75 Pitch");
        }
        if (distance < 4.25 && distance > 4.2)
        {
            sound.pitch = 0.8f;
            num = 16;
            Debug.Log("0.8 Pitch");
        }
        if (distance < 4.2 && distance > 4.15)
        {
            sound.pitch = 0.85f;
            num = 17;
            Debug.Log("0.85 Pitch");
        }
        if (distance < 4.15 && distance > 4.1)
        {
            sound.pitch = 0.9f;
            num = 18;
            Debug.Log("0.9 Pitch");
        }
        if (distance < 4.1 && distance > 4.05)
        {
            sound.pitch = 0.95f;
            num = 19;
            Debug.Log("0.95 Pitch");
        }
        if (distance < 4.05 && distance > 4)
        {
            sound.pitch = 1f;
            num = 20;
            Debug.Log("1 Pitch");
        }
        if (distance < 4 && distance > 3.95)
        {
            sound.pitch = 1.05f;
            num = 21;
            Debug.Log("1.05 Pitch");
        }
        if (distance < 3.95 && distance > 3.9)
        {
            sound.pitch = 1.1f;
            num = 22;
            Debug.Log("1.1 Pitch");
        }
        if (distance < 3.9 && distance > 3.85)
        {
            sound.pitch = 1.15f;
            num = 23;
            Debug.Log("1.15 Pitch");
        }
        if (distance < 3.85 && distance > 3.8)
        {
            sound.pitch = 1.2f;
            num = 24;
            Debug.Log("1.2 Pitch");
        }
        if (distance < 3.8 && distance > 3.75)
        {
            sound.pitch = 1.25f;
            num = 25;
            Debug.Log("1.25 Pitch");
        }
        if (distance < 3.75 && distance > 3.7)
        {
            sound.pitch = 1.3f;
            num = 26;
            Debug.Log("1.3 Pitch");
        }
        if (distance < 3.7 && distance > 3.65)
        {
            sound.pitch = 1.35f;
            num = 27;
            Debug.Log("1.35 Pitch");
        }
        if (distance < 3.65 && distance > 3.6)
        {
            sound.pitch = 1.4f;
            num = 28;
            Debug.Log("1.4 Pitch");
        }
        if (distance < 3.6 && distance > 3.55)
        {
            sound.pitch = 1.45f;
            num = 29;
            Debug.Log("1.45 Pitch");
        }
        if (distance < 3.55 && distance > 3.5)
        {
            sound.pitch = 1.5f;
            num = 30;
            Debug.Log("1.5 Pitch");
        }
        if (distance < 3.5 && distance > 3.45)
        {
            sound.pitch = 1.55f;
            num = 31;
            Debug.Log("1.55 Pitch");
        }
        if (distance < 3.45 && distance > 3.4)
        {
            sound.pitch = 1.6f;
            num = 32;
            Debug.Log("1.6 Pitch");
        }
        if (distance < 3.4 && distance > 3.35)
        {
            sound.pitch = 1.65f;
            num = 33;
            Debug.Log("1.65 Pitch");
        }
        if (distance < 3.35 && distance > 3.3)
        {
            sound.pitch = 1.7f;
            num = 34;
            Debug.Log("1.7 Pitch");
        }
        if (distance < 3.3 && distance > 3.25)
        {
            sound.pitch = 1.75f;
            num = 35;
            Debug.Log("1.75 Pitch");
        }
        if (distance < 3.25 && distance > 3.2)
        {
            sound.pitch = 1.8f;
            num = 36;
            Debug.Log("1.8 Pitch");
        }
        if (distance < 3.2 && distance > 3.15)
        {
            sound.pitch = 1.85f;
            num = 37;
            Debug.Log("1.85 Pitch");
        }
        if (distance < 3.15 && distance > 3.1)
        {
            sound.pitch = 1.9f;
            num = 38;
            Debug.Log("1.9 Pitch");
        }
        if (distance < 3.1 && distance > 3.05)
        {
            sound.pitch = 1.95f;
            num = 39;
            Debug.Log("1.95 Pitch");
        }
        if (distance < 3.05 && distance > 3)
        {
            sound.pitch = 2f;
            num = 40;
            Debug.Log("2 Pitch");
        }
        if (distance < 3 && distance > 2.95)
        {
            sound.pitch = 2.05f;
            num = 41;
            Debug.Log("2.05 Pitch");
        }
        if (distance < 2.95 && distance > 2.9)
        {
            sound.pitch = 2.1f;
            num = 42;
            Debug.Log("2.1 Pitch");
        }
        if (distance < 2.9 && distance > 2.85)
        {
            sound.pitch = 2.15f;
            num = 43;
            Debug.Log("2.15 Pitch");
        }
        if (distance < 2.85 && distance > 2.8)
        {
            sound.pitch = 2.2f;
            num = 44;
            Debug.Log("2.2 Pitch");
        }
        if (distance < 2.8 && distance > 2.75)
        {
            sound.pitch = 2.25f;
            num = 45;
            Debug.Log("2.25 Pitch");
        }
        if (distance < 2.75 && distance > 2.7)
        {
            sound.pitch = 2.3f;
            num = 46;
            Debug.Log("2.3 Pitch");
        }
        if (distance < 2.7 && distance > 2.65)
        {
            sound.pitch = 2.35f;
            num = 47;
            Debug.Log("2.35 Pitch");
        }
        if (distance < 2.65 && distance > 2.6)
        {
            sound.pitch = 2.4f;
            num = 48;
            Debug.Log("2.4 Pitch");
        }
        if (distance < 2.6 && distance > 2.55)
        {
            sound.pitch = 2.45f;
            num = 49;
            Debug.Log("2.45 Pitch");
        }
        if (distance < 2.55 && distance > 2.5)
        {
            sound.pitch = 2.5f;
            num = 50;
            Debug.Log("2.5 Pitch");
        }
        if (distance < 2.5 && distance > 2.45)
        {
            sound.pitch = 2.55f;
            num = 51;
            Debug.Log("2.55 Pitch");
        }
        if (distance < 2.45 && distance > 2.4)
        {
            sound.pitch = 2.6f;
            num = 52;
            Debug.Log("2.6 Pitch");
        }
        if (distance < 2.4 && distance > 2.35)
        {
            sound.pitch = 2.65f;
            num = 53;
            Debug.Log("2.65 Pitch");
        }
        if (distance < 2.35 && distance > 2.3)
        {
            sound.pitch = 2.7f;
            num = 54;
            Debug.Log("2.7 Pitch");
        }
        if (distance < 2.3 && distance > 2.25)
        {
            sound.pitch = 2.75f;
            num = 55;
            Debug.Log("2.75 Pitch");
        }
        if (distance < 2.25 && distance > 2.2)
        {
            sound.pitch = 2.8f;
            num = 56;
            Debug.Log("2.8 Pitch");
        }
        if (distance < 2.2 && distance > 2.15)
        {
            sound.pitch = 2.85f;
            num = 57;
            Debug.Log("2.85 Pitch");
        }
        if (distance < 2.15 && distance > 2.1)
        {
            sound.pitch = 2.9f;
            num = 58;
            Debug.Log("2.9 Pitch");
        }
        if (distance < 2.1 && distance > 2.05)
        {
            sound.pitch = 2.95f;
            num = 59;
            Debug.Log("2.95 Pitch");
        }
        if (distance < 2.05 && distance > 2)
        {
            sound.pitch = 3f;
            num = 60;
            Debug.Log("3 Pitch");
        }
        if (distance < 2 && distance > 1.95)
        {
            sound.pitch = 3.05f;
            num = 61;
            Debug.Log("3.05 Pitch");
        }
        if (distance < 1.95 && distance > 1.9)
        {
            sound.pitch = 3.1f;
            num = 62;
            Debug.Log("3.1 Pitch");
        }
        if (distance < 1.9 && distance > 1.85)
        {
            sound.pitch = 3.15f;
            num = 63;
            Debug.Log("3.15 Pitch");
        }
        if (distance < 1.85 && distance > 1.8)
        {
            sound.pitch = 3.2f;
            num = 64;
            Debug.Log("3.2 Pitch");
        }
        if (distance < 1.8 && distance > 1.75)
        {
            sound.pitch = 3.25f;
            num = 65;
            Debug.Log("3.25 Pitch");
        }
        if (distance < 1.75 && distance > 1.7)
        {
            sound.pitch = 3.3f;
            num = 66;
            Debug.Log("3.3 Pitch");
        }
        if (distance < 1.7 && distance > 1.65)
        {
            sound.pitch = 3.35f;
            num = 67;
            Debug.Log("3.35 Pitch");
        }
        if (distance < 1.65 && distance > 1.6)
        {
            sound.pitch = 3.4f;
            num = 68;
            Debug.Log("3.4 Pitch");
        }
        if (distance < 1.6 && distance > 1.55)
        {
            sound.pitch = 3.45f;
            num = 69;
            Debug.Log("3.45 Pitch");
        }
        if (distance < 1.55 && distance > 1.5)
        {
            sound.pitch = 3.5f;
            num = 70;
            Debug.Log("3.5 Pitch");
        }
        if (distance < 1.5 && distance > 1.45)
        {
            sound.pitch = 3.55f;
            num = 71;
            Debug.Log("3.55 Pitch");
        }
        if (distance < 1.45 && distance > 1.4)
        {
            sound.pitch = 3.6f;
            num = 72;
            Debug.Log("3.6 Pitch");
        }
        if (distance < 1.4 && distance > 1.35)
        {
            sound.pitch = 3.65f;
            num = 73;
            Debug.Log("3.65 Pitch");
        }
        if (distance < 1.35 && distance > 1.3)
        {
            sound.pitch = 3.7f;
            num = 74;
            Debug.Log("3.7 Pitch");
        }
        if (distance < 1.3 && distance > 1.25)
        {
            sound.pitch = 3.75f;
            num = 75;
            Debug.Log("3.75 Pitch");
        }
        if (distance < 1.25 && distance > 1.2)
        {
            sound.pitch = 3.8f;
            num = 76;
            Debug.Log("3.8 Pitch");
        }
        if (distance < 1.2 && distance > 1.15)
        {
            sound.pitch = 3.85f;
            num = 77;
            Debug.Log("3.85 Pitch");
        }
        if (distance < 1.15 && distance > 1.1)
        {
            sound.pitch = 3.9f;
            num = 78;
            Debug.Log("3.9 Pitch");
        }
        if (distance < 1.1 && distance > 1.05)
        {
            sound.pitch = 3.95f;
            num = 79;
            Debug.Log("3.95 Pitch"); 
        }
        if (distance < 1.05 && distance > 1 || distance <= 1)
        {
            sound.pitch = 4f;
            num = 80;
            Debug.Log("4 Pitch"); 
        }
    }
}
