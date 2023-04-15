using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_test : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject testsound1, testsound2, testsound3;
    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.A))
        {
            testsound1.GetComponent<AudioSource>().pitch = 1f;
            Instantiate(testsound1, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            testsound1.GetComponent<AudioSource>().pitch = 1.3f;
            Instantiate(testsound1, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            testsound1.GetComponent<AudioSource>().pitch = 1.6f;
            Instantiate(testsound1, new Vector3(0, 0, 0), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            testsound2.GetComponent<AudioSource>().pitch = 0.8f;
            Instantiate(testsound2, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            testsound2.GetComponent<AudioSource>().pitch = 1f;
            Instantiate(testsound2, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            testsound2.GetComponent<AudioSource>().pitch = 1.2f;
            Instantiate(testsound2, new Vector3(0, 0, 0), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            testsound3.GetComponent<AudioSource>().pitch = 0.55f;
            Instantiate(testsound3, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            testsound3.GetComponent<AudioSource>().pitch = 0.65f;
            Instantiate(testsound3, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            testsound3.GetComponent<AudioSource>().pitch = 0.75f;
            Instantiate(testsound3, new Vector3(0, 0, 0), Quaternion.identity);
        }

    }
}
