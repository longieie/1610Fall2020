﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public UnityEvent powerUpEvent;
    private void OnTriggerEnter(Collider other)
    {
        score++;
        print("Score: " + score);
        powerUpEvent.Invoke();
    }
}
