using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interruptor_block : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject button;
    public GameObject button2;
    public GameObject button3;

    public List<GameObject> cubes;
    List<GameObject> buttons;

    private Color blue = new Color(0, 0, 1);
    private Color red = new Color(1, 0, 0);

    // Start is called before the first frame update
    void Awake()
    {
        cubes = new List<GameObject>() { cube, cube2, cube3};
        buttons = new List<GameObject>() { button, button2, button3};
        set_colors();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cubes.Count; i++)
        {
            if (cubes[i].GetComponent<MeshRenderer>().material.color.a < 0.6f)
                cubes[i].SetActive(false);
        }
    }

    void set_colors()
    {
        int color = Random.Range(0, 3);
        for (int i = 0; i < cubes.Count; i++)
        {
            if (i == color)
                cubes[i].GetComponent<MeshRenderer>().material.color = blue;
            else
                cubes[i].GetComponent<MeshRenderer>().material.color = red;
        }
        color = Random.Range(0, 3);
        for (int i = 0; i < buttons.Count; i++)
        {
            if (i == color)
                buttons[i].GetComponent<MeshRenderer>().material.color = blue; //set les alphas
            else
                buttons[i].GetComponent<MeshRenderer>().material.color = red; //set les alphas
        }
    }
}
