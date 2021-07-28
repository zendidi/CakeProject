using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBlock : MonoBehaviour
{
    Rigidbody rb;
    public float downScaler;
    public float curvyScale;
    bool hasTush;

    public Vector3 initPos;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        initPos = this.transform.position;
        hasTush = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasTush)
        {
            rb.AddForce(new Vector3(-Mathf.Cos(Time.time) * curvyScale, -downScaler, 0));
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            rb.Sleep();
            hasTush = true;
            Debug.Log("touché");
        }
    }
}
