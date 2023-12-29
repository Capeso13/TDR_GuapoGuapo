using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{

   public GameObject Destruccion;
   public Transform Tierra;

 private void OnTriggerEnter(Collider other)
 {


    Destroy(gameObject);

    Destruccion.SetActive(true);
    Destruccion.transform.position = Tierra.position;
 }
}