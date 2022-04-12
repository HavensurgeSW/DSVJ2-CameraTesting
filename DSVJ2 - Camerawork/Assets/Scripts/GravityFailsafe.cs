using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFailsafe : MonoBehaviour
{
  private Vector3 spawn = new Vector3(0, 0.6f, -4);
    void OnTriggerEnter(Collider other){
        Debug.Log("YEET");
        if(other.gameObject.CompareTag("Player")){
            other.gameObject.transform.position = spawn;
        }

    }
}
