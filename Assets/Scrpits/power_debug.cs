using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_debug : MonoBehaviour
{
    public Material red, blue, green;
    MeshRenderer meshRenderer;
    Material oldMaterial;
    int power = 5;
    void Start()
    {
         meshRenderer = GetComponent<MeshRenderer>();
         oldMaterial = meshRenderer.material;
       
    }

    // Update is called once per frame
    void Update()
    {
        get_power();
       

    }
    void get_power()
    {
        if(power != Gamemanager.GetInstant().power_rank)
        {
            power = Gamemanager.GetInstant().power_rank;
            switch (power)
            {
                case 1:
                    meshRenderer.material = red;
                    break;
                case 2:
                    meshRenderer.material = blue;
                    break;
                case 3:
                    meshRenderer.material = green;
                    break;
                default:
                   // Debug.Log("Unknow power");
                    break;
            }
        }
        else
        {

        }
       
    }
}
