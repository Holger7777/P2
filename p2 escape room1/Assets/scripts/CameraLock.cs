using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour

    
    {
        private bool isCameraLocked = false;
        private Vector3 originalCameraPosition;



        public void OnLockCameraButtonClicked()
        {
            if (!isCameraLocked)
            {
                // Save the original camera position before locking it
                originalCameraPosition = Camera.main.transform.position;
                isCameraLocked = true;
            }
        }

        public void OnUnlockCameraButtonClicked()
        {
            if (isCameraLocked)
            {
                // Reset the camera position to its original position
                Camera.main.transform.position = originalCameraPosition;
                isCameraLocked = false;
            }
        }

        void Update()
        {
            // Lock the camera position if it's currently locked
            if (isCameraLocked)
            {
                Camera.main.transform.position = originalCameraPosition;
            }
        }
    }

