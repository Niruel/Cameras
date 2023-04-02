using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Camera main;
    public Camera secondCam;
    public GameObject sprite1;
    public GameObject sprite2;
    public bool b_mainCam;
    // Start is called before the first frame update
    void Start()
    {
        secondCam.enabled = false;
        b_mainCam = true;
        sprite2.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (b_mainCam==true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
               
                sprite2.SetActive(true);
                sprite1.SetActive(false);
                main.enabled = false;
                secondCam.enabled = true;
                b_mainCam = false;
            }
        }
            
        
        else
        {
            if (b_mainCam==false)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                   
                    if (b_mainCam == false)
                    {
                        sprite2.SetActive(false);
                        sprite1.SetActive(true);
                        main.enabled = true;
                        secondCam.enabled = false;
                        b_mainCam = true;
                    }

                }
            }
           
        }
    }

}
