using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Growing_tree : MonoBehaviour
{
    /*
    ** Variable publiques, faisant le lien vers les differents elements
    **
    */

    public List<GameObject> cubes;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubes.Count; i++)
        {
            LeanTween.moveY(cubes[i], -5, 0.1f);
        }
        player=GameObject.Find("character");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider target)
    {
        int first = Random.Range(0, 3);
        int second = Random.Range(0, 3);
        while (first == second)
            second = Random.Range(0, 3);
        if (target.tag == "character")
        {
            LeanTween.moveY(cubes[first], 0f, (5f/player.GetComponent<characterPlayer>().speed));
            LeanTween.moveY(cubes[second], 0f, (5f / player.GetComponent<characterPlayer>().speed));
        }
    }
}
