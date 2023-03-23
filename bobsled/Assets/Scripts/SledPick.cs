using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SledPick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sled_turntable;
    public int no_of_sleds;
    void Start()
    {
        no_of_sleds = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }

    public void leftArrowClick()
    {
        onArrowPress('l');
    }
    public void rightArrowClick()
    {
        onArrowPress('r');
    }
    void onArrowPress(char arrow)//- = left, + right
    {
        int scalar;
        if (arrow == 'l')
            scalar = -1;
        else if (arrow == 'r')
            scalar = 1;
        float rotation = 360 / no_of_sleds;
        sled_turntable.transform.Rotate(0f, rotation, 0f, Space.World);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
}
