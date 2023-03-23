using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_switcher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject player;
 


    public void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        player.SetActive(false);

        StartCoroutine(firstcamera());
    }

    IEnumerator firstcamera()
    {
        yield return new WaitForSeconds(2.2f);
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
        player.SetActive(false);
        StartCoroutine(secondcamera());
    }

    IEnumerator secondcamera()
    {
        yield return new WaitForSeconds(1f);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
        player.SetActive(false);
        StartCoroutine(thirdcamera());
    }

    IEnumerator thirdcamera()
    {
        yield return new WaitForSeconds(3f);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        player.SetActive(true);

    }

 



    /*

    public void switchcam(int x)
    {
        deactivateall();
        if (x == 1)
        {
            cam1.enabled = true;
        }else if (x == 2)
        {
            cam2.enabled = true;
        }
        else
        {
            cam3.enabled = true;
        }
    }
    public void deactivateall()
    {
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = false;
    }
    */
}
