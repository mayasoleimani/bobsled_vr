using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform bobsled;
    public Transform rig;
    public Transform lookat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rig.position = new Vector3(bobsled.position.x, bobsled.position.y, bobsled.position.z);
        //rig.rotation = bobsled.rotation;

        rig.localRotation = Quaternion.Euler(lookat.localEulerAngles.x, rig.localEulerAngles.y, lookat.localEulerAngles.z);
    }
}
