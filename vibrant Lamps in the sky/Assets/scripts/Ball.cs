using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

    public AudioSource aud;
   

    public paddle paddle;
    private bool hasStarted = false;
  private Vector3 paddleToBallVector;


    Rigidbody2D rb;
    public float f1, f2;

   
     
    void Start()
    {
        aud = GetComponent<AudioSource>();




       paddle = GameObject.FindObjectOfType<paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;

        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (!hasStarted)
        {
            // Lock the ball relative to the paddle.

            LockBallAtPaddle();

           

            // Wait for a mouse press to launch.


            if (Input.GetMouseButtonUp(0))
            {
                print("Mouse clicked, launch ball");
                hasStarted = true;

                 rb.velocity = new Vector2(1.8f, 13f);
               
             // rb.AddForce(new Vector2(f1, f2 ));
              
           

              
            }





        }
    }


   public void LockBallAtPaddle()
    {
        this.transform.position = paddle.transform.position + paddleToBallVector;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Ball does not trigger sound when brick is destoyed.
        //to avoid crack and boing playing at same time we dis this with &&





        if (hasStarted && !collision.gameObject.CompareTag("Breakable"))//avoid both sounds on play
        {


            aud.Play();

        }



    


  



        RegulateSpeed();



    }

    //udemy ball either too speedy or too fast problem solved
    public float  ballSpeed=12f;

    void RegulateSpeed()
    {
        Vector2 direction = rb.velocity.normalized;
        Vector2 newVelocity = direction * ballSpeed;
        rb.velocity = newVelocity;
    }







}