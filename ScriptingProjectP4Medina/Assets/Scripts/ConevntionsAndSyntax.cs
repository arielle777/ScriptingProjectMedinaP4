using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConevntionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //I want the x postion of my game object to appear on my console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
         //I want to know what my y location is at all times
        //Debug.Log(transform.position.y);

        //I want the concole to say something if my object is below 5
        if (transform.position.y <= 5f)
        {
            Debug.Log(" I am about to hit the ground");
        }
    }
}