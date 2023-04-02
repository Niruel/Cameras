using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMe : MonoBehaviour
{
    public Transform reset;
    public Transform player;
    public MoveCamera orginal_cam;

    private void Start()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name=="Player")
        {
            player.position = reset.position;
            if (orginal_cam.b_mainCam)
            {
                return;
            }
            else
            {
                orginal_cam.b_mainCam = true;
                orginal_cam.main.enabled = true;
                orginal_cam.secondCam.enabled = false;
                orginal_cam.sprite1.SetActive(true);
            }
            
        }
    }
}
