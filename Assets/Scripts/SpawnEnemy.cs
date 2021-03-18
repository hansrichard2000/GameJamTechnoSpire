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
                Instantiate(virus[1]);
                Instantiate(virus[2]);
                Instantiate(virus[3]);
                break;

            // 2 dan seterusnya buat pattern
            case 2:
                // code block
                break;
        }
    }
}
