using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineView : MonoBehaviour
{


    public LineRenderer theLine;
    public GameObject points;
    List<Transform> wayPointsData;

    // Start is called before the first frame update
    void Start()
    {
        wayPointsData = new List<Transform>();
        for (int i = 0; i < 5; i++)
        {
            wayPointsData.Add(points.transform.GetChild(i));
            Debug.Log(wayPointsData[i]);

        }
        theLine.positionCount = 5;
        theLine.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            creatPath();
        }
    }

    void creatPath()
    {
        for (int i = 0; i < 5; i++)
        {
            theLine.SetPosition(i, wayPointsData[i].position);
        }
    }
}
