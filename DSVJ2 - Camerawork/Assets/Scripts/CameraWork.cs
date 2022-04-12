using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    [SerializeField] private Transform playerCam;
    public LayerMask terrainLayer;
    public Material newMat;
    public void Update()
    {
        if (Physics.Linecast(this.transform.position, playerCam.position, out RaycastHit hitInfo, terrainLayer))
        {
            hitInfo.collider.gameObject.GetComponent<MeshRenderer>().material = newMat;
        } 
    }
 }

