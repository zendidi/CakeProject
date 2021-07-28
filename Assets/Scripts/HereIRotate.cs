using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Composites;
public class HereIRotate : MonoBehaviour
{
    public List<GameObject> elements;
    public List<GameObject> settings_options;
    public List<GameObject> settings_label;
    public int rayon;
    private int selectorFocus;
    PlayerControls controls;
    public GameObject Settings;
    public GameObject Transition;
    
    private int selected_setting;
    public GameObject selectInfo;
    // private InputAction myAction;
    static bool LeftButtonDown = false;
    public GameObject titre;
     public GameObject infoUser;


    private void Awake()
    {
        controls = new PlayerControls();
        controls.Gameplay.Disable();
        controls.Menu.Enable();
        controls.Menu.launchLevel.performed += ctx => SelectLevel();
        controls.Menu.selectLevel.performed += ctx => SelectorMove();
        controls.Menu.openSettings.performed += ctx => openSettings();
        controls.Menu.quitSettings.performed += ctx => closeSettings();
        controls.Menu.selectSettings.performed += ctx => selectSettings();
        controls.Menu.changeSettings.performed += ctx => adjustSettings();
        //controls.Menu.Holder.performed += ctx => HoldMeThat();
        controls.Menu.Deholder.performed += ctx => GiveItBack();
    }
    void Start()
    {
        LeftButtonDown = false;
        selectorFocus = 0;
        LeanTween.scale(elements[0], new Vector3(elements[selectorFocus].transform.localScale.x*2 , elements[selectorFocus].transform.localScale.y*2 , 0), 0.7f);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void SelectorMove()
    {
        int descale = 1;
        ChangeFocus();
        LeanTween.scale(elements[selectorFocus], new Vector3(elements[selectorFocus].transform.localScale.x* 2f, elements[selectorFocus].transform.localScale.y * 2, 0), 0.7f);
        LeanTween.scale(elements[(selectorFocus + elements.Count - 1) % elements.Count], new Vector3(descale, descale, 0), 0.7f);

    }

    private void ChangeFocus()
    {
        selectorFocus++;
        if (selectorFocus == elements.Count)
        {
            selectorFocus = 0;
        }     
    }

    public void SelectLevel()
    {
        if (LeftButtonDown)
        {
            if (Settings.gameObject.GetComponent<settings_menu>().activited)
            {
                controls.Menu.selectSettings.Enable();
                controls.Menu.changeSettings.Enable();
                controls.Menu.launchLevel.Disable();
                controls.Menu.selectLevel.Disable();
            }
            else
            {
                controls.Menu.launchLevel.Enable();
                controls.Menu.selectLevel.Enable();
                controls.Menu.selectSettings.Disable();
                controls.Menu.changeSettings.Disable();
            }
        }
        else
        {
            switch (selectorFocus)
            {
                case 0:
                    Settings.GetComponent<settings_menu>().SpeedSaveSettings();
                    Transition.GetComponent<transition>().ActivateTransition(selectorFocus);
                    break;

                case 1:
                    Settings.GetComponent<settings_menu>().SpeedSaveSettings();
                    Transition.GetComponent<transition>().ActivateTransition(selectorFocus);
                    break;
                case 2:
                    Settings.GetComponent<settings_menu>().SpeedSaveSettings();
                    Transition.GetComponent<transition>().ActivateTransition(selectorFocus);
                    break;
                case 3:
                    Settings.GetComponent<settings_menu>().SpeedSaveSettings();
                    Transition.GetComponent<transition>().ActivateTransition(selectorFocus);
                    break;
                default:
                    break;
            }
        }
 
    }
    
    public void RotateForSettingsOpen()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            LeanTween.rotateX(elements[i], 90, 0.5f);
            LeanTween.rotateX(selectInfo, 90, 0.5f);
            LeanTween.rotateX(infoUser, 90, 0.5f);
            LeanTween.rotateX(titre, 90, 0.5f);
        }        
    }

    public void RotateForSettingsClose()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            LeanTween.rotateX(elements[i], 0, 0.5f);
            LeanTween.rotateX(selectInfo, 0, 0.5f);
            LeanTween.rotateX(infoUser, 0, 0.5f);
            LeanTween.rotateX(titre, 0, 0.5f);
        }
    }

    public void openSettings()
    {
        controls.Menu.launchLevel.Disable();
        controls.Menu.selectLevel.Disable();
        controls.Menu.openSettings.Disable();
        controls.Menu.selectSettings.Enable();
        controls.Menu.changeSettings.Enable();
        controls.Menu.quitSettings.Enable();

        Settings.GetComponent<settings_menu>().OnOpen();
        selected_setting = 0;
        view_settings();
    }

    public void closeSettings()
    {
        controls.Menu.launchLevel.Enable();
        controls.Menu.selectLevel.Enable();
        controls.Menu.openSettings.Enable();
        controls.Menu.selectSettings.Disable();
        controls.Menu.changeSettings.Disable();
        controls.Menu.quitSettings.Disable();

        Settings.GetComponent<settings_menu>().OnClose();
    }

    public void view_settings()
    {
        LeanTween.scale(settings_label[selected_setting], new Vector3(2, 2, 0), 0.7f);
    }

    public void selectSettings()
    {
        selected_setting++;
        selected_setting = selected_setting % settings_options.Count;
        view_settings();
        LeanTween.scale(settings_label[(selected_setting + settings_label.Count - 1) % settings_label.Count], new Vector3(1, 1, 0), 0.7f);
    }

    public  void adjustSettings()
    {
        int maxSpeed = (int)settings_options[0].GetComponent<Slider>().value;
        int maxVolume = (int)settings_options[2].GetComponent<Slider>().value;
        if (selected_setting == 0)
        {
            maxSpeed = (int)settings_options[selected_setting].GetComponent<Slider>().value + 1;
            settings_options[selected_setting].GetComponent<Slider>().value = maxSpeed % (settings_options[selected_setting].GetComponent<Slider>().maxValue + 1);
        }
        if (selected_setting == 1)
        {
            settings_options[selected_setting].GetComponent<Toggle>().isOn = !settings_options[selected_setting].GetComponent<Toggle>().isOn;
        }
        if (selected_setting == 2)
        {
            maxVolume = (int)settings_options[selected_setting].GetComponent<Slider>().value + 1;
            settings_options[selected_setting].GetComponent<Slider>().value = maxVolume % (settings_options[selected_setting].GetComponent<Slider>().maxValue + 1);
        }
    }

    public void HoldMeThat()
    {
        Debug.Log("hoild");
        controls.Menu.launchLevel.Disable();
        controls.Menu.selectLevel.Disable();

        controls.Menu.selectSettings.Disable();
        controls.Menu.changeSettings.Disable();

    }

    public void GiveItBack()
    {
        LeftButtonDown = !LeftButtonDown;
        
    }

    void OnEnable()
    {
        controls.Menu.Enable();
    }

    void OnDisable()
    {
        controls.Menu.Disable();
    }
}
