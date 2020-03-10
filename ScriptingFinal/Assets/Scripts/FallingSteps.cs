using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSteps : MonoBehaviour
{

    public Rigidbody2D fallStep;


    // Start is called before the first frame update
    void Start()
    {
        fallStep.gravityScale = 0.03f;
    }

    // Update is called once per frame
    void Update()
    {


        if (transform.position.y < -6.0f && transform.position.x < 12f && transform.position.x > -12f) // won't destory the refrence 
        {
            Destroy(gameObject);
        }

    }
}
