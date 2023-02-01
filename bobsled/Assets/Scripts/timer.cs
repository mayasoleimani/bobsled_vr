using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;
using System.Threading;
using System;
using Valve.VR;


public class timer : MonoBehaviour
{
    public TMP_Text text;
    private bool isTimerRunning;
    private bool isTimerStarting;
    private int countdown = 2;
    public Stopwatch stopwatch;
    TimeSpan ts;
    public Rigidbody rb;
    private bool isLocked;
    
    void Start()
    {

        isLocked = true;
        BeginTimer();
    }

    
  

    private void Unlock()
    {
        isLocked = false;
    }


    public void BeginTimer()
    {
        stopwatch = new Stopwatch();
        isTimerRunning = true;
        isTimerStarting = true;
        countdown = 2;
    }

    public void EndTimer()
    {
        isTimerRunning = false;
        stopwatch = null;
    }

    private IEnumerator Countdown()
    {
        float timedown = 1f;
            while (timedown >= 0)
            {
            timedown -= Time.smoothDeltaTime;
                yield return null;
            }
            if(!(timedown >= 0))
            {
                countdown -= countdown;
            }
    }

        // Update is called once per frame
    void Update()
    {   
        
        if (isLocked)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
        }
        else
        {
            rb.constraints = RigidbodyConstraints.None;
            
        }
        if(isTimerStarting)
        {
            switch(countdown) 
            {
                case 2:
                    text.text = "READY";
                    text.color = Color.red;
                    StartCoroutine(Countdown());
                    break;
                case 1:
                    text.text = "SET";
                    text.color = Color.yellow;
                    StartCoroutine(Countdown());
                break;
                    case 0:
                    text.text = "GO";
                    text.color = Color.green;
                StartCoroutine(Countdown());
                isTimerStarting = false;
                    break;
            }

        }
        else
        {
            Unlock();
            stopwatch.Start();
            ts = stopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            text.text = elapsedTime;
            text.color = Color.white;
        }
    }
}

