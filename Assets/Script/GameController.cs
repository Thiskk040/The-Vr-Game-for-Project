using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //public TMPro.TextMeshPro scoreLabel;
    public TextMesh scoreLabel;
    public int score = 0;
    //public int hp = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        scoreLabel.text = "Score : " + score;
        getScore();
        //hpLabel.text = "Live : " + hp;
        PressbuttontoSetting();

        
    }
    public void getScore()
    {
        score = saberL.scoreL + saberR.scoreR;
    }

    public void PressbuttontoSetting()
    {
        if(OVRInput.GetDown(OVRInput.Button.Start))
        {
            SceneManager.LoadScene(4);
        }
    }


    //public void getDamage()
    //{
    //    hp = hp - 1;
    //}
}
