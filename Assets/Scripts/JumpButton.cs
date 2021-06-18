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
    public ParticleSystem particleSystemMachine;
    public ParticleSystem particleSystemShotgun;
    public ParticleSystem particleSystemThrower;
    /*    public PlayerMovement playerMovement;
        public PlayerMovement playerMoveShotgun;
        public PlayerMovement playerMoveThrower;*/

    // Start is called before the first frame update
    void Start()
    {
        particleSystemMachine.Stop();
        particleSystemShotgun.Stop();
        particleSystemThrower.Stop();
    }

    void Update()
    {
        print("ooit");
        if (isPressed)
        {
            if (playerMachineGun.active && playerMachineGun != null)
            {
                playerMachineGun.GetComponent<PlayerMovement>().Jump();
                //particleSystem.Play();
            }
            else if (playerShotgun.active && playerShotgun != null)
            {
                playerShotgun.GetComponent<PlayerShotgun>().Jump();
                //particleSystem.Play();
            }
            else if (playerThrower.active && playerThrower != null)
            {
                playerThrower.GetComponent<PlayerThrower>().Jump();
                //particleSystem.Play();
            }
        }
    }
    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
        particleSystemMachine.Play();
        particleSystemShotgun.Play();
        particleSystemThrower.Play();
    }
    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
        particleSystemMachine.Stop();
        particleSystemShotgun.Stop();
        particleSystemThrower.Stop();
    }
}
