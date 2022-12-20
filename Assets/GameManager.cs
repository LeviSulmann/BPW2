using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public Player player;
    public HeartSystem Heartsystem;
    bool gameHasEndend = false;
    public enum Scene
    {
        SampleScene,
    }


    void Awake()
    {
        Instance = this;
        player = GetComponent<Player>();
        Heartsystem = GetComponent<HeartSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        if (gameHasEndend == false)
        {
            gameHasEndend = true;
             Debug.Log("GAME OVER");
            Restart();
        }
      
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }




}
