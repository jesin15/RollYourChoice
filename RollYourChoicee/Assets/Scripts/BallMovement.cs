using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 200f;
    private float xinput;
    private float zinput;
    private bool isgrounded;
    public GameObject ball;
   
    public ParticleSystem finisheffect;
    public float jumpforce = 3f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        processInputs();
        if (Input.GetButtonDown("Jump")&&isgrounded==true){
            rb.AddForce(new Vector3(0f, jumpforce, 0f));
            

        }
    }
    private void FixedUpdate()
    {
        move();
        
    }
    void processInputs()
    {
        xinput = Input.GetAxis("Horizontal");
        zinput = Input.GetAxis("Vertical");
        
    }
    void move()
    {
        rb.AddForce(new Vector3(xinput, 0f, zinput) * speed);
    }
  
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("FinishLine"))
        {
            finisheffect.Play();
            //load end scene 

        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            isgrounded = true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(ball);
            SceneManager.LoadScene(0);
        }
        


    }
    private void OnCollisionExit(Collision collision)
    {
         if (collision.gameObject.CompareTag("Ground"))
        {
            isgrounded = false;
        }
    }

}
