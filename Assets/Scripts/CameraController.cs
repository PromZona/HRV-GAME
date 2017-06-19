﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float speed = 2.0f;

    private Transform target;

    private void Awake()
    {
        if (!target) target = FindObjectOfType<Move>().transform;
    }

    private void Update ()
    {
        Vector3 position = target.position;             position.z = -10f;
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
    }

}
