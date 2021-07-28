using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{
    protected float timeToFade = 1.25f;
    private void Start()
    {
        
    }
    public void ActivateTransition(int choose)
    {  
     StartCoroutine(Transitionning(choose));       
    }

    IEnumerator Transitionning(int choose)
    {
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 1, timeToFade);
        yield return new WaitForSeconds(timeToFade);
        switch (choose)
        {
            case 0:
                SceneManager.LoadScene("Chap1Lvl1");
                break;
            case 1:
                SceneManager.LoadScene("Chap1Lvl2");
                break;
            case 2:
                SceneManager.LoadScene("Chap1Lvl3");
                break;
            case 3:
                SceneManager.LoadScene("Chap1Lvl4");
                break;
            default:
                break;
        }    
    }
}
