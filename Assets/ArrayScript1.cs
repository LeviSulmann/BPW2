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

    public bool ButtonLeft = false;
    public bool ButtonRight = false;
    public bool ButtonUp = false;
    public bool ButtonDown = false;

    int Count = 0;


    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<Player>();
       

    }
    // Update is called once per frame
    void Update()
    {
        MovementEnemy();

    }


    public void MovementEnemy()
    {
       

          //LEFT
            if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myArrayObjectsLeft = GameObject.FindGameObjectsWithTag("MoveSetA");

            Destroy(myArrayObjectsLeft[0].gameObject);
            transform.Translate(-1.05f, 0, 0);

        }


        // UP
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myArrayObjectsUp = GameObject.FindGameObjectsWithTag("MoveSetW");

            Destroy(myArrayObjectsUp[0].gameObject);
            transform.Translate(0, 1, 05f, 0);

        }

        //RIGHT
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myArrayObjectsRight = GameObject.FindGameObjectsWithTag("MoveSetD");

            Destroy(myArrayObjectsRight[0].gameObject);
            transform.Translate(1.05f, 0, 0);

        }

        //DOWN
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myArrayObjectsDown = GameObject.FindGameObjectsWithTag("MoveSetS");

            Destroy(myArrayObjectsDown[0].gameObject);
            transform.Translate(0, -1.05f, 0);

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }



}







