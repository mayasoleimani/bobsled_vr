using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCelebration : MonoBehaviour
{

    public GameObject PersonAnimation;
    public double myTimer;



    // Start is called before the first frame update
    void Start()
    {
        PersonAnimation.GetComponent<Animation>().enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (myTimer > 0)
        {
            myTimer-= Time.deltaTime;
        }
        else
        {
            myTimer = 0;
            PersonAnimation.GetComponent<Animation>().enabled = true;
        }
    }
}
