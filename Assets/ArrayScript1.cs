using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ArrayScript1 : MonoBehaviour
{

  
    Player player;
    public GameObject[] myArrayObjectsRight = new GameObject[0];
    public GameObject[] myArrayObjectsLeft = new GameObject[0];
    public GameObject[] myArrayObjectsUp = new GameObject[0];
    public GameObject[] myArrayObjectsDown = new GameObject[0];

    public bool ButtonLeft;
    public bool ButtonRight;
    public bool ButtonUp;
    public bool ButtonDown;
    public bool ButtonWait;
    int Count = 0;


    // Start is called before the first frame update
    void Start()
    {
    ButtonLeft = true;
    ButtonRight= true;
    ButtonUp = true;
    ButtonDown = true;
    player = GetComponent<Player>();
       

    }
    // Update is called once per frame
    void Update()
    {
        MovementEnemy();

        if(myArrayObjectsLeft.Length <2)
        {
            ButtonLeft = false;
        }

        if (myArrayObjectsRight.Length < 2)
        {
            ButtonRight = false;
        }

        if (myArrayObjectsUp.Length < 2)
        {
            ButtonUp = false;
        }

        if (myArrayObjectsDown.Length < 2)
        {
            
            ButtonDown = false;
        }

      

    }


    public void MovementEnemy()
    {

        if (ButtonWait == false)
        {
            if (ButtonLeft == true)
            {
                //LEFT
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    myArrayObjectsLeft = GameObject.FindGameObjectsWithTag("MoveSetA");

                    Destroy(myArrayObjectsLeft[0].gameObject);
                    transform.Translate(-1.05f, 0, 0);
                    ButtonWait = true;
                    StartCoroutine(Waiting());

                }
            }



            if (ButtonUp == true)
            {
                //LEFT
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    myArrayObjectsUp = GameObject.FindGameObjectsWithTag("MoveSetW");

                    Destroy(myArrayObjectsUp[0].gameObject);
                    transform.Translate(0, 1, 05f, 0);
                    ButtonWait = true;
                    StartCoroutine(Waiting());

                }
            }

            // UP


            if (ButtonRight == true)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    myArrayObjectsRight = GameObject.FindGameObjectsWithTag("MoveSetD");

                    Destroy(myArrayObjectsRight[0].gameObject);
                    transform.Translate(1.05f, 0, 0);
                    ButtonWait = true;
                    StartCoroutine(Waiting());

                }
            }

            //DOWN
            if (ButtonDown == true)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    myArrayObjectsDown = GameObject.FindGameObjectsWithTag("MoveSetS");

                    Destroy(myArrayObjectsDown[0].gameObject);
                    transform.Translate(0, -1.05f, 0);
                    ButtonWait = true;
                    StartCoroutine(Waiting());

                }
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }

    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(0);
        ButtonWait = false;
        Debug.Log("ButtonWait is false");

    }


}









