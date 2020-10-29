﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScore : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            GameControl.instance.birdScore();
        }
    }
}
