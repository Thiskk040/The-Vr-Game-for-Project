using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    public GameObject target_lefthook;
    public GameObject target_leftjab;
    public GameObject target_leftup;
    public GameObject target_righthook;
    public GameObject target_rightjab;
    public GameObject target_rightup;
    Inputmaster inputmaster;
    public AudioClip thissong;

    public List<Target_tpye> beat_list = new List<Target_tpye>();
    public void Awake()
    {
        inputmaster = new Inputmaster();
    }
    private void OnEnable()
    {
        inputmaster.Enable();
    }
    private void OnDisable()
    {
        inputmaster.Disable();
    }
    void Start()
    {
       temp_beat_plus();
       
    }

    void temp_beat_plus()
    {
        for (int i = 0;i <=beat_list.Count-1;i++)
        {
            beat_list[i].time -= 0.5f;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        music_value();
        new_input();
     
       //Add_condition();
       //  Debug.Log(music_time);
    }
    [System.Serializable]
    public class Target_tpye
    {
        public float time;
        public GameObject prefabs;
    }
   public float music_time = 0;
    public  void music_value()
    {
        // running 229 sec;
        /// name if god 200sec;
        // delay for hit 1.9 sec;
        //210 lalala
        if (music_time < thissong.length+10)
        {
           music_time += Time.deltaTime;
           
        }
        else
        {
            Gamemanager.GetInstant().raycast_check = true;
            Gamemanager.GetInstant().raycast_set();
            gameovercanvas.SetActive(true);
            score_update();
            Gamemanager.GetInstant().ShowStar();

        }
       
    }
    bool temp_check = true;
    public void score_update()
    {
        if (temp_check)
        {
            temp_check = false;
            if (SceneManager.GetActiveScene().name == "Nameofgod")
            {
                if (Gamemanager.GetInstant().score >= PlayerPrefs.GetInt("Highscore1"))
                {
                    PlayerPrefs.SetInt("Highscore1", Gamemanager.GetInstant().score);
                }
            }
            else if (SceneManager.GetActiveScene().name == "SlowDanceNight_1")
            {
                if (Gamemanager.GetInstant().score >= PlayerPrefs.GetInt("Highscore2"))
                {
                    PlayerPrefs.SetInt("Highscore2", Gamemanager.GetInstant().score);
                }
            }
            else if (SceneManager.GetActiveScene().name == "Runin_2")
            {
                if (Gamemanager.GetInstant().score >= PlayerPrefs.GetInt("Highscore2"))
                {
                    PlayerPrefs.SetInt("Highscore3", Gamemanager.GetInstant().score);
                }
            }
        }
        Gamemanager.GetInstant().score_set();
    }
    public GameObject gameovercanvas;
    private int beat_number = 0;
    public void Beat_add(float spawn_time,GameObject tpye)
    {
        if(beat_number <= beat_list.Count)
        {
            spawn_time -= 1.8f;

            beat_list[beat_number].time = spawn_time;
            beat_list[beat_number].prefabs = tpye;
            beat_number++;
        }
        else
        {
            Debug.Log("Out of beat limit");
        }
    }

  

    
     void new_input()
     {
         inputmaster.Enable();
         float W_input = inputmaster.Music.addbeat_Ljab.ReadValue<float>();
         float D_input = inputmaster.Music.addbeat_Lhook.ReadValue<float>();
         float S_input = inputmaster.Music.addbeat_Luppercut.ReadValue<float>();
         float I_input = inputmaster.Music.addbeat_Rjab.ReadValue<float>();
         float J_input = inputmaster.Music.addbeat_Rhook.ReadValue<float>();
         float K_input = inputmaster.Music.addbeat_Ruppercut.ReadValue<float>();
         if (W_input > 0)
         {           
             Beat_add(music_time, target_leftjab);
            inputmaster.Disable();
        }
         if (D_input > 0)
         {
             Beat_add(music_time, target_lefthook);
            inputmaster.Disable();
        }
         if (S_input > 0)
         {
             Beat_add(music_time, target_leftup);
            inputmaster.Disable();
        }
         if (I_input > 0)
         {
             Beat_add(music_time, target_rightjab);
            inputmaster.Disable();
        }
         if (J_input > 0)
         {
             Beat_add(music_time, target_righthook);
            inputmaster.Disable();
        }
         if (K_input > 0)
         {
             Beat_add(music_time, target_rightup);
            inputmaster.Disable();
        }
        
     }
     
}
