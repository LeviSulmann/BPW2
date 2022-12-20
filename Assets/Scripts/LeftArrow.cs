using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public GameObject[] myArrayObjects = new GameObject[0];


    // Start is called before the first frame update
    void Start()
    {
 

    }
    // Update is called once per frame
    void Update()
    {
        //LEFT
        if (Input.GetKeyDown(KeyCode.A))
        {

            transform.Translate(-1.05f, 0, 0);


        }


    }

    }
    


        
    

