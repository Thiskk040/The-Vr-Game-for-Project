using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PressKeyOpenDoor : MonoBehaviour
{
    [SerializeField] public GameObject Instruction;
    //public GameObject AnimeObject;
    public GameObject ThisTrigger;
    [SerializeField] public int Scene;
    //public AudioSource DoorOpenSound;
    public bool Action = false;

    void Start()
    {
        Instruction.SetActive(false);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
    }


    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (Action == true)
            {
                Instruction.SetActive(false);
                //AnimeObject.GetComponent<Animator>().Play("DoorOpen");
                SceneManager.LoadScene(Scene);
                ThisTrigger.SetActive(false);
                //DoorOpenSound.Play();
                Action = false;
            }
        }

    }
}


