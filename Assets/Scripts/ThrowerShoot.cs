using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThrowerShoot : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed;
    public GameObject playerThrower;


    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            if (playerThrower.active)
            {
                playerThrower.GetComponent<PlayerThrower>().Shoot();
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
