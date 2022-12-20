using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    HeartSystem heartSystem;
    [SerializeField]GameObject Player;
    public bool IsActivated = false;


    PlayerLevens Levens;


    HealthBarHUDTester HealthBar;

    void Awake()
    {
        heartSystem = Player.GetComponentInChildren<HeartSystem>();
        //  HealthBar = HealthBar.GetComponent<HealthBarHUDTester>();
 //   Levens = Player.GetComponent<PlayerLevens>();
    }

  void Update()
    {
        

    }
    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.GetComponent<Player>() != null)
        {
            heartSystem.TakeDamage(1);
        //    Levens.playerLevens = 1;
        //    Debug.Log(playerLevens);
         
            /// moet andere 
          
        } 

      
            




    }


 
}
