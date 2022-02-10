using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySphere : MonoBehaviour
{
    [SerializeField] UIController uiController;
    private int coint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere"){
            coint++;
            uiController.Score(coint);
            Destroy(other.gameObject);
        }
    }
}
