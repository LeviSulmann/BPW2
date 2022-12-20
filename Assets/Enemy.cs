using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    HeartSystem heartSystem;
    [SerializeField]GameObject Player;
    public bool IsActivated = false;
    public GameObject Crystal;

    void Awake()
    {
        heartSystem = Player.GetComponent<HeartSystem>();
    }

  void Update()
    {
        

    }
    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.GetComponent<Player>() != null)
        {



            IsActivated = true;
         

            heartSystem.TakeDamage(1);
          
        } else
        {

            Destroy(Crystal);
        }


      
            




    }


 
}
