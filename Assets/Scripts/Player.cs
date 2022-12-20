using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameManager gameManager;
    HealthBarHUDTester HealthBar;
    PlayerStats PlayerStats;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        
        
       
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
