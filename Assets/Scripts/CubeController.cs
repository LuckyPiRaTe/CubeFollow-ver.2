using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{
    private GameObject[] sphere;
    [SerializeField] private Rigidbody rb;
    private GameObject closest;
    [SerializeField] private float speed = 2;
    [SerializeField] private float speedRotate = 2;

    void Start(){
        StartCoroutine(FindObj());
    }
    void Update()
    {        
        rb.velocity = transform.forward * speed;

        if(closest != null){
        Vector3 dir = closest.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speedRotate * Time.deltaTime);
        }

    }

    GameObject FindClosestEnemy()
    {            
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in sphere)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

    IEnumerator FindObj(){
        sphere = GameObject.FindGameObjectsWithTag("Sphere");
        FindClosestEnemy();
        yield return new  WaitForSeconds(0.2f);
        StartCoroutine(FindObj());
    }
}
