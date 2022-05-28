using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
    private float xinput;
    private float zinput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        processInputs();
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
}
