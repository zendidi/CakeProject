using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouldHelp : MonoBehaviour
{
    Transform t;
    public GameObject rotatePoint;
    public GameObject test;

    void Start()
    {
        t = transform;
    }

    void Update()
    {
        if (!test.GetComponent<settings_menu>().activited)
            t.eulerAngles = new Vector3(0, t.rotation.x,- rotatePoint.transform.rotation.z);
    }

    
}
