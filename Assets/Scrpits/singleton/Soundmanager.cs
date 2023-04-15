using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanager : MonoBehaviour
{
    private static Soundmanager Soundmanager_Instant;
    public static Soundmanager GetInstant() { return Soundmanager_Instant; }
    public GameObject jabsound, hooksound, uppercutsound;

    public void add_sound(int temp)
    {
        if (temp == 1 || temp == 4)
        {
            Instantiate(hooksound, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (temp == 2 || temp == 5)
        {
            Instantiate(uppercutsound, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(jabsound, new Vector3(0, 0, 0), Quaternion.identity);
        }
       
    }
}
