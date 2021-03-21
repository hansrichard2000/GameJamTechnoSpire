using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour
{
    public static bool CharacterChanged = false;

    public GameObject[] playerUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            playerUI[0].SetActive(true);
            playerUI[1].SetActive(false);
            playerUI[2].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            playerUI[0].SetActive(false);
            playerUI[1].SetActive(true);
            playerUI[2].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            playerUI[0].SetActive(false);
            playerUI[1].SetActive(false);
            playerUI[2].SetActive(true);
        }
    }
}
