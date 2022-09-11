using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedInFOV = 30f;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = .5f;

    RigidbodyFirstPersonController fpsController;
    bool zoomedInToggle = false;

    void Start() 
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();    
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToggle)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
                fpsController.mouseLook.XSensitivity = zoomInSensitivity;
                fpsController.mouseLook.YSensitivity = zoomInSensitivity;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
                fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
            }
        }
    }
}
