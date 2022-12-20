using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    HeartSystem heartSystem;
    [SerializeField]GameObject Player;
    public bool IsActivated = false;
    public GameObject Crystal;
    WegErmee weg;
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
