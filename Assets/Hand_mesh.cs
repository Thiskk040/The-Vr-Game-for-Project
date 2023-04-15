using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class Hand_mesh : MonoBehaviour
{
    // Start is called before the first frame update
    private InputDevice targetdevice;
    List<InputDevice> devices = new List<InputDevice>();
    InputDeviceCharacteristics leftcontroler = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
    InputDeviceCharacteristics rightcontroler = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;

    void Start()
    {
        InputDevices.GetDevicesWithCharacteristics(leftcontroler, devices);
        InputDevices.GetDevicesWithCharacteristics(rightcontroler, devices);

        foreach (var item in devices)
        {
         //   Debug.Log(item.name + item.characteristics);
        }
        if (devices.Count > 0)
        {
            targetdevice = devices[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        temp_getvalue();
        targetdevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerButton);
        if (triggerButton)
        {
            //Debug.Log("Left");
        }


    }
    float r_grove_x, r_grove_y, r_grove_z;
    float l_grove_x, l_grove_y, l_grove_z;
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
    void fever_rotation()
    {
        float fever_l_xmin = -30 , fever_l_ymin = 60, fever_l_zmin= -100, fever_r_xmin=-40, fever_r_ymin=-120, fever_r_zmin=50;
        float fever_l_xmax = 50, fever_l_ymax = 140, fever_l_zmax=-40, fever_r_xmax=40, fever_r_ymax=-40, fever_r_zmax=150;
        if (l_grove_x > fever_l_xmin && l_grove_x < fever_l_xmax &&
          l_grove_y > fever_l_ymin && l_grove_y < fever_l_ymax &&
          l_grove_z > fever_l_zmin && l_grove_z < fever_l_zmax&&
          r_grove_x > fever_r_xmin && r_grove_x < fever_r_xmax &&
          r_grove_y > fever_r_ymin && r_grove_y < fever_r_ymax &&
          r_grove_z > fever_r_zmin && r_grove_z < fever_r_zmax
          )
        {
            Gamemanager.GetInstant().fever_stage();
        }
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "Mesh_L")
        {
            if(other.gameObject.tag == "Mesh_R")
            {
                fever_rotation();
            }
        }

    }


    }
