using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Test_Move : MonoBehaviour
{
    public float Min, Max, Time;
    // Start is called before the first frame update
    void Start()
    {
        Go();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Go()
    {
        transform.DOLocalMoveZ(Max, Time).OnComplete(Back);
    }
    public void Back()
    {
        transform.DOLocalMoveZ(Min, Time).OnComplete(Go);
    }
}
