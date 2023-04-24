using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okbutton : MonoBehaviour
{

    public GameObject instructionmenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void accept()
    {
        instructionmenu.SetActive(false);
    }
}
