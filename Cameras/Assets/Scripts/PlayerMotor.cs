using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class PlayerMotor : MonoBehaviour
{
    private Vector3 vel = Vector3.zero;
  
    Rigidbody rb;
    
    public float maxrayDist = .6f;
    GroundCollision collCheck;
    bool canMove;
    [Range(0f,1.0f)]
    public float maxSeconds = .2f;
    BoxCollider coll;
    CapsuleCollider cColl;


    private void Awake()
    {
        coll = GetComponent<BoxCollider>();
        cColl = GetComponent<CapsuleCollider>();
        
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        collCheck = GetComponent<GroundCollision>();
     


    }
 
    public void Move(Vector3 _vel)
    {
        vel = _vel;
    }


 
    private void FixedUpdate()
    {

        
        MovePlayer();

      
    }
    void MovePlayer()
    {
        
        if (vel != Vector3.zero)
        {

            canMove = true;
            rb.MovePosition(rb.position + vel * Time.fixedDeltaTime);
            FindObjectOfType<AudioManager>().Play("Walk");
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            Debug.Log("Entered Collision");
           

        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            Debug.Log("Staying in Collision");
            canMove = false;
            
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        canMove = true;
        
    }



}