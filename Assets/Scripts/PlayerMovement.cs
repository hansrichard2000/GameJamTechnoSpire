﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed;
    float batasAtas = 3.50f;
    float batasBawah = -3.00f;
    Vector3 translationVec;
    public GameObject prefabPeluru;
    public GameObject firePoint;
    public ScoringSystem scoringSystem;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
                speed = 0.075f;
        }
        
        translationVec = new Vector3(0, 1, 0);

        transform.localPosition += translationVec * speed;

        if (transform.localPosition.y < batasBawah)
        {
            speed = 0f;
        }
        else
        {
            speed = -0.075f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Tembak
            //Buat pelurunya
            var peluruBaru = Instantiate(prefabPeluru);

            //set awal dan arah dari peluru
            peluruBaru.GetComponent<BulletMove>().TembakDari(firePoint, translationVec);
            peluruBaru.GetComponent<BulletDestroy>().scoringSystem = scoringSystem;

        }
    }
}
