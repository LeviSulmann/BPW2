using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{


    public GameObject[] hearts;
    public int life;
    GameManager gamemanager;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GetComponent<GameManager>();
        player = GetComponent<Player>();
    }



    // Update is called once per frame
    void Update()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
            gamemanager.EndGame();
            // Loader.Load(Loader.Scene.Level2);


        } else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            
        } else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
        }
          else if (life < 4)
        {
            Destroy(hearts[3].gameObject);
        }
   
    }

    public void TakeDamage(int d)
    {

        life -= d;
    }
}
