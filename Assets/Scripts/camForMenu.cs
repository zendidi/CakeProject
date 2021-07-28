using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camForMenu : MonoBehaviour
{
    public float timeScale;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.forward/ timeScale;
    }
}
