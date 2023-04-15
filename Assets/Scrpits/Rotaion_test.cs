using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotaion_test : MonoBehaviour
{
   
    float rotate_x, rotate_y, rotate_z;
    // Start is called before the first frame update
 
  //  public  Text right_speed, left_speed;
    bool primary_check = true;
    private bool _check_primary = true;
    void Start()
    {
     if(this.gameObject.tag == "left_grove")
        {
            primary_check = true;
        }
     else if (this.gameObject.tag =="right_grove")
        {
            primary_check = false;
        }
      
    }    
   
    Vector3 oldPosition;
    public int speed;
    public float hit_speed;
    void LateUpdate()
    {
        oldPosition = transform.position;
    }
    // Update is called once per frame
    public void show_text()
    {
        if (primary_check)
        {
          //  left_speed.text = hit_speed.ToString("F2");
            Gamemanager.GetInstant().left_hit_speed = hit_speed;
        }
        else
        {
           // right_speed.text = hit_speed.ToString("F2");
           Gamemanager.GetInstant().right_hit_speed = hit_speed;
        }
    }
    void Update()
    {

        hit_speed = ((transform.position - oldPosition).magnitude)*150;
        show_text();

        //Debug.Log(temp_test);
        rotate_x = transform.localEulerAngles.x;
        rotate_x = (rotate_x > 180) ? rotate_x - 360 : rotate_x;

        rotate_y = transform.localEulerAngles.y;
        rotate_y = (rotate_y > 180) ? rotate_y - 360 : rotate_y;

        rotate_z = transform.localEulerAngles.z;
        rotate_z = (rotate_z > 180) ? rotate_z - 360 : rotate_z;
    }
}
