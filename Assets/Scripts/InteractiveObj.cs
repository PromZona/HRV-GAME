using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InteractiveObj : MonoBehaviour {

    private Animator OnUseAnim; //door sprite Animator (can be used for others probably)
    BoxCollider2D Col; 


    // Use this for initialization
    void Awake () {
        Col = GetComponent<BoxCollider2D>();
        OnUseAnim = GetComponent<Animator>();
    }
  
    // Update is called once per frame
    void Update () {

  

	}
    void OnTriggerEnter2D(Collider2D collider) //Trigger for doors (planning to change later)
    {
        OnUseAnim.SetBool("CallOpening", true); //Calls for opening animation
        
        Col.enabled = false; //Disables Collider Trigger on door sprite
    }

}
