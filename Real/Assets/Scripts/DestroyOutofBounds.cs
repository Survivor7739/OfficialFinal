using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyOutOfBounds : MonoBehaviour
{
    private bool isDead;

   
    private float topBound = 30;
    private float lowerBound = -5;


    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound && !isDead)
        {
       
            Destroy(gameObject);
            Debug.Log("Dead");
        }
        else if (transform.position.y < lowerBound && !isDead)
        {
      
            
            Debug.Log("Dead");
        }
    }
}