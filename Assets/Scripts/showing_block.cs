using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showing_block : MonoBehaviour
{
    /*
    ** Variable publiques, faisant le lien vers les differents elements
    **
    */

    public List<GameObject> cubes;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubes.Count; i++)
        {
            LeanTween.alpha(cubes[i], 0f, 0.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider target)
    {
        int first = Random.Range(0, 3);
        if (target.tag == "character")
        {
            LeanTween.moveY(cubes[first], -5f, 1.5f);
        }
    }
}
