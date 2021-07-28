using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camView : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    Vector3 savePos;

    // Update is called once per frame
    private void Start()
    {
        savePos = target.transform.position;
    }
    void Update()
    {
        Vector3 desiredPosition = new Vector3(savePos.x,target.transform.position.y, target.transform.position.z) + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

    public IEnumerator Shaking (float duration,float magnitude )
    {
        Vector3 originalPos = transform.localPosition;

        LTDescr hitAnim = LeanTween.moveLocalZ(gameObject, originalPos.z-  magnitude, duration);
        yield return new WaitForSeconds(duration);
        

    }
}
