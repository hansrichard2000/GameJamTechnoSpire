using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus2Behavior : MonoBehaviour
{
    private Vector3 translationVec;
    public GameObject prefabPeluruMonster;
    private float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();    
    }

    private void Attack()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            var peluruBaru = Instantiate(prefabPeluruMonster);
            peluruBaru.GetComponent<PeluruVirus>().TembakDari(transform.localPosition, -translationVec);
            timer = 3f;
        }
    }
}
