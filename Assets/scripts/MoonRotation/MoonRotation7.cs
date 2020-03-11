﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation7 : MonoBehaviour
{
    GameObject PauseMenuHolder;


    public Transform target;
    float x = 0f;
    float y = 0f;
    float z = 0f;
    [Range(0, 5)]
    public float Timescale = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = Timescale;
        transform.Rotate(-1f * Time.timeScale, .55f * Time.timeScale, -.1f * Time.timeScale);
    }
}
