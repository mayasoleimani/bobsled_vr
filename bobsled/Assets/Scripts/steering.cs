using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steering : MonoBehaviour
{
    [SerializeField] 
    public Transform headset;
    public Transform left_con;
    public Transform right_con;
    public Rigidbody bobsled;
    public Transform player;
    
    public float angle_LR;
    public float angle_forward;
    public float angle_backwards;
    public float force_amount;
    public float force_amount_LR;

    private float avg_rot_LR;
    private float avg_rot_FB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 

    int garb;
    // Update is called once per frame
    void FixedUpdate()
    {
      
        //x is forward/backward
        //z is left/right

            avg_rot_FB = (headset.transform.localEulerAngles.x );

        if (avg_rot_FB > 10 && avg_rot_FB < 50)
        {
            //add force forwards
            //Debug.Log("Forwards");
            bobsled.AddForce( force_amount * Time.deltaTime * player.transform.forward);
            //Debug.Log("F");
        }
        //Debug.Log(avg_rot_FB);
        
        if (avg_rot_FB < 340 && avg_rot_FB > 305)
        {
            //add force backwards
 
            bobsled.AddForce( force_amount * Time.deltaTime* -player.transform.forward);
            //Debug.Log("B");
        }

            avg_rot_LR = (headset.transform.localEulerAngles.z);
        //Debug.Log(headset.rotation.eulerAngles.z);
        //Debug.Log(avg_rot_LR);

        if (avg_rot_LR >= 5 && avg_rot_LR <= 60)
        {
            //add force left
            
            bobsled.AddForce( -force_amount_LR * Time.deltaTime* player.transform.right );
            //Debug.Log("L");
        }


        if (avg_rot_LR <= 355 && avg_rot_LR >= 300)
        {
                //add force left
                
                bobsled.AddForce( force_amount_LR * Time.deltaTime * player.transform.right);
            //Debug.Log("R");
        }


    }
}
