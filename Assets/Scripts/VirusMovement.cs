using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    float speed;
    // virus 1 yang buta
    // virus 2 yang bisa nembak
    // virus 3 yang lambat
    public GameObject virus1, virus2, virus3;
    Vector3 translationVec;
    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject == virus1)
        {
            speed = 0.02f;
        }else if(this.gameObject == virus2)
        {
            speed = 0.010f;
        }else if(this.gameObject == virus3)
        {
            speed = 0.0075f;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        translationVec = new Vector3(-1, 0, 0);

        transform.localPosition += translationVec * speed;
    }
}
