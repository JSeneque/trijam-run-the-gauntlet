﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        // play a sound on impact
        Destroy(gameObject);
    }
}
