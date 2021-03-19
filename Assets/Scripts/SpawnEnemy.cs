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
        //spawnPattern(1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            spawnPattern(2);
        }
    }

    void spawnPattern(int pattern)
    {
        Vector3 pos;

        switch (pattern)
        {
            // random spawn
            case 1:
                break;

            // 2 dan seterusnya buat pattern
            case 2:
                // spawn virus 1
                spawnVirus(virus[0], new Vector3(5, 0, 0));
                spawnVirus(virus[0], new Vector3(6.5f, -1.35f, 0));
                spawnVirus(virus[0], new Vector3(6.5f, 1.35f, 0));
                spawnVirus(virus[0], new Vector3(8f, -2.7f, 0));
                spawnVirus(virus[0], new Vector3(8, 2.7f, 0));
                // spawn virus 2
                spawnVirus(virus[1], new Vector3(4.5f, 3.85f, 0));
                spawnVirus(virus[1], new Vector3(9, 3.85f, 0));
                spawnVirus(virus[1], new Vector3(4.5f, -3.85f, 0));
                spawnVirus(virus[1], new Vector3(9, -3.85f, 0));
                // spawn virus 3
                spawnVirus(virus[2], new Vector3(9, 0, 0));
                break;
        }
    }

    void spawnVirus(GameObject virusType, Vector3 position)
    {
        var newVirus1 = Instantiate(virusType);
        newVirus1.transform.position = position;
    }
}
