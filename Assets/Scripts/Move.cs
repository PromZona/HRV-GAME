using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public static float speed = 3f;
    private Animator Hero_Anim;
    void Start()
    {
        Hero_Anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 directionX = transform.right * moveX;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + directionX, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 directionY = transform.up * moveY;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + directionY, speed * Time.deltaTime);
        }
        
    }
}
