using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class okbutton : MonoBehaviour
{
    public savescript save;
    public GameObject player;
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
