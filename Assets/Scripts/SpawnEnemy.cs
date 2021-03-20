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
    void Update()
    {
        // untuk sementara, nanti pake random spawn per berapa detik
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spawnPattern(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spawnPattern(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spawnPattern(4);
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

            case 3:
                // spawn virus 1
                spawnVirus(virus[0], new Vector3(9.5f, 3f, 0));
                spawnVirus(virus[0], new Vector3(9.5f, 1.5f, 0));
                spawnVirus(virus[0], new Vector3(9.5f, -3f, 0));
                spawnVirus(virus[0], new Vector3(9.5f, -1.5f, 0));
                // spawn virus 2
                spawnVirus(virus[1], new Vector3(5.85f, 1f, 0));
                spawnVirus(virus[1], new Vector3(5.85f, -1f, 0));
                spawnVirus(virus[1], new Vector3(7.5f, 3.5f, 0));
                spawnVirus(virus[1], new Vector3(7.5f, -3.5f, 0));
                spawnVirus(virus[1], new Vector3(8f, 1f, 0));
                spawnVirus(virus[1], new Vector3(8f, -1f, 0));
                // spawn virus 3
                spawnVirus(virus[2], new Vector3(3.5f, 0, 0));
                spawnVirus(virus[2], new Vector3(5f, 3f, 0));
                spawnVirus(virus[2], new Vector3(5f, -3f, 0));
                break;

            case 4:

                // spawn virus 1
                spawnVirus(virus[0], new Vector3(9.5f, 3.75f, 0));
                spawnVirus(virus[0], new Vector3(9.5f, 1.5f, 0));
                spawnVirus(virus[0], new Vector3(9.5f, -1f, 0));
                spawnVirus(virus[0], new Vector3(9.5f, -3.35f, 0));
                spawnVirus(virus[0], new Vector3(8f, 2.65f, 0));
                spawnVirus(virus[0], new Vector3(8f, 0.25f, 0));
                spawnVirus(virus[0], new Vector3(8f, -2.25f, 0));
                spawnVirus(virus[0], new Vector3(6.5f, 3.75f, 0));
                spawnVirus(virus[0], new Vector3(6.5f, 1.5f, 0));
                spawnVirus(virus[0], new Vector3(6.5f, -1f, 0));
                spawnVirus(virus[0], new Vector3(6.5f, -3.35f, 0));
                spawnVirus(virus[0], new Vector3(5f, 2.65f, 0));
                spawnVirus(virus[0], new Vector3(5f, 0.25f, 0));
                spawnVirus(virus[0], new Vector3(5f, -2.25f, 0));
                break;
        }
    }

    void spawnVirus(GameObject virusType, Vector3 position)
    {
        var newVirus1 = Instantiate(virusType);
        newVirus1.transform.position = position;
    }
}
