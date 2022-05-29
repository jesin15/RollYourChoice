using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearing : MonoBehaviour

{
    public GameObject platforml;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(platforml);
        }
    }
}
