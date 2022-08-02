using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationGizmo : MonoBehaviour
{
    [SerializeField] float destinationPointRadius;

    private void OnDrawGizmos()
    {
        Gizmos.color=Color.red;
        Gizmos.DrawSphere(transform.position,destinationPointRadius);
    }
}
