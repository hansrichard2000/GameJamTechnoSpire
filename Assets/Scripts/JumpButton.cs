using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public bool isPressed;
    public GameObject playerMachineGun;
    public GameObject playerThrower;
    public GameObject playerShotgun;
    public ParticleSystem particleSystem;
/*    public PlayerMovement playerMovement;
    public PlayerMovement playerMoveShotgun;
    public PlayerMovement playerMoveThrower;*/

    // Start is called before the first frame update
    void Update()
    {
        print("ooit");
        if (isPressed)
        {
            if (playerMachineGun.active)
            {
                playerMachineGun.GetComponent<PlayerMovement>().Jump();
                //particleSystem.Play();
            }else if (playerShotgun.active)
            {
                playerShotgun.GetComponent<PlayerShotgun>().Jump();
            }else if (playerThrower.active)
            {
                playerThrower.GetComponent<PlayerThrower>().Jump();
            }
            

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
