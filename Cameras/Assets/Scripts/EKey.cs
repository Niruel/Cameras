using UnityEngine;
using UnityEngine.UI;

public class EKey : MonoBehaviour
{
    public Text t;
    public Text t2;
    public MoveCamera switchCam;

    private void Start()
    {
        
        t.enabled = false;
        t2.enabled = false;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            t.enabled = false;
            t2.enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="Player")
        {
            if (!switchCam.b_mainCam)
            {
                t.enabled = true;
            }
            else
            {
                t2.enabled = true;
            }
        }
        
        
    }
    private void OnTriggerExit(Collider other)
    {
        t.enabled = false;
        t2.enabled = false;
    }
    
}
