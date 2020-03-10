
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerController : MonoBehaviour
{

    [SerializeField] 
    private LayerMask platformMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2D;
    StepColor stepColor;
    SpriteRenderer rend;
    public Color colorIs;

    float Speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.color = Color.white;
        //colorIs = Color.white;
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            float Jump = 6f;
            rigidbody2d.velocity = Vector2.up * Jump;
        }

        this.MovementUpdate();
        this.IsAlive();

    }

    private void MovementUpdate()
    {
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            rigidbody2d.velocity = new Vector2(-Speed, rigidbody2d.velocity.y);
        }else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rigidbody2d.velocity = new Vector2(+Speed, rigidbody2d.velocity.y);
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
        }

        

        if (Input.GetButton("Red"))
        {
            rend.color = Color.red;
            colorIs = Color.red;
            
        }

        if (Input.GetButton("Green"))
        {
            rend.color = Color.green;
            colorIs = Color.green;
        }

        if (Input.GetButton("Blue"))
        {
            rend.color = Color.blue;
            colorIs = Color.blue;
        }

      
    }


    protected virtual void IsAlive()
    {
        if(transform.position.y < -5.5f)
        {
            SceneManager.LoadScene("Begging");
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycast2d = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, .1f, platformMask);
        return raycast2d.collider != null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("FallingLevel");    // Begging and FallingLevel
        }

        if (collision.gameObject.tag == "RunFinish")
        {
            SceneManager.LoadScene("Run");    
        }
    }



}
