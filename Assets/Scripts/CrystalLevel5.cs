using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrystalLevel5 : MonoBehaviour
{
    // Start is called before the first frame update

    HeartSystem heartSystem;
    ArrayScript1 arraylist;
    [SerializeField] GameObject Player;

    int Count = 0;





    void Awake()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        StartCoroutine(Timer());


    }

    void Update()
    {
        EveryButtonCheck();

    }
    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D player)
    {

        NextLevel();

    }


    public void NextLevel()
    {


        if (Count == 7)
        {
            SceneManager.LoadScene(0);

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

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        GetComponent<BoxCollider2D>().enabled = true;
    }

}
