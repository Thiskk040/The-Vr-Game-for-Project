using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timescript : MonoBehaviour
{
    public float Timeleft;
    public bool timerOn =  false;
    public TextMesh TimerTXT;
    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        PressButtonSetting();
        if (timerOn)
        {
            if (Timeleft > 0)
            {
                Timeleft -= Time.deltaTime;
                updateTime(Timeleft);
            }
            else
            {
                Debug.Log("Time is up");
                Timeleft = 0;
                timerOn = false;
                SceneManager.LoadScene(0);
            }
        }
    }

    void updateTime(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTXT.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
    
     public void PressButtonSetting()
    {
        if(OVRInput.GetDown(OVRInput.Button.Start))
        {
            SceneManager.LoadScene(4);
        }
    }
}
