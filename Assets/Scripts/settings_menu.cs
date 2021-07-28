using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings_menu : MonoBehaviour
{
    //Speed related variables
    public int speedValue;
    public Slider myS;
    
    //Music related variables
    public Toggle muteState;
    public Slider volumeState;
    public AudioSource sound;
    public GameObject lvlRotate;

    public  bool activited;

    // Start is called before the first frame update
    void Start()
    {
        activited = false;
        if (muteState.isOn)
        {
            PlayerPrefs.SetFloat("mute", 0);
            sound.Play();
            sound.mute = false;
        }
        else
        {
            PlayerPrefs.SetInt("mute", 1);
            sound.Stop();
            sound.mute = true;
        }

        PlayerPrefs.SetFloat("volume", volumeState.value);
        sound.volume = PlayerPrefs.GetFloat("volume");
        setVolume();

        speedValue = Mathf.RoundToInt(myS.value);
        PlayerPrefs.SetInt("Speed", speedValue);
       
    }
    public void SpeedSaveSettings()
    {
        speedValue = Mathf.RoundToInt(myS.value);
        PlayerPrefs.SetInt("Speed", speedValue);
    }

    public void setVolume()
    {
        PlayerPrefs.SetFloat("volume", volumeState.value);
        sound.volume = PlayerPrefs.GetFloat("volume") / 10;
    }

    public void setMute()
    {
        if (muteState.isOn)
        {
            PlayerPrefs.SetFloat("mute", 0);
            sound.Play();
            sound.mute = false;
        }
        else
        {
            PlayerPrefs.SetInt("mute", 1);
            sound.Stop();
            sound.mute = true;
        }   
    }

    void Update()
    {
        if (muteState.isOn)
            muteState.GetComponentInChildren<Text>().text = "On";
        else
            muteState.GetComponentInChildren<Text>().text = "Off";
    }

    public void OnOpen()
    {
        LeanTween.moveLocalY(gameObject, 0f, 1.1f).setEaseOutBounce();
        lvlRotate.GetComponent<HereIRotate>().RotateForSettingsOpen();
        activited = true;

    }
    public void OnClose()
    {
        activited = false;
        LeanTween.moveLocalY(/*gameObject.GetComponent<RectTransform>()*/gameObject, 1000f, 1.1f).setEaseOutBounce();
        lvlRotate.GetComponent<HereIRotate>().RotateForSettingsClose();    
    }
}
