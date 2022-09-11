using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float addIntensity = 1f;

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")    
        {
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightIntensity(addIntensity);
            Destroy(gameObject);
        }
    }

}
