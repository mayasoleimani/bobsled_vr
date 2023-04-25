using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class DeathScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject confetti;
    public Collider track;
    public Camera cam;
    public Collider death_hitbox;
    float timed = 0;
    public GameObject player;
    public timer timer;
    public holderscript holder;
    public bool once = true;
    void Start()
    {
        confetti.SetActive(false);
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if (other == track)
        {

            //start timer for 5 seconds
            //stop physics
            Time.timeScale = 0;
            //gray scale screen
            //cam.p
            //display text WIPEOUT
            //go to main menu
            StartCoroutine(ExampleCoroutine());
            
            SceneManager.LoadScene("sean_menu_vr");
        }
    }
    public void OnCollisionStay(Collision collision)
    {
        timed = timed + Time.deltaTime * 1;
    }

    public void OnCollisionExit(Collision collision)
    {
        timed = 0;
    }
*/
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            
            
            Variableholder.wipeouts++;
            holder.restart();

            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish" && once)
        {
            once = false;
            StartCoroutine(finisher());
            return;
        }
        //Variableholder.wipeouts++;
        if (other.tag == "course")
        {
           
            Variableholder.wipeouts++;
            holder.restart();
        }

    }

    IEnumerator finisher()
    {
        //SHOOT CONFETTIE
        confetti.SetActive(true);
        double winningtime = Math.Truncate(timer.ts.TotalSeconds*100)/100;
        Variableholder.times.Add(winningtime);
        Variableholder.totaltime = winningtime;
        Debug.Log(winningtime + "going");
        //WAIT 3 SEONDTS
        yield return new WaitForSeconds(5);


        holder.finish();
    }

    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);


    }
   
    // Update is called once per frame
    void Update()
    {
       
            
            

        
    }
}
