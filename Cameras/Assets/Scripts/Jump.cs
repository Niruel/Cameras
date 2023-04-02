using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    [Range(0, 10)]
    public float jumpvel;
    bool jumpreq;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpreq = true;
        }
    }

    private void FixedUpdate()
    {
        if (jumpreq)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpvel, ForceMode.Impulse); 
            jumpreq = false;
        }
        
    }
}
