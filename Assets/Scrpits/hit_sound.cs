using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_sound : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject music;
    void Start()
    {
        StartCoroutine(music_delay());
    }

    // Update is called once per frame
    IEnumerator music_delay()
    {
        yield return new WaitForSeconds(5f);
        music.SetActive(true);
    }
}
