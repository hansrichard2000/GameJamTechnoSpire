﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float speed = 0.3f;
    Vector3 translationVec;
    float BATAS_KANAN = 9f;
    float BATAS_KIRI = -9f;
    float BATAS_ATAS = 5f;
    float BATAS_BAWAH = -5f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // gerakan peluru sesuai dengan arahnya
        transform.localPosition += translationVec * speed;

        if(transform.localPosition.x > BATAS_KANAN || transform.localPosition.x < BATAS_KIRI || transform.localPosition.y > BATAS_ATAS || 
            transform.localPosition.y < BATAS_BAWAH)
        {
            Destroy(this.gameObject);
        }
    }

    public void TembakDari(Vector3 posAwal, Vector3 direction)
    {
        //taruh peluru di posisi awal
        transform.localPosition = new Vector3(posAwal.x, posAwal.y, posAwal.z);

        //set arah peluru
        translationVec = new Vector3(Mathf.Cos(0), Mathf.Sin(0), 0);
    }
}
