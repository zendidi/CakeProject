using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTestLab : MonoBehaviour
{
    public float leanMove;
    public float leanMoveTime;
    public float waitTime=3;
    float runningTime;
    bool changeDir;
    Transform initPos;
    float toMove;
    void Start()
    {
        changeDir = true;
        initPos = transform;
        changeDir = transform.position.x == 7.5 ? false : true;
    }

    private void Update()
    {
        if (runningTime > (3 + leanMoveTime))
        {
            runningTime = 0;
            movingCrossLine();
        }
        runningTime += Time.deltaTime;
    }

    public void movingCrossLine()
    {
        toMove = changeDir == true ? 7.5f : -7.5f;
        LeanTween.moveX(gameObject, toMove, leanMoveTime);
        changeDir = !changeDir;
    }
}
