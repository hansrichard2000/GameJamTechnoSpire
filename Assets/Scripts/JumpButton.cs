using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public bool isPressed;
    public GameObject playerMachineGun;
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Update()
    {
        print("ooit");
        if (isPressed)
        {
            playerMachineGun.GetComponent<PlayerMovement>().Jump();
        }
    }
    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
    }
}
