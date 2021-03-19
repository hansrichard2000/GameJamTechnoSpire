using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float speed = 0.5f;
    Vector3 translationVec;
    float BATAS_KANAN = 10f;
    //float BATAS_KIRI = -9f;
    //float BATAS_ATAS = 5f;
    //float BATAS_BAWAH = -5f;
    public GameObject firePoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // gerakan peluru sesuai dengan arahnya
        transform.localPosition += translationVec * speed;

        if(transform.localPosition.x > BATAS_KANAN)
        {
            Destroy(this.gameObject);
        }
    }

    public void TembakDari(GameObject posAwal, Vector3 direction)
    {
        //taruh peluru di posisi awal
        transform.localPosition = new Vector3(posAwal.transform.position.x, posAwal.transform.position.y, posAwal.transform.position.z);

        //set arah peluru
        translationVec = new Vector3(Mathf.Cos(0), Mathf.Sin(0), 0);
    }

    
}
