using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlFinish : MonoBehaviour
{
    public GameObject targetTransition;
    public GameObject score;
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag=="character")
        {
            StartCoroutine(Transitionning());
            other.gameObject.GetComponent<characterPlayer>().speed = 0;
            score.GetComponent<GestionScore>().gettingFinalScore();
        }
    }
    
    IEnumerator Transitionning()
    {
        LeanTween.moveLocalX(targetTransition, 10, 1.5f);
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene("LevelSelection", LoadSceneMode.Single);
    }

}
