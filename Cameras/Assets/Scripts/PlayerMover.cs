using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(PlayerMotor))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    float speed = 7f;

    
    PlayerMotor motor;
    GroundCollision jumpCheck;
    public MoveCamera change;
    public Animator anim;
    public Animator anim2;
    public GameObject go;
    public GameObject go2;
    
    

    private void Start()
    {
        motor = GetComponent<PlayerMotor>();
        jumpCheck = GetComponent<GroundCollision>();
        
    }
    public void Update()
    {
        float _XMov = Input.GetAxisRaw("Horizontal");
        float _ZMov = Input.GetAxisRaw("Vertical");
       
       
        Vector3 movX = transform.right * _XMov;
        Vector3 movZ = transform.forward * _ZMov;
      
        if (change.b_mainCam==true)
        {
            Vector3 movement = (movX).normalized * speed;
            motor.Move(movement);
            if (_XMov !=0 && jumpCheck.isgrounded )
            {
                
                anim.SetBool("New Bool", true);
                Vector3 charScale = go.transform.localScale;
                if (_XMov<0)
                {
                    charScale.x = -0.1724599f;
                    
                }
                if (_XMov > 0 && jumpCheck.isgrounded)
                {
                    charScale.x = 0.1724599f;
                    
                }
                go.transform.localScale = charScale;
            }
            else
            {
                anim.SetBool("New Bool", false);
                if (!jumpCheck.isgrounded)
                {
                    anim.SetBool("New Bool 0", true);
                }
                
            }
        }
        else
        {
            Vector3 movementZ = (movZ).normalized * speed;
            motor.Move(movementZ);
            if (_ZMov != 0 && jumpCheck.isgrounded)
            {
                anim2.SetBool("New Bool", true);
                Vector3 charScaleZ= go2.transform.localScale;
                if (_ZMov < 0 )
                {
                    
                    
                    charScaleZ.x = 0.1724599f;
                }
                if (_ZMov > 0)
                {
                    
                    charScaleZ.x = -0.1724599f;
                }
                go2.transform.localScale = charScaleZ;
            }
            else
            {
                anim2.SetBool("New Bool", false);
                if (!jumpCheck.isgrounded)
                {
                    anim2.SetBool("New Bool 0", true);
                }
            }
        }

      
       
       
    }
    


}