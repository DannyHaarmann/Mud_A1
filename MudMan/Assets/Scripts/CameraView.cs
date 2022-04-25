using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [SerializeField] private float MouseSens;
    private Transform parent;
    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
