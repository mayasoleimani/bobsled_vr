using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testangle : MonoBehaviour
{
    public Transform cbue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cbue.localRotation);
    }
}
