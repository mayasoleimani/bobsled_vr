using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using System.Linq;

public class Scoreboard_jaxon : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] names;
    public GameObject[] scores;
    public double goldsave;
    public double silversave;
    public double bronzesave;

    public savescript save;

    void Start()
    {
        
        


        scoreboardupdate();
        

    }

    // Update is called once per frame
    void Update()
    {

    }


    void scoreboardupdate() {

        //Variableholder.times.Add(save.Load());

        
            goldsave = ( save.Load("gold.game"));
            silversave = (save.Load("silver.game"));
            bronzesave = (save.Load("bronze.game"));

        
        if (goldsave > 0)
        {
            Variableholder.times.Add(goldsave);
            if (silversave > 0)
            {
                Variableholder.times.Add(silversave);
            }
            if (bronzesave > 0)
            {
                Variableholder.times.Add(bronzesave);
            }
        }

        Variableholder.times = Variableholder.times.Distinct().ToList();

        sorstuff();

        save.Save(Variableholder.times[0], "gold.game");

        if(Variableholder.times.Count < 2)
        {
            save.Save(0, "silver.game");
            Debug.Log("silver 0");
        }
        else
        {
            save.Save(Variableholder.times[1], "silver.game");
            Debug.Log("silver " + Variableholder.times[1] + " " + Variableholder.times[0]);
        }

        if (Variableholder.times.Count < 3)
        {
            save.Save(0, "bronze.game");
        }
        else
        {
            save.Save(Variableholder.times[2], "bronze.game");
        }
       
       Debug.Log("silver after"); 
        for (int i = 0; i < 3; i++) {

            double tempseconds = Variableholder.times[i] % 60;
            double tempminutes = (Variableholder.times[i]-tempseconds) / 60;
            if (tempseconds < 10)
            {
                scores[i].GetComponent<Text>().text = tempminutes.ToString() + ":0" + tempseconds.ToString("F2");
            }
            else
            scores[i].GetComponent<Text>().text = tempminutes.ToString() +":"+ tempseconds.ToString("F2");

        }


        Variableholder.times.Clear();
    
   



    }

    void sorstuff() {
        Variableholder.times.Sort();

        Variableholder.times = Enumerable.ToList(Variableholder.times);
        Variableholder.times = Variableholder.times.Distinct().ToList();
        Variableholder.times = Variableholder.times.Distinct().ToList();

    }
}
