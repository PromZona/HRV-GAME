using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCharacter : MonoBehaviour {

    public float smooth = 2.0f;
    public GameObject Character;

    void Start()
    {
        Character = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        var CharacterPosition = Character.transform.position;
        CharacterPosition.z = -90;       
        Quaternion rot = Quaternion.LookRotation(transform.position - CharacterPosition, Vector3.forward);
        transform.rotation = rot;
    }

}
