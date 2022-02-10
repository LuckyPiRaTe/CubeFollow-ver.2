using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreate : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab;

    public void CreateSpherButton(){
        if (Time.timeScale == 1){
        Instantiate(spherePrefab, new Vector3(Random.Range(-14.5f, 14.5f), 1, Random.Range(-14.5f, 14.5f)), Quaternion.identity);
        }
    }
}
