using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phasing_cube : MonoBehaviour
{
   
    public Color colorFrom;
    public Color colorTo;
    public bool        phase;

    //private float time_to_fade = 0.4f;

    private Color blue = new Color(0, 0, 1);
    private Color red = new Color(1, 0, 0);

    void Start()
    {
        if (GetComponent<MeshRenderer>().material.color == blue)
        {
            colorFrom = blue;
            colorTo = Color.clear;
        }
        else
        {
            colorFrom = red;
            colorTo = Color.clear;
        }
    }
    void Update()
    {
        Fading();
        if (GetComponent<MeshRenderer>().material.color.a<0.4)
        {
            Destroy(gameObject);
        }
    }

    void Fading()
    {
        if (phase)
        LeanTween.alpha(gameObject, 0, 1);
        if(!phase)
        LeanTween.alpha(gameObject, 1, 1);
    }
}
