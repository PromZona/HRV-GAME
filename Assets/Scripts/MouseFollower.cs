using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour {

    void FixedUpdate()
    {
        var MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - MousePosition, Vector3.forward);

        transform.rotation = rot;
    }
}
