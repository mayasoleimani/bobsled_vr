using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class Scoreboard_jaxon : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] names;
    public GameObject[] scores;

    static string[] name;
    static string[] times;

    void Start()
    {
       



        scoreboardupdate();
        

    }

    // Update is called once per frame
    void Update()
    {

    }


    void scoreboardupdate() {
        sorstuff();

        for (int i = 0; i < 4; i++) {

            double tempseconds = Variableholder.times[i] % 60;
            double tempminutes = (Variableholder.times[i]-tempseconds) / 60;
            scores[i].GetComponent<Text>().text = tempminutes.ToString() +":"+ tempseconds.ToString();

        }


      


    }

    void sorstuff() {
        Variableholder.times.Sort();
        


            }
}
