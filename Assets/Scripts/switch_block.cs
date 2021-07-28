using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_block : MonoBehaviour
{
    // Start is called before the first frame update
    private int size_block;
    public float speed_block;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    // Deplacement cube
    void move()
    {
        if (this.transform.position.x > 3 * this.transform.localScale.x || this.transform.position.x < 0)
            speed_block = -speed_block;
        this.transform.position = Vector3.MoveTowards(this.transform.position, this.transform.position + Vector3.right, speed_block);
    }
}
