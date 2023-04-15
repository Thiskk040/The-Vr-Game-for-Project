using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Spawn_box : MonoBehaviour
{
    public Transform prefab;
    public GameObject MusicManager;
    private GameObject temp_gameobject;
   
    void Start()
    {
       
    }
    float music_time = 0;
    void Update()
    {

        music_time = MusicManager.GetComponent<Music>().music_time;
        Beat_detect();
       // Debug.Log(music_time);
    }
    int temp_i = 0;
    bool temp_check = true;
    void Beat_detect()
    {
       if(temp_i < MusicManager.GetComponent<Music>().beat_list.Count)
        {
            if (MusicManager.GetComponent<Music>().beat_list.Count == 0)
            {
                Debug.Log("End");
            }
            else if (music_time > MusicManager.GetComponent<Music>().beat_list[temp_i].time)
            {
                if (MusicManager.GetComponent<Music>().beat_list[temp_i].time == 0 && temp_check)
                {
                    Debug.Log("Out of beat limit");
                    temp_check = false;
                }
                else if (MusicManager.GetComponent<Music>().beat_list[temp_i].time != 0 )
                {
                    //Debug.Log("detect");
                    Instantiate(MusicManager.GetComponent<Music>().beat_list[temp_i].prefabs, new Vector3(prefab.transform.position.x, prefab.transform.position.y, prefab.transform.position.z), Quaternion.identity);
                    temp_i += 1;
                }
                else
                {
                  //  Debug.Log("Who the fuck are you");
                }

            }
        }
       
    }
}
