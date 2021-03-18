using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    int pattern = 0;
    public GameObject[] virus;

    // Start is called before the first frame update
    void Start()
    {
        spawnVirus(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnVirus(int pattern)
    {
        switch (pattern)
        {
            // random spawn
            case 1:
                var newVirus1 = Instantiate(virus[0]);
                newVirus1.transform.position = new Vector3(7, 0.15f, 0);
                //gerak ke kiri lurus
                var newVirus2 = Instantiate(virus[1]);
                newVirus2.transform.position = new Vector3(5, 0.15f, 0);
                var newVirus3 = Instantiate(virus[2]);
                newVirus3.transform.position = new Vector3(3, 0.15f, 0);
                break;

            // 2 dan seterusnya buat pattern
            case 2:
                // code block
                break;
        }
    }
}
