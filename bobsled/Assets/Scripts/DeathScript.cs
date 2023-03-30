using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider track;
    public Camera cam;
    public Collider death_hitbox;
    float timed = 0;
    public GameObject player;
    void Start()
    {
        
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Variableholder.wipeouts++;

            Destroy(player);
        }
    }

    public void OnTriggerEnter(Collider other)
    {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Variableholder.wipeouts++;
            Destroy(player);

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
