using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class BetterJump : MonoBehaviour
{

    public float fallmultiplier = 2.5f;
    public float lowjump = 2f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (rb.velocity.y<0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallmultiplier - 1)*Time.deltaTime;

        }
        else if (rb.velocity.y>0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowjump - 1) * Time.deltaTime;
        }
    }
    
}
