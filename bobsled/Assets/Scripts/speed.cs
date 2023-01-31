using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;
using System.Threading;
using System;
using Valve.VR;


public class speed : MonoBehaviour
{
    public TMP_Text text;
    public Rigidbody rb;

    void awaken() {
   


    }









    // Update is called once per frame
    void Update()
    {

      
        double speed = rb.velocity.magnitude * 2.237;
        string mph = "MPH";
        text.text = speed.ToString("00 ") + mph;
        text.color = Color.white;



    }
}

