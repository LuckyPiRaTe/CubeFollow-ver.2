using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] UIController uiController;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DeathZone"){
            uiController.GameOverScreenOn();
        }
    }
}
