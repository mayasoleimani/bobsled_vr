using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Valve.VR.InteractionSystem
{
    public class breaking : MonoBehaviour
    {
        public Rigidbody rb;
        public float breaking_amount = 0.9f;
        public float min_vel = 10f;
        public float steering_force = 10f;

        public holderscript holder; 

        public SteamVR_Action_Boolean grabPinchAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabPinch");
        public SteamVR_Action_Boolean reset = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabGrip");
        //public SteamVR_Action_Boolean menu = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("menu");
        public SteamVR_Action_Boolean Main = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("menu");
        public SteamVR_Action_Vector2 dpadAction = SteamVR_Input.GetAction<SteamVR_Action_Vector2>("dpad");
        // public SteamVR_Action_Boolean dpad = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabPinch");
        public GameObject player;
        public void HandBrake()
        {
            
            
                if (Mathf.Abs(rb.velocity.magnitude) > min_vel)
                    rb.velocity = rb.velocity * breaking_amount;
                Debug.Log("breaking");
            
            //reduce velcoty
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(player);
        }
        
    public void Steering(Vector2 dir)
        {
            //Debug.Log(dir);
            Vector2 target = new Vector2(-steering_force * dir.x, steering_force * dir.y);
           
            if (target.y < 0)
                target.y = 0;
            rb.AddRelativeForce(target);
            //x = -1 is left
            //y = 1 is forwards
            //if y < 0 dont do anythign
            //if y> 0 go forawards
            //if x < 0 go left
            //if x> 0 go right
        }

        void Start()
        {
            player = this.gameObject;
            Variableholder.runs++;
        }

        // Update is called once per frame
        void Update()
        {
            bool thingy = reset.GetStateDown(SteamVR_Input_Sources.Any);
            if (thingy)//if (reset.lastState == true)
            {
                holder.restart();
               
            }
            Steering(dpadAction.axis);
            if (grabPinchAction.lastState == true)
                HandBrake();
            // Debug.Log(rb.velocity);

            if (Main.lastState == true)
            {
                
                holder.mainmenu();
            }
            Debug.Log("searching" +Main.lastState);
            //
        }
    }
}
