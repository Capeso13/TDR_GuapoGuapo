using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPlaneta : MonoBehaviour
{
    public GameObject Planeta;
    public float i;
    public float j;
    public float k;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Planeta.transform.position + new Vector3(i,j,k);


       if (Input.GetKey(KeyCode.W)){
        i = i+1;
       }
        if (Input.GetKey(KeyCode.S)){
        i = i-1;
        }

         if (Input.GetKey(KeyCode.Q)){
        j = j+1;
        }
         if (Input.GetKey(KeyCode.A)){
        j = j-1;
        }

         if (Input.GetKey(KeyCode.E)){
        k = k+1;
           }
         if (Input.GetKey(KeyCode.F)){
        k = k-1;
          }
        if (Input.GetKey(KeyCode.R)){
        i=0;
        j=20;
        k=0;
        }
    }
}
