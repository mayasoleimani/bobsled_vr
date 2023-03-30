using System.Collections;
using System.Collections.Generic;
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


        for (int i = 0; i < 4; i++) {
            scores[i].GetComponent<Text>().text = Variableholder.times[i];
        }
    
    
    
    
    
    }


}
