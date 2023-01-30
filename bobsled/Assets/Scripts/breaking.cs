using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem
{
    public class breaking : MonoBehaviour
    {

        public SteamVR_Action_Boolean grabPinchAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabPinch");
       // public SteamVR_Action_Boolean dpad = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabPinch");
        public void HandBrake()
        {
            //find bobsled velcoty
            //reduce velcoty
        }

        public void Steering(Vector2 dir)
        {
            //if y < 0 dont do anythign
            //if y> 0 go forawards
            //if x < 0 go left
            //if x> 0 go right
        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (grabPinchAction.lastState == true)
                HandBrake();


        }
    }
}
