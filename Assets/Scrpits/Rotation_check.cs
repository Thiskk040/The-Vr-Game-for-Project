using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;
using UnityEngine.XR;
public class Rotation_check : MonoBehaviour
{
    public float left_hand_x, left_hand_y, left_hand_z;
    public float right_hand_x, right_hand_y, right_hand_z;
  //  public Text left_hand_x_text, left_hand_y_text, left_hand_z_text;
  //  public Text right_hand_x_text, right_hand_y_text, right_hand_z_text;
    bool left;
    void Start()
    {
       
        if (this.gameObject.tag == "L_log") 
        {
            left = true;
        }
        else if (this.gameObject.tag == "R_log")
        {
            left = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Get_hand_rotation();
       // set_text();
        
    }
    void fever_stage()
    {
        Gamemanager.GetInstant().fever = true;

    }
    void Get_hand_rotation()
    {
        left_hand_x = transform.localEulerAngles.x;
        left_hand_x = (left_hand_x > 180) ? left_hand_x - 360 : left_hand_x;


        left_hand_y = transform.localEulerAngles.y;
        left_hand_y = (left_hand_y > 180) ? left_hand_y - 360 : left_hand_y;

        left_hand_z = transform.localEulerAngles.z;
        left_hand_z = (left_hand_z > 180) ? left_hand_z - 360 : left_hand_z;

        right_hand_x = transform.localEulerAngles.x;
        right_hand_x = (right_hand_x > 180) ? right_hand_x - 360 : right_hand_x;


        right_hand_y = transform.localEulerAngles.y;
        right_hand_y = (right_hand_y > 180) ? right_hand_y - 360 : right_hand_y;

        right_hand_z = transform.localEulerAngles.z;
        right_hand_z = (right_hand_z > 180) ? right_hand_z - 360 : right_hand_z;



    }
    public string temp,temp2;
   /* void set_text()
    {
        if (left)
        {
            temp = (left_hand_x.ToString("F2") + "," + left_hand_y.ToString("F2") + "," + left_hand_z.ToString("F2"));
            left_hand_x_text.text = temp;
        }
       else if (!left)
        {
            temp2 = (right_hand_x.ToString("F2") + "," + right_hand_y.ToString("F2") + "," + right_hand_z.ToString("F2"));
            right_hand_x_text.text = temp2;
        }
       

    }*/
   

}
