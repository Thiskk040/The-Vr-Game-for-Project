using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_stage : MonoBehaviour
{

    public Button Stage_1,Stage_2, Stage_3,Play;
  

    private void Start()
    {
        
        Stage_1.onClick.AddListener(delegate { Confirm_stage(1); });
        Stage_2.onClick.AddListener(delegate { Confirm_stage(2); });
        Stage_3.onClick.AddListener(delegate { Confirm_stage(3); });
        

    }
    void Update()
    {
        update_stage_togo();
    }
   
  
   
    int go_stage = 5;
    void Confirm_stage(int temp_stage)
    {
        go_stage = temp_stage;
    }

    [SerializeField]
    int temp;
    void update_stage_togo()
    {
        if(go_stage != temp)
        {
            temp = go_stage;          
        }
    }
    public void load_to_play()
    {
        SceneManager.LoadScene(temp);
        
    }
   public GameObject guide;
    public void open_guide()
    {
        guide.SetActive(true);
    }
    public void close_guide()
    {
        guide.SetActive(false);
    }
}
