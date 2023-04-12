using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class holderscript : MonoBehaviour
{

    public GameObject sled;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainmenu()
    {
        Destroy(sled);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void restart()
    {
        Destroy(sled);
        Debug.Log("work");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
