using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof : MonoBehaviour
{
    [SerializeField] private MeshRenderer mesh;
    private bool detected;
    public bool Detected{
        get{
            return detected;
        }
        //set{
        //    detected = value;
        //}
    }

    public void ToggleRoof(bool something){
        mesh.enabled = something;
    }

    public void SetDetected(bool something){
        detected = something;
    }

//    void OnTriggerEnter(Collider other) {
//        Debug.Log("Tocada tu vieja");
//    }
}
