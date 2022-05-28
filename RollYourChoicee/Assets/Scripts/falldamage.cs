using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falldamage : MonoBehaviour
{
    public float ylimit=-50;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= ylimit)
        {
            SceneManager.LoadScene(0);
        }
    }
}
