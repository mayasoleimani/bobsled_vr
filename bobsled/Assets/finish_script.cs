using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class finish_script : MonoBehaviour
{
    public GameObject confetti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            Debug.Log("tag");
            
        }
    }

   

        // Update is called once per frame
        void Update()
    {
       
    }
}
