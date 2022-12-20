using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //   transform.position = new Vector3(Mathf.Clamp(transform.position.x) - 2f, 2f),
     //       Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("ja hoor werkt");
            collision.gameObject.GetComponent<Renderer>().enabled = false;
            
        }

    }
}
