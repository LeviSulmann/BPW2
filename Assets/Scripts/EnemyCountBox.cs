using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCountBox : MonoBehaviour
{
    // Start is called before the first frame update
    HeartSystem heartSystem;
    [SerializeField] GameObject Player;
    public bool IsActivated = false;
    public GameObject[] myArrayObjectsEnemy = new GameObject[0];
    GameObject Crystal;

    public bool ButtonLeft;
    public bool ButtonRight;
    public bool ButtonUp;
    public bool ButtonDown;

    void Awake()
    {
        ButtonLeft = true;
        ButtonRight = true;
        ButtonUp = true;
        ButtonDown = true; 
        heartSystem = Player.GetComponent<HeartSystem>();
        
    }

    void Update()
    {
        Movement();

        if (myArrayObjectsEnemy.Length < 2)
        {
            ButtonLeft = false;
        }

        if (myArrayObjectsEnemy.Length < 2)
        {
            ButtonRight = false;
        }

        if (myArrayObjectsEnemy.Length < 2)
        {
            ButtonUp = false;
        }

        if (myArrayObjectsEnemy.Length < 2)
        {
           
            ButtonDown = false;
        }

    }

    public void Movement()
    {

         
        if (ButtonLeft == true)
        {
            //LEFT
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                myArrayObjectsEnemy = GameObject.FindGameObjectsWithTag("EnemyMove");

                Destroy(myArrayObjectsEnemy[0].gameObject);
                transform.Translate(-1.05f, 0, 0);
            }
        }



        if (ButtonUp == true)
        {
            //LEFT
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                myArrayObjectsEnemy = GameObject.FindGameObjectsWithTag("EnemyMove");

                Destroy(myArrayObjectsEnemy[0].gameObject);
                transform.Translate(0, 1, 05f, 0);

            }
        }

        // UP


        if (ButtonRight == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                myArrayObjectsEnemy = GameObject.FindGameObjectsWithTag("EnemyMove");

                Destroy(myArrayObjectsEnemy[0].gameObject);
                transform.Translate(1.05f, 0, 0);

            }
        }

        //DOWN
        if (ButtonDown == true)
        {
            //DOWN
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                myArrayObjectsEnemy = GameObject.FindGameObjectsWithTag("EnemyMove");

                Destroy(myArrayObjectsEnemy[0].gameObject);
                transform.Translate(0, -1.05f, 0);

            }
        }

   


    }

        //LEFT
      

       

        //RIGHT
   

    

   

        // Update is called once per frame
        public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.GetComponent<Player>() != null)
        {
            IsActivated = true;


            heartSystem.TakeDamage(1);
            
        }



    }
}


