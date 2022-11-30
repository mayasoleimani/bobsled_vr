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
        Debug.Log(left_con.localEulerAngles.x);
        //x is forward/backward
        //z is left/right

            avg_rot_FB = ((headset.transform.localEulerAngles.x + left_con.transform.localEulerAngles.x + right_con.transform.localEulerAngles.x) / 3);

        if (avg_rot_FB > 10 && avg_rot_FB < 50)
        {
            //add force forwards
            //Debug.Log("Forwards");
                bobsled.AddForce((avg_rot_FB / 50) * force_amount * Time.deltaTime* -player.transform.forward);
        }

            bobsled.AddForce(Vector3.forward * force_amount, ForceMode.Impulse);
        if (avg_rot_FB < -5 && avg_rot_FB > -35)
        {
            //add force backwards
 
            bobsled.AddForce((avg_rot_FB / 50) * force_amount * Time.deltaTime* player.transform.forward);
        }

            avg_rot_LR = ((headset.transform.localEulerAngles.z + left_con.transform.localEulerAngles.z + left_con.transform.localEulerAngles.z) / 3);
            //Debug.Log(headset.rotation.eulerAngles.z);

        if (avg_rot_LR <= -5 && avg_rot_LR >= -45)
        {
            //add force left
            
            bobsled.AddForce((avg_rot_LR / 45) * force_amount_LR * Time.deltaTime* player.transform.right );
        }


        if (avg_rot_LR >= 5 && avg_rot_LR <= 45)
        {
                //add force left
                
                bobsled.AddForce((avg_rot_LR / 45) * force_amount_LR * Time.deltaTime * player.transform.right);
            }


    }
}
