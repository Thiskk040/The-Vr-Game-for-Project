using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Following : MonoBehaviour
{
    public PathCreator pathCreator;
    public EndOfPathInstruction endOfPathInstruction;
    float speed = 40;
    float distance;
    [SerializeField]
    bool left_jab=false, left_hook = false, left_upper = false, right_jab = false, right_hook = false, right_upper = false;
   
   
    float  r_grove_x,r_grove_y,r_grove_z;
    float  l_grove_x,l_grove_y,l_grove_z;
    void temp_getvalue()
    {       
        r_grove_x = GameObject.FindGameObjectWithTag("R_log").GetComponent<Rotation_check>().right_hand_x;
        r_grove_y = GameObject.FindGameObjectWithTag("R_log").GetComponent<Rotation_check>().right_hand_y;
        r_grove_z = GameObject.FindGameObjectWithTag("R_log").GetComponent<Rotation_check>().right_hand_z;

        l_grove_x = GameObject.FindGameObjectWithTag("L_log").GetComponent<Rotation_check>().left_hand_x;
        l_grove_y = GameObject.FindGameObjectWithTag("L_log").GetComponent<Rotation_check>().left_hand_y;
        l_grove_z = GameObject.FindGameObjectWithTag("L_log").GetComponent<Rotation_check>().left_hand_z;
      // Debug.Log(l_grove_x);
    }
    private void Start()
    {
         speed = 40;
        // Debug.Log(this.gameObject.tag);
        condition_setup();

    }
    void Update()
    {       
        distance += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distance);
        speed_change();
        temp_getvalue();       
    }
    float time = 0;
    void speed_change()
    {
        time += Time.deltaTime;
        if (time >= 0.4f)
        {
            speed = 5;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!Gamemanager.GetInstant().fever)
        {
            if (other.gameObject.tag == "End_path_wall")
            {
                Destroy(this.gameObject);          //Debug.Log(time);
            }
            else if (other.gameObject.tag == "right_grove" && right_jab)
            {
                hit_tpye(0);
            }
            else if (other.gameObject.tag == "right_grove" && right_hook)
            {
                hit_tpye(1);
            }
            else if (other.gameObject.tag == "right_grove" && right_upper)
            {
                hit_tpye(2);
            }
            else if (other.gameObject.tag == "left_grove" && left_jab)
            {
                hit_tpye(3);
            }
            else if (other.gameObject.tag == "left_grove" && left_hook)
            {
                hit_tpye(4);
            }
            else if (other.gameObject.tag == "left_grove" && left_upper)
            {
                hit_tpye(5);
            }
            else if (other.gameObject.tag == "right_grove")
            {
                hit_tpye(6);
            }
            else if (other.gameObject.tag == "left_grove")
            {
                hit_tpye(7);
            }
        }
        if (Gamemanager.GetInstant().fever)
        {
             if (other.gameObject.tag == "right_grove" || other.gameObject.tag == "left_grove")
            {
                hit_tpye(8);
            }
        }
     
        //fever here
    }
    public GameObject hit_sound;
    void add_sound()
    {
        Instantiate(hit_sound, new Vector3(0, 0, 0), Quaternion.identity);
    }
    float R_grovejab_x_min = -40,
          R_grovejab_x_max = 20;
    float R_grovejab_y_min = -34,
          R_grovejab_y_max = 120;
    float R_grovejab_z_min = 20,
          R_grovejab_z_max = 150;

    float R_grovehook_x_min = -20,
          R_grovehook_x_max = 35;
    float R_grovehook_y_min = -120,
          R_grovehook_y_max = -35;
    float R_grovehook_z_min = 20,
          R_grovehook_z_max = 150;

    float R_groveupper_x_min = -120,
          R_groveupper_x_max = -21;
    float R_groveupper_y_min = -60,
          R_groveupper_y_max = 60;
    float R_groveupper_z_min = -90,
          R_groveupper_z_max = 20;

    // -9 23 -75
    float L_grovejab_x_min = -40, 
          L_grovejab_x_max = 20;
    float L_grovejab_y_min = -40,
          L_grovejab_y_max = 49;
    float L_grovejab_z_min = -100,
          L_grovejab_z_max = 20;

    float L_grovehook_x_min = -30,
          L_grovehook_x_max = 30;
    float L_grovehook_y_min = 50,
          L_grovehook_y_max = 100;
    float L_grovehook_z_min = -120,
          L_grovehook_z_max = -70;

    float L_groveupper_x_min = -120,
          L_groveupper_x_max = -28;
    float L_groveupper_y_min = -20,
          L_groveupper_y_max = 100;
    float L_groveupper_z_min = -20,
          L_groveupper_z_max = 100;


    void hit_tpye(int hit_pattern)
    {
        left_h_speed = Gamemanager.GetInstant().left_hit_speed;
        right_h_speed = Gamemanager.GetInstant().right_hit_speed;
        if (Gamemanager.GetInstant().fever && hit_pattern == 8)
        {
            Gamemanager.GetInstant().hit_type = "fever";
            Destroy(this.gameObject);
            Gamemanager.GetInstant().add_sound(0);

        }
        else
        {
            if (r_grove_x > R_grovejab_x_min && r_grove_x < R_grovejab_x_max &&
          r_grove_y > R_grovejab_y_min && r_grove_y < R_grovejab_y_max &&
          r_grove_z > R_grovejab_z_min && r_grove_z < R_grovejab_z_max && hit_pattern == 0)
            {
                Gamemanager.GetInstant().hit_type = "r_jab";
                Destroy(this.gameObject);
                Gamemanager.GetInstant().add_sound(0);
            }

            else if (r_grove_x > R_grovehook_x_min && r_grove_x < R_grovehook_x_max &&
                     r_grove_y > R_grovehook_y_min && r_grove_y < R_grovehook_y_max &&
                     r_grove_z > R_grovehook_z_min && r_grove_z < R_grovehook_z_max && hit_pattern == 1)
            {
                Gamemanager.GetInstant().hit_type = "r_hook";
                Destroy(this.gameObject);
                Gamemanager.GetInstant().add_sound(1);
            }

            else if (r_grove_x > R_groveupper_x_min && r_grove_x < R_groveupper_x_max &&
                     r_grove_y > R_groveupper_y_min && r_grove_y < R_groveupper_y_max &&
                     r_grove_z > R_groveupper_z_min && r_grove_z < R_groveupper_z_max && hit_pattern == 2)
            {
                Gamemanager.GetInstant().hit_type = "r_uppercut";
                Destroy(this.gameObject);
                Gamemanager.GetInstant().add_sound(2);
            }
            else if (l_grove_x > L_grovejab_x_min && l_grove_x < L_grovejab_x_max &&
                     l_grove_y > L_grovejab_y_min && l_grove_y < L_grovejab_y_max &&
                     l_grove_z > L_grovejab_z_min && l_grove_z < L_grovejab_z_max && hit_pattern == 3)
            {
                Gamemanager.GetInstant().hit_type = "l_jab";
                Destroy(this.gameObject);
                Gamemanager.GetInstant().add_sound(3);
            }

            else if (l_grove_x > L_grovehook_x_min && l_grove_x < L_grovehook_x_max &&
                    l_grove_y > L_grovehook_y_min && l_grove_y < L_grovehook_y_max &&
                    l_grove_z > L_grovehook_z_min && l_grove_z < L_grovehook_z_max && hit_pattern == 4)
            {
                Gamemanager.GetInstant().hit_type = "l_hook";
                Destroy(this.gameObject);
                Gamemanager.GetInstant().add_sound(4);
            }

            else if (l_grove_x > L_groveupper_x_min && l_grove_x < L_groveupper_x_max &&
                    l_grove_y > L_groveupper_y_min && l_grove_y < L_groveupper_y_max &&
                    l_grove_z > L_groveupper_z_min && l_grove_z < L_groveupper_z_max && hit_pattern == 5)
            {
                Gamemanager.GetInstant().hit_type = "l_uppercut";
                Destroy(this.gameObject);
                Gamemanager.GetInstant().add_sound(5);
            }
            else
            {
                if (left_jab || left_hook || left_upper && hit_pattern == 6)
                {
                    Gamemanager.GetInstant().hit_type = "l_unknow";
                    Destroy(this.gameObject);
                    Gamemanager.GetInstant().add_sound(0);
                }
                else if (right_jab || right_hook || right_upper && hit_pattern == 7)
                {
                    Gamemanager.GetInstant().hit_type = "r_unknow";
                    Destroy(this.gameObject);
                    Gamemanager.GetInstant().add_sound(0);
                }
            }
          
        }
        Gamemanager.GetInstant().Calculate();
    }
    public float left_h_speed;
    public float right_h_speed;
 
    
    void condition_setup()
    {
        if (this.gameObject.tag == "left_jab")
        {
            left_jab = true;
        }
        else if (this.gameObject.tag == "left_hook")
        {
            left_hook = true;
        }
        else if (this.gameObject.tag == "left_uppercut")
        {
            left_upper = true;
        }
        else if (this.gameObject.tag == "right_jab")
        {
            right_jab = true;
        }
        else if (this.gameObject.tag == "right_hook")
        {
            right_hook = true;
        }
        else if (this.gameObject.tag == "right_uppercut")
        {
            right_upper = true;
        }
    }
}
