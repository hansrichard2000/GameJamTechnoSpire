using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerChange : MonoBehaviour
{
    public static bool CharacterChanged = false;

    public GameObject[] playerUI;
    public Button[] ButtonUI;

    public float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            print(gameObject.name);
            timer += Time.deltaTime;
            if (timer >= 15.0f)
            {
                timer = 0;
                playerUI[0].SetActive(true);
                playerUI[1].SetActive(false);
                playerUI[2].SetActive(false);
                ButtonUI[0].gameObject.SetActive(true);
                ButtonUI[1].gameObject.SetActive(false);
                ButtonUI[2].gameObject.SetActive(false);
                timer = 0;
            }
            print(ButtonUI[0].gameObject.name);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "ItemShotgun")
        {
            playerUI[0].SetActive(false);
            playerUI[1].SetActive(true);
            playerUI[2].SetActive(false);
            ButtonUI[0].gameObject.SetActive(false);
            ButtonUI[1].gameObject.SetActive(true);
            ButtonUI[2].gameObject.SetActive(false);
            Destroy(collision.collider.gameObject);
            
        }

        if (collision.collider.tag == "ItemThrower")
        {
            playerUI[0].SetActive(false);
            playerUI[1].SetActive(false);
            playerUI[2].SetActive(true);
            ButtonUI[0].gameObject.SetActive(false);
            ButtonUI[1].gameObject.SetActive(false);
            ButtonUI[2].gameObject.SetActive(true);
            Destroy(collision.collider.gameObject);
            
        }
    }
}
