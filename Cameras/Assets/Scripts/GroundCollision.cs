using UnityEngine;


public class GroundCollision : MonoBehaviour
{
    [Range(0, 10)]
    public float jumpvel;
    public float gropundSkin = 0.05f; 
    public bool jumpreq;
    public bool isgrounded;
    public LayerMask mask;
    public Animator anim;
    public Animator anim2;

    CapsuleCollider coll;
    


    private void Start()
    {
       
    }
    private void Awake()
    {
        
        coll = GetComponent<CapsuleCollider>();
    }
    // Update is called once per frame
    void Update()
    {   

        if (Input.GetButtonDown("Jump") && isgrounded)
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
            isgrounded = false;
            anim.SetBool("New Bool 0", true);
            anim2.SetBool("New Bool 0", true);
            FindObjectOfType<AudioManager>().Play("jump");
           


        }
        else
        {

            
            isgrounded = true;
            isgrounded = Physics.Raycast(transform.position, Vector3.down, coll.bounds.extents.y + 0.1f);
            anim.SetBool("New Bool 0", false);
            anim2.SetBool("New Bool 0", false);

          


        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Wall" )
        {
            //FindObjectOfType<AudioManager>().Play("land");
        }
       
    }


}
