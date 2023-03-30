using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class stats : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] scores;

    void Start()
    {
        statsupdate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void statsupdate() {


      scores[0].GetComponent<Text>().text =    Variableholder.wipeouts.ToString();
        scores[1].GetComponent<Text>().text = Variableholder.runs.ToString();
        scores[2].GetComponent<Text>().text = Variableholder.totaltime.ToString();
 
    }
}
