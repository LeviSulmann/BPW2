using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLeft : MonoBehaviour
{
    // Start is called before the first frame update
    HeartSystem heartSystem;
    [SerializeField] GameObject Player;
    public bool IsActivated = false;
    public GameObject[] myArrayObjectsEnemy = new GameObject[0];

    void Awake()
    {
        heartSystem = Player.GetComponent<HeartSystem>();
    }

    void Update()
    {
        Movement();

    }

    public void Movement()
    {
        //LEFT
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myArrayObjectsEnemy = GameObject.FindGameObjectsWithTag("EnemyLeft");

            Destroy(myArrayObjectsEnemy[0].gameObject);
            transform.Translate(-1.05f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myArrayObjectsEnemy = GameObject.FindGameObjectsWithTag("EnemyLeft");

            Destroy(myArrayObjectsEnemy[0].gameObject);
            transform.Translate(-1.05f, 0, 0);

        }

        //RIGHT
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myArrayObjectsEnemy = GameObject.FindGameObjectsWithTag("EnemyLeft");

            Destroy(myArrayObjectsEnemy[0].gameObject);
            transform.Translate(-1.05f, 0, 0);

        }

        //DOWN
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myArrayObjectsEnemy = GameObject.FindGameObjectsWithTag("EnemyLeft");

            Destroy(myArrayObjectsEnemy[0].gameObject);
            transform.Translate(-1.05f, 0, 0);

        }

    }

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
