using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*public class Interactive : Interaction
{
    public Interactive Obj;
}*/

public class InteractiveObj : MonoBehaviour {

    public string NextSceneName;
    private BoxCollider2D Col;
    private Animator Anim;
    // Use this for initialization
    void Awake () {
        Col = GetComponent<BoxCollider2D>();
        Anim = GetComponent<Animator>();
    }
  
    // Update is called once per frame
    void Update () {

  

	}
    void OnTriggerStay2D(Collider2D collider) //Trigger for doors (planning to change later)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Anim.SetBool("CallOpening", true); //Calls for opening animation
            if (tag == "Door") //Tag check to avoid collision delete on chests etc
            {
                Col.enabled = false; //Disables Collider Trigger on door sprite (ONLY FOR DOORS)
            }
            if (tag=="Chest")
            {
                //Later here will be chest containment call with UI and stuff (also sound)
            }
            if (tag == "Level_end")
            {
                SceneManager.LoadScene(NextSceneName);
            }
        }
    }
}
