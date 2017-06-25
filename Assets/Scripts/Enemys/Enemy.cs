using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int lives = 5;

    void Update()
    {
        if (lives <= 0)
        {
            die();
        }
    }

    public void die ()
    {
        Destroy(gameObject);
    }
}
