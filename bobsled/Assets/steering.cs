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
    void Update()
    {
        //x is forward/backward
        //z is left/right

        avg_rot_FB = 360-((headset.rotation.eulerAngles.x + left_con.rotation.eulerAngles.x + right_con.rotation.eulerAngles.x)/3);

        if (avg_rot_FB > angle_forward && avg_rot_FB < 360 - angle_backwards)
            //add force forwards
            Debug.Log("Accel");
            bobsled.AddForce(bobsled.transform.forward * force_amount);
        if (avg_rot_FB > 360 - angle_backwards)
            //add force backwards
            Debug.Log("Slow");
            bobsled.AddForce(-bobsled.transform.forward * force_amount);

        avg_rot_LR =((headset.rotation.eulerAngles.z + left_con.rotation.eulerAngles.z + right_con.rotation.eulerAngles.z) / 3);
        Debug.Log(headset.rotation.eulerAngles.z);
        
        if (headset.rotation.eulerAngles.z > angle_LR)
            //add force left
            Debug.Log("Right");
        bobsled.AddForce(bobsled.transform.right * force_amount_LR);
        if (headset.rotation.eulerAngles.z > 360 - angle_LR)
            //add force left
            Debug.Log("Left");
            bobsled.AddForce(bobsled.transform.right * -force_amount_LR);


    }
}
