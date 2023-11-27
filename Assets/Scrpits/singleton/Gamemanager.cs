using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;
using DG.Tweening;
public class Gamemanager : MonoBehaviour
{
    private static Gamemanager GameManager_Instant;
    public static Gamemanager GetInstant() { return GameManager_Instant; }

    public float temp;
    public float Timeleft;
    public bool TimerOn = false;
    public Text TimerTxt;
    public int power_rank = 5;
    public string hit_type;
    public float left_hit_speed,right_hit_speed;
    public bool primary_hit;
    public bool fever = false;

    public Text score_text;
    public Text multiply_text;
    public Text Gamevoer_score_text,Gameover_highscore_text;
    public Text combo_text;

    public List<GameObject> Star = new List<GameObject>();
    public GameObject Particle;

    public List<Mat> The_Material = new List<Mat>(); 

    private InputDevice targetdevice;
    List<InputDevice> devices = new List<InputDevice>();
    InputDeviceCharacteristics leftcontroler = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
    InputDeviceCharacteristics rightcontroler = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;

    private void Awake()
    {
        if (GameManager_Instant == null)
        {
            GameManager_Instant = this;
        }
        else
        {
            Destroy(gameObject);
        }

        foreach (var item in Star)
        {
            item.transform.DOScale(0f,.1f);
            item.SetActive(false);
        }
    }
    void Start()
    {
        TimerOn = true;
        raycast_set();
        InputDevices.GetDevicesWithCharacteristics(leftcontroler, devices);
        InputDevices.GetDevicesWithCharacteristics(rightcontroler, devices);
        foreach (var item in devices)
        {
        //    Debug.Log(item.name + item.characteristics);
        }
        if (devices.Count > 0)
        {
            targetdevice = devices[0];
        }
    }
    void Update()
    {
        if(TimerOn)
        {
            if(Timeleft > 0)
            {
                Timeleft -= Time.deltaTime;
                updatetimer(Timeleft);
                PressButtontoMain();
            }
            else
            {
                Debug.Log("Time is up");
                Timeleft = 0;
                SceneManager.LoadScene(0);
                TimerOn = false;
            }
        }    
        if(SceneManager.GetActiveScene().name != "Menu")
        {
             if(fever)
             {
                 Particle.SetActive(true);
                 Set_Mat();


             }
             else
             {
                 Reset_Mat();
                 Particle.SetActive(false);
             }
        }
    }
    string temp_type;
    public void PressButtontoMain()
    {
        if(OVRInput.GetDown(OVRInput.Button.Start))
        {
            SceneManager.LoadScene(4);
        }
    }
    void updatetimer(float currenttime)
    {
        currenttime += 1;

        float minutes = Mathf.FloorToInt(currenttime / 60);
        float seconds = Mathf.FloorToInt(currenttime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
   public void Calculate()
    {
      
        switch (hit_type)
        {
            case "l_jab":
                {
                    speed_check(true,hit_type);
                    break;
                }
            case "l_hook":
                {
                    speed_check(true, hit_type);
                    break;
                }
            case "l_uppercut":
                {
                    speed_check(true, hit_type);
                    break;
                }
            case "r_jab":
                {
                    speed_check(false, hit_type);
                    break;
                }
            case "r_hook":
                {
                    speed_check(false, hit_type);
                    break;
                }
            case "r_uppercut":
                {
                    speed_check(false, hit_type);
                    break;
                }
            case "l_unknow":
                {
                    speed_check(true, hit_type);
                    break;
                }
            case "r_unknow":
                {
                    speed_check(false, hit_type);
                    break;
                }
            case "fever":
                {
                    speed_check(true, hit_type);
                    break;
                }
        }
        
    }
    int combo = 0;
    public void speed_check(bool primary, string tpye)
    {
        float power1_min = 0, power1_max = 5;
        float power2_min = 5, power2_max = 10;
        float power3_min = 10;
        if (tpye == "l_jab" || tpye == "r_jab")
        {
            power1_min = 0;
            power1_max = 5;
            power2_min = 5;
            power2_max = 10;
            power3_min = 10;
        }
       else if (tpye == "l_hook" || tpye == "r_hook")
        {
            power1_min = 0;
            power1_max = 7;
            power2_min = 7;
            power2_max = 13;
            power3_min = 13;
        }
        else if (tpye == "l_upppercut" || tpye == "r_upppercut")
        {
            power1_min = 0;
            power1_max = 10;
            power2_min = 10;
            power2_max = 18;
            power3_min = 18;
        }
       else if (tpye == "l_unknow")
        {

            if (left_hit_speed >= 0 && left_hit_speed <= 5)
            {
                power_rank = 1;
            }
            else if (left_hit_speed > 5 && left_hit_speed <= 10)
            {
                power_rank = 2;
            }
            else if (left_hit_speed > 10)
            {
                power_rank = 3;
            }
        }
        else if (tpye == "r_unknow")
        {
            if (right_hit_speed >= 0 && right_hit_speed <= 5)
            {
                power_rank = 1;
            }
            else if (right_hit_speed >5 && right_hit_speed <= 10)
            {
                power_rank = 2;
            }
            else if (right_hit_speed > 10)
            {
                power_rank = 3;
            }
        }
        else if (primary &&tpye == "fever")
        {

              
                power_rank = 3;
            
        }
        else if (!primary && tpye == "fever")
        {


            power_rank = 3;

        }
        else
        {
            Debug.Log("WTF is this shit");
        }
        Debug.Log("Tpye: " + hit_type + " " + left_hit_speed + "," + right_hit_speed + " Power: " + power_rank);
        temp_type = tpye;
        combo_check(power_rank);
    }
    public int fever_score=0;
    public int fever_floor;
    public void combo_check(int power)
    {
        if(power == 2||power == 3)
        {
            combo += 1;
            if(fever_score < fever_floor)
            {
                fever_score += 1;
            }
            
        }
        else if (power == 1)
        {
            combo = 0;
            fever_score = 0;
        }
        else
        {
            Debug.Log("wtf");
        }
        combo_cal();
    }
    void combo_cal()
    {
        if (combo == 0 || combo == 1)
        {
            score_multiply = 1;
        }
        else if (combo == 2)
        {
            score_multiply = 2;
        }
        else if (combo == 4)
        {
            score_multiply = 4;
        }
        else if (combo >= 8)
        {
            score_multiply = 8;
        }
        score_calculate();
    }
    public int score =0;
    public int score_multiply;
    int temp_score;
    public void score_calculate()
    {
        if(temp_type != "l_unknow" && temp_type != "r_unknow")
        {
            temp_score = 100;           
        }
        else
        {
            temp_score = 50;           
        }
        score += (temp_score) * score_multiply;
        show_score_text();
    }
    public void show_score_text()
    {
        score_text.text = score.ToString();
        multiply_text.text = "*"+score_multiply.ToString();
        Gamevoer_score_text.text = score.ToString();
        combo_text.text = combo.ToString();
    }
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
    public void fever_stage()
    {
        targetdevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerButton);
        if (triggerButton && fever_score == fever_floor)
        {
            fever = true;
            StartCoroutine(delay_fever());
        }
    }
    IEnumerator delay_fever()
    {
        yield return new WaitForSeconds(15f);
        fever = false;
    }
    public GameObject r_log,l_log;
    public bool raycast_check;
    public void raycast_set()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            r_log.GetComponent<XRRayInteractor>().enabled = true;
            l_log.GetComponent<XRRayInteractor>().enabled = true;
        }
        else if (SceneManager.GetActiveScene().name != "Menu" && raycast_check == true)
        {
            r_log.GetComponent<XRRayInteractor>().enabled = true;
            l_log.GetComponent<XRRayInteractor>().enabled = true;
        }
     
    }
    public void Reset_scene()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowStar()
    {
        int Star_Num;
        Star_Num = score / 30000;
        if(Star_Num >5)
        {
            Star_Num = 5;
        }
        for (int i = 0; i < Star_Num; i++)
        {
            Star[i].SetActive(true);
            Star[i].transform.DOScale(1,.5f).SetEase(Ease.OutBack);
        }

    }

    public void Set_Mat()
    {
        //0
        The_Material[0]._Material[0].SetColor("_EmissionColor", The_Material[0].FeverColor * The_Material[0].Multi_Emiss);
       ///1
        The_Material[1]._Material[0].SetColor("_EmissionColor", The_Material[1].FeverColor * The_Material[1].Multi_Emiss);
        ////2
        The_Material[2]._Material[0].SetColor("_EmissionColor", The_Material[2].FeverColor * The_Material[2].Multi_Emiss);
        The_Material[2]._Material[1].SetColor("_EmissionColor", The_Material[2].FeverColor * The_Material[2].Multi_Emiss);
        ////3
        The_Material[3]._Material[0].SetColor("_EmissionColor", The_Material[3].FeverColor * The_Material[3].Multi_Emiss);
        The_Material[3]._Material[1].SetColor("_EmissionColor", The_Material[3].FeverColor * The_Material[3].Multi_Emiss);
        ////4
        The_Material[4]._Material[0].SetColor("_EmissionColor", The_Material[4].FeverColor * The_Material[4].Multi_Emiss);
        The_Material[4]._Material[1].SetColor("_EmissionColor", The_Material[4].FeverColor * The_Material[4].Multi_Emiss);
    }
    public void Reset_Mat()
    {
        //0
        The_Material[0]._Material[0].SetColor("_EmissionColor", The_Material[0].restColor * The_Material[0].Multi_Emiss);
        ///1
        The_Material[1]._Material[0].SetColor("_EmissionColor", The_Material[1].restColor * The_Material[1].Multi_Emiss);
        ////2
        The_Material[2]._Material[0].SetColor("_EmissionColor", The_Material[2].restColor * The_Material[2].Multi_Emiss);
        The_Material[2]._Material[1].SetColor("_EmissionColor", The_Material[2].restColor * The_Material[2].Multi_Emiss);
        ////3
        The_Material[3]._Material[0].SetColor("_EmissionColor", The_Material[3].restColor * The_Material[3].Multi_Emiss);
        The_Material[3]._Material[1].SetColor("_EmissionColor", The_Material[3].restColor * The_Material[3].Multi_Emiss);
        ////4
        The_Material[4]._Material[0].SetColor("_EmissionColor", The_Material[4].restColor * The_Material[4].Multi_Emiss);
        The_Material[4]._Material[1].SetColor("_EmissionColor", The_Material[4].restColor * The_Material[4].Multi_Emiss);

    }
    public int highscore;
    public void score_set()
    {    
        if(SceneManager.GetActiveScene().name == "Nameofgod")
        {
            highscore = PlayerPrefs.GetInt("Highscore1");         
        }
        else if (SceneManager.GetActiveScene().name == "SlowDanceNight_1")
        {
            highscore = PlayerPrefs.GetInt("Highscore2");
        }
        else if (SceneManager.GetActiveScene().name == "Runin_2")
        {
            highscore = PlayerPrefs.GetInt("Highscore3");
        }
        Gameover_highscore_text.text = highscore.ToString();
    }
}

[System.Serializable]
public class Mat
{
    public string name;
    public List<Material> _Material = new List<Material>();
    public float Multi_Emiss;
    public Color FeverColor;
    public Color restColor ;
}
