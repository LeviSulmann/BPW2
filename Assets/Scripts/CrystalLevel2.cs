using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrystalLevel2 : MonoBehaviour
{
    // Start is called before the first frame update

    HeartSystem heartSystem;
    ArrayScript1 arraylist;
    [SerializeField] GameObject Player;

    int Count = 0;





    void Awake()
    {



    }

    void Update()
    {
        EveryButtonCheck();
        

    }
    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.GetComponent<Player>() != null)
        {
            NextLevel();
            Debug.Log(Count);
        }
       

    }


    public void NextLevel()
    {


        if (Count == 7)
        {
            SceneManager.LoadScene(3);

        }
        else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void EveryButtonCheck()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            Count = Count + 1;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            Count = Count + 1;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            Count = Count + 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            Count = Count + 1;
        }



    }

}


