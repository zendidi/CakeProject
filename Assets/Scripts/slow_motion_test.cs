using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slow_motion_test : MonoBehaviour
{
    private bool    slow;
    public  float   slow_effect;
    // Start is called before the first frame update
    void Start()
    {
        slow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Time.timeScale = slow_effect;
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02F ;
        }

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "character" && !slow)
        {
            Time.timeScale = slow_effect;
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
            slow = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "character" && slow)
        {
            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02F ;
            slow = false;
        }
    }
}
