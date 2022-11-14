using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testinggloabl : MonoBehaviour
{

    public float startTime;
    public float totaltime;
    // Start is called before the first frame update
    void Start()
    {
        SimpleGameManager.Instance.JXON();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        totaltime = Time.time - startTime;
        Debug.Log(totaltime);
    }
}
