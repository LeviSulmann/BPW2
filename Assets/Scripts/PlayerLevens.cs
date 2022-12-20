using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerLevens : MonoBehaviour
{
    
    int playerLevens = 0;
    bool check = false;
    public int Count;


    // Start is called before the first frame update
    void Start()
    {
   
    }


   
    // Update is called once per frame
    void Update()
    {
 //       Debug.Log("Levens" + playerLevens);


        if (playerLevens < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }


   private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.gameObject.GetComponent<Enemy>() != null)
      {

            playerLevens = playerLevens - 1;
            Debug.Log("levens" + playerLevens);
                
            
       }
   }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>() == null)
        {

            Debug.Log("is weer false");
        }

    }


}
