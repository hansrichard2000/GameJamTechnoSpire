﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour
{
    public float timer = 3f;

    // Update is called once per frame
    void Update()
    {
        timer -= timer -= Time.deltaTime;

        if (timer == 0)
        {
            Destroy(this.gameObject);
        }
    }
}