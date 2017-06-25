using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour {

    public float smooth = 2.0f;

    void FixedUpdate()
    {
        var MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = -90;
        Quaternion rot = Quaternion.LookRotation(transform.position - MousePosition, Vector3.forward);

        transform.rotation = rot;
    }
}
