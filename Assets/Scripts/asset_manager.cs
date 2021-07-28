using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asset_manager : MonoBehaviour
{
    public GameObject rail;
    public GameObject sol;
    // Start is called before the first frame update
    void Start()
    {
        float i;
        
        i = -30;
        while(i < 250)
        {
            Instantiate(rail, new Vector3(0.5f, 0, i), Quaternion.identity);
            Instantiate(rail, new Vector3(5.5f, 0, i), Quaternion.identity);
            Instantiate(rail, new Vector3(-4.5f, 0, i), Quaternion.identity);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
