using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour,IUpdateSelectedHandler,IPointerDownHandler,IPointerUpHandler
{
    public bool isPressed;
    public GameObject playerMachineGun;
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    public void OnUpdateSelected(BaseEventData data)
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
