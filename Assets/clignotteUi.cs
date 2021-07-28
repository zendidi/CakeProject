using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class clignotteUi : MonoBehaviour
{
    LTDescr clignotte;
    int id;
    void Start()
    {
        if (gameObject.name != "pause")
        {
            LeanTween.alphaText(gameObject.GetComponent<RectTransform>(), 0.5f, 0.85f).setLoopPingPong();
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void transiPause()
    {
        clignotte=LeanTween.alphaText(gameObject.GetComponent<RectTransform>(), 0.75f, 0.85f).setLoopPingPong();
        //clignotte.reset();
        gameObject.SetActive(true);
        id = clignotte.id;
    }

    public void stopPause()
    {
        LeanTween.cancel(id);
        LeanTween.alphaText(gameObject.GetComponent<RectTransform>(), 0, 0.5f);
    }
}
