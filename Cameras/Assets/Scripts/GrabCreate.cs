using UnityEngine;

public class GrabCreate : MonoBehaviour
{
    
    public LayerMask mask;   
    GroundCollision collCheck;
    [Range(0f, 1f)]
    public float range;
    public Animator anim;
    public Animator anim2;
   

    private void Start()
    {
        collCheck = GetComponent<GroundCollision>();
        
    }
    // Update is called once per frame
    void Update()
    {
        BoxCheckXPlus();
        BoxCheckXMinus();
        BoxCheckZPlus();
        BoxCheckZMinus();



    }
    void BoxCheckXPlus()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, range, mask))
        {
            if (hit.collider)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {


                    hit.collider.gameObject.transform.parent = this.transform;

                    if (hit.collider.gameObject.transform.parent == this.transform)
                    {
                        anim.SetBool("New Bool 1", true);
                        
                        collCheck.enabled = false;
                        FindObjectOfType<AudioManager>().Play("moveCrate");
                        hit.collider.gameObject.transform.position = hit.point + new Vector3(.5f, 0, 0);


                    }

                }
                if (Input.GetKeyUp(KeyCode.E))
                {
                    anim.SetBool("New Bool 1", false);
                    collCheck.enabled = true;
                    hit.collider.gameObject.transform.parent = null;


                }
          

            }
        }
    }
    void BoxCheckXMinus()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(-Vector3.right), out hit, range, mask))
        {
            if (hit.collider)
            {


                if (Input.GetKeyDown(KeyCode.E))
                {
                   hit.collider.gameObject.transform.parent = this.transform;

                    if (hit.collider.gameObject.transform.parent == this.transform)
                    {
                        anim.SetBool("New Bool 1", true);
                        collCheck.enabled = false;
                        FindObjectOfType<AudioManager>().Play("moveCrate");
                        hit.collider.gameObject.transform.position = hit.point - new Vector3(.5f, 0, 0);


                    }

                }
                if (Input.GetKeyUp(KeyCode.E))
                {
                    anim.SetBool("New Bool 1", false);
                    collCheck.enabled = true;
                    hit.collider.gameObject.transform.parent = null;

                }
      

            }
        }
      

    }
    void BoxCheckZPlus()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, range, mask))
        {

            if (hit.collider)
            {


                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.transform.parent = this.transform;

                    if (hit.collider.gameObject.transform.parent == this.transform)
                    {
                        
                        anim2.SetBool("New Bool 1", true);
                        collCheck.enabled = false;
                        hit.collider.gameObject.transform.position = hit.point + new Vector3(0, 0.01f, .5f);
                        FindObjectOfType<AudioManager>().Play("moveCrate");
                        
                    }

                }
                if (Input.GetKeyUp(KeyCode.E))
                {
                    anim2.SetBool("New Bool 1", false);
                    collCheck.enabled = true;
                    hit.collider.gameObject.transform.parent = null;
                    FindObjectOfType<AudioManager>().Stop("moveCrate");


                }


            }
        }
    }
    void BoxCheckZMinus()
    {
       
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(-Vector3.forward), out hit, range, mask))
        {
            if (hit.collider)
            {


                if (Input.GetKeyDown(KeyCode.E))
                {

                   hit.collider.gameObject.transform.parent = this.transform;

                    if (hit.collider.gameObject.transform.parent == this.transform)
                    {
                        anim2.SetBool("New Bool 1", true);
                        collCheck.enabled = false;
                        hit.collider.gameObject.transform.position = hit.point - new Vector3(0, 0, .5f);
                        FindObjectOfType<AudioManager>().Play("moveCrate");

                    }

                }
                if (Input.GetKeyUp(KeyCode.E))
                {
                    anim2.SetBool("New Bool 1", false);
                    collCheck.enabled = true;
                    hit.collider.gameObject.transform.parent = null;
                    FindObjectOfType<AudioManager>().Stop("moveCrate");

                }
                

            }
        }
       

    }
}
