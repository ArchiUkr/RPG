using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CementaryScript : MonoBehaviour
{
  [SerializeField] GameObject cementary;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") { 
        cementary.SetActive(true);
        }
    }

   
}
