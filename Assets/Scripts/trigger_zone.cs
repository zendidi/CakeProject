using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_zone : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> cubes;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "character")
        {
            for (int i = 0; i < cubes.Count; i++)
            {
                if (cubes[i].GetComponent<MeshRenderer>().material.color == GetComponent<MeshRenderer>().material.color)
                {
                    cubes[i].GetComponent<phasing_cube>().phase = !cubes[i].GetComponent<phasing_cube>().phase;
                }
            }
        }
    }
}
