//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Controls for the non-VR debug camera
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	[RequireComponent( typeof( Camera ) )]
	public class FallbackCameraController : MonoBehaviour
	{
		public float speed = 4.0f;
		public float shiftSpeed = 16.0f;
		public bool showInstructions = true;

        private Quaternion camRotation;
        private Vector3 startEulerAngles;
		private Vector3 startMousePosition;
		private float realTime;

        // For 2D Camera Controls
        public float speedH = 4.0f;
        public float speedV = 2.0f;

        private float yaw = 0.0f;
        private float pitch = 0.0f;

        //Camera Zoom
        public Camera mycam;
        public float startFOV = 60f;
        public float endFOV = 30f;
        public float accelFOV = 0.5f;
        bool zoom = false;

        // For keeping player grounded
        public float y;

        // Locking Rotation
        private bool lockRotation = false;
        private bool lockKeyboard = false;
        private Quaternion oldRotation;
        private Quaternion rotation;


        //-------------------------------------------------
        void OnEnable()
		{
            //This locks cursor to the center of the screen
            Cursor.lockState = CursorLockMode.Locked;
			realTime = Time.realtimeSinceStartup;
		}

        private void Start()
        {

            mycam = this.GetComponent<Camera>();
        }


        //-------------------------------------------------
        void Update()
		{

            gameObject.transform.position = new Vector3(transform.position.x, y, transform.position.z);
            float forward = 0.0f;
            if (!lockKeyboard)
            {
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                {
                    forward += 0.5f;
                }
                if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                {
                    forward -= 0.5f;
                }

                float right = 0.0f;
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    right += 0.5f;
                }
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    right -= 0.5f;
                }

                float currentSpeed = speed;
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    currentSpeed = shiftSpeed;
                }
                
                // 2D Controls test
                yaw += speedH * Input.GetAxis("Mouse X");
                pitch -= speedV * Input.GetAxis("Mouse Y") * 2;
			    pitch = Mathf.Clamp(pitch,-75.0f,95.0f);
                transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

                // Camera Zoom Controls (Works only in fullscreen)
                if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Z))
                {
                    mycam.fieldOfView = Mathf.Lerp(mycam.fieldOfView, endFOV, accelFOV);
                }
                else
                {
                    mycam.fieldOfView = Mathf.Lerp(mycam.fieldOfView, startFOV, accelFOV);
                }



                float realTimeNow = Time.realtimeSinceStartup;
                float deltaRealTime = realTimeNow - realTime;
                realTime = realTimeNow;

                Vector3 delta = new Vector3(right, 0.0f, forward) * currentSpeed * deltaRealTime;

                transform.position += transform.TransformDirection(delta);

                //Vector3 mousePosition = Input.mousePosition;

                /*if ( Input.GetMouseButtonDown( 1 )) // right mouse
                {
                    startMousePosition = mousePosition;
                    startEulerAngles = transform.localEulerAngles;
                }

                if ( Input.GetMouseButton( 1 ) ) // right mouse
                {
                    Vector3 offset = mousePosition - startMousePosition;
                    transform.localEulerAngles = startEulerAngles + new Vector3( -offset.y * 360.0f / Screen.height, offset.x * 360.0f / Screen.width, 0.0f );
                }*/

                // 2D Controls test
                yaw += speedH * Input.GetAxis("Mouse X");
                pitch -= speedV * Input.GetAxis("Mouse Y") * 2;
                pitch = Mathf.Clamp(pitch, -75.0f, 95.0f);
                transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            }
			

            // Lock Camera
            if (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.RightAlt))
            {
                if (lockRotation)
                {
                    mycam.transform.rotation = oldRotation;
                    Cursor.lockState = CursorLockMode.Locked;
                } else
                {
                    Cursor.lockState = CursorLockMode.None;
                }
                rotation = mycam.transform.rotation;
                lockRotation = !lockRotation;
                lockKeyboard = !lockKeyboard;
            }

            if (lockRotation)
            {
                mycam.transform.rotation = rotation;
                oldRotation = rotation;
            }



            // Player Boundaries For All Rooms
            //X > -3     X < 3
            //Z > -2.5  Z < 2.65
            if (transform.localPosition.x < -3 || transform.localPosition.x > 3 ||
                transform.localPosition.z < -2.5 || transform.localPosition.z > 2.65)
            {
                transform.localPosition = new Vector3(0f, y, 0f);
            }
        }

		//-------------------------------------------------
		void OnGUI()
		{
			if ( showInstructions )
			{
                /*
				GUI.Label( new Rect( 10.0f, 10.0f, 600.0f, 400.0f ),
					"WASD/Arrow Keys to translate the camera\n" +
					"Right mouse click to rotate the camera\n" +
					"Left mouse click for standard interactions.\n" );
                */
                GUI.Box(new Rect(5.0f, 5.0f, 275f, 88f),
                    "<color=white>Use the mouse to move the camera</color>\n" +
                    "<color=white>Left click to click buttons and grab objects</color>\n" + 
                    "<color=white>WASD/Arrow Keys to translate the camera</color>\n" +
                    "<color=white>Hold E or Z to camera zoom</color>\n" +
                    "<color=white>Press the Alt key to toggle mouse mode</color>\n");
                    //"<color=white>Left mouse click for standard interactions</color>\n");
            }

        }

	}
}
