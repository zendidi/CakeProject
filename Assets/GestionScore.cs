using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionScore : MonoBehaviour
{
    public GameObject player;
    float timeofRace;
    static int score;
    public GameObject _0star;
    public GameObject _1star;
    public GameObject _2star;
    public GameObject _3star;
    public GameObject _Parfait;
    public GameObject time;


    public void gettingFinalScore()
    {
        timeofRace=player.GetComponent<characterPlayer>().timer;
        score = player.GetComponent<characterPlayer>().nbr_cube_hit;
        if (score==30)
        {
            _Parfait.SetActive(true);
        }else if(score<30 && score>25)
        {
            _3star.SetActive(true);
        }
        else if(score <= 25 && score > 15)
        {
            _2star.SetActive(true);
        }
        else if(score <= 15 && score > 5)
        {
            _1star.SetActive(true);
        }
        else 
        {
            _0star.SetActive(true);
        }

        int minutes, secondes;
        minutes = (int)timeofRace / 60;
        secondes = (int)timeofRace % 60;
        time.GetComponent<Text>().text = (minutes + " min " + secondes + " sec ");

        LeanTween.moveLocalY(gameObject, 0, 0.5f).setEaseInOutCirc();
    }
}
