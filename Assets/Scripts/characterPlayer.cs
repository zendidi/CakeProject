//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.InputSystem;

//public class characterPlayer : MonoBehaviour
//{

//    public float speed;
//    public float lateralTranslateMove;
//    public float jumpValue;
//    public CharacterController CC;
//    Vector3 move;


//    /*
//    ** Variables plubliques servant a la gestion de l'UI
//    */

//    public Text cube_hit;
//    static int nbr_cube_hit;

//    PlayerControls controls;

//    void Awake()
//    {
//        controls = new PlayerControls();
//        controls.Gameplay.A.performed += ctx => MoveLeft();
//        controls.Gameplay.B.performed += ctx => MoveRight();

//        if (PlayerPrefs.HasKey("Speed"))
//        {
//            speed = PlayerPrefs.GetInt("Speed");
//        }
//        else
//        {
//            speed = 5;
//        }

//    }

//    void MoveLeft()
//    {
//        if (transform.position.x > -5)
//        {
//            CC.Move((move * speed * Time.deltaTime) + new Vector3(-lateralTranslateMove, 0, 0));
//            LeanTween.moveY(gameObject.GetComponent<RectTransform>(), 1000f, 1.1f).setEaseOutBounce();
//        }
//    }

//    void MoveRight()
//    {
//        if (transform.position.x < 5)
//        {
//            CC.Move((move * speed * Time.deltaTime) + new Vector3(lateralTranslateMove, 0, 0));
//        }
//    }

//    void OnEnable()
//    {
//        controls.Gameplay.Enable();
//    }

//    void OnDisable()
//    {
//        controls.Gameplay.Disable();
//    }

//    void Start()
//    {
//        nbr_cube_hit = 0;
//        cube_hit.text = "Cube hit : " + nbr_cube_hit.ToString();
//        move = transform.forward;
//    }


//void Update()
//{
//    if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 5)
//    {
//        //CC.Move((move * speed * Time.deltaTime) + new Vector3(lateralTranslateMove, 0, 0));
//        //CC.Move((move * speed * Time.deltaTime) + new Vector3(lateralTranslateMove, 0, 0));
//        LeanTween.moveX(gameObject.GetComponent<RectTransform>(), 5f, 1.1f);
//    }
//    else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -5)
//    {
//        CC.Move((move * speed * Time.deltaTime) + new Vector3(-lateralTranslateMove, 0, 0));
//    }
//}

//private void FixedUpdate()
//{
//    //CC.Move(move * speed * Time.deltaTime);
//    LeanTween.moveZ(gameObject.GetComponent<RectTransform>(), 10000, speed * 1000);
//}

//private void OnTriggerEnter(Collider other)
//{
//    if (other.gameObject.tag == "cube")
//    {
//        nbr_cube_hit++;
//        Destroy(other.gameObject);
//        cube_hit.text = "Cube hit : " + nbr_cube_hit.ToString();
//    }
//}
//}






//-------TEST-------//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;
using UnityEngine.SceneManagement;
//  ajout SASHA pour le new input system
//using UnityEngine.Experimental.Input;    
//

public class characterPlayer : MonoBehaviour
{

    public float speed;
    public float lateralTranslateMove;
    public float jumpValue;
    public CharacterController CC;
    Vector3 move;


    /*
    ** Variables plubliques servant a la gestion de l'UI
    */

    //  ajout SASHA pour le new input system
    public PlayerControls controls;
    //


    public Text cube_hit;
    public int nbr_cube_hit;
    public float timer = 0;
    public Camera myCam;
    LTDescr mainMove;
    public AudioSource hitSound;
    protected static bool gamePaused = false;
    public GameObject pauseUI;
    public Text textPauseUI;
    static bool ispressed=false;

    void Start()
    {
        ispressed = false;
        gamePaused = false;
        nbr_cube_hit = 0;
        cube_hit.text = cube_hit.text + nbr_cube_hit.ToString();
        move = transform.forward;
        StartCoroutine(gogogo());
        nbr_cube_hit = 30;
        myCam = Camera.main;
    }

    IEnumerator gogogo()
    {
        yield return new WaitForSeconds(2f);
        mainMove = LeanTween.moveZ(gameObject, 550, 550 / speed);
    }
    void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();
        controls.Gameplay.A.performed += ctx => MoveLeft();
        controls.Gameplay.B.performed += ctx => MoveRight();
        controls.Gameplay.Holder.performed += ctx => HoldMeThat();
        //controls.Gameplay.Holder.canceled += ctx => GiveItBack();
        //controls.Gameplay.GoToMenu.performed += ctx => backToMenu();

        if (PlayerPrefs.HasKey("Speed"))
        {
            speed = PlayerPrefs.GetInt("Speed");
        }
        else
        {
            speed = 15;
        }

    }

    private void backToMenu()
    {
        float transiTime = 0.5f;

        if (gamePaused)
        {
            gamePaused = !gamePaused;
            SceneManager.LoadScene("LevelSelection");
            return;
        }
        pauseUI.GetComponent<RectTransform>().LeanAlpha(0.75f, 0.5f);
        StartCoroutine(pauseTheGame(transiTime));
        gamePaused = true;
    }

    IEnumerator pauseTheGame(float timeToPause)
    {
        yield return new WaitForSeconds(timeToPause);
        textPauseUI.GetComponent<clignotteUi>().transiPause();
        mainMove.pause();
    }

    IEnumerator unpauseTheGame()
    {
        pauseUI.GetComponent<RectTransform>().LeanAlpha(0, 0.5f);
        yield return new WaitForSeconds(0.5f);
        mainMove.resume();
        gamePaused = false;
        textPauseUI.GetComponent<clignotteUi>().stopPause();
    }

    private void GiveItBack()
    {
        controls.Gameplay.A.Enable();
        controls.Gameplay.B.Enable();
    }

    private void HoldMeThat()
    {
        ispressed = !ispressed;
        Debug.Log(ispressed);
    }

    void MoveLeft()
    {
        Debug.Log("gauche");
        if (ispressed)
        {
            return;
        }
        if (gamePaused)
        {
            StartCoroutine(unpauseTheGame());
            return;
        }
        if (!canMoveLeft())
            return ;
        if (transform.position.x == 0)
            LeanTween.moveX(gameObject, -5f, 2.5f / speed);
        if (transform.position.x == 5)
            LeanTween.moveX(gameObject, 0f, 2.5f / speed);
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02F;
    }

    void MoveRight()
    {
        Debug.Log("droite");
        if (ispressed)
        {
            backToMenu();
            return;
        }
        if (gamePaused)
        {
            StartCoroutine(unpauseTheGame());
            return;
        }
        if (!canMoveRight())
            return ;
        if (transform.position.x == 0)
            LeanTween.moveX(gameObject, 5f, 3 / speed);
        if (transform.position.x == -5)
            LeanTween.moveX(gameObject, 0f, 3 / speed);
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02F;
    }

    private bool canMoveRight()
    {
        Vector3 posToCheck = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z + 1);
        Collider[] hitColliders = Physics.OverlapSphere(posToCheck, 0.05f);
        Vector3 posToCheck2 = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z - 1);
        Collider[] hitColliders2 = Physics.OverlapSphere(posToCheck2, 0.05f);
        if (hitColliders.Length > 0 || hitColliders2.Length > 0)
        {
            return false;
        }
        return true;
    }

    private bool canMoveLeft()
    {
        Vector3 posToCheck = new Vector3(transform.position.x - 5, transform.position.y, transform.position.z + 1);
        Collider[] hitColliders = Physics.OverlapSphere(posToCheck, 0.05f);
        Vector3 posToCheck2 = new Vector3(transform.position.x - 5, transform.position.y, transform.position.z - 1);
        Collider[] hitColliders2 = Physics.OverlapSphere(posToCheck2, 0.05f);
        if (hitColliders.Length > 0 || hitColliders2.Length > 0)
        {
            return false;
        }
        return true;
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
        Time.timeScale = 1;
    }

    void Update()
    {
      timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    IEnumerator GoBackRunning()
    {
        yield return new WaitForSeconds(.3f);
        mainMove = LeanTween.moveZ(gameObject, 550, (550 / speed)-timer+.3f);
        Time.timeScale = 0.25f;
        Time.fixedDeltaTime = 0.25f * Time.timeScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            hitSound.Play();
            StartCoroutine(myCam.GetComponent<camView>().Shaking(.25f, 10));
            nbr_cube_hit--;
            Destroy(other.gameObject);
            cube_hit.text = "Collisions\n "+ (30-nbr_cube_hit).ToString();
            mainMove.pause();
            LTDescr hitAnim= LeanTween.moveZ(gameObject, gameObject.transform.position.z-5, 0.2f);
            StartCoroutine("GoBackRunning");
        }
    }
}