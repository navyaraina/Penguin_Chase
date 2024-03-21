using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    [SerializeFied] private bool _enable =true;
    [SerializeFied, Range(0,0.1f)] private float _amplitude=0.015f;
    [SerializeFied, Range(0,30)] private float _frequency=10f;
    [SerializeField] private Transform _camera=null;    
    [SerializeField] private Transform _cameraHolder=null;

    // public Transform target;
    // public float smoothTime = 3F;
    // private Vector3 velocity = Vector3.zero;

    // // Update is called once per frame
    // void Update()
    // {
    //     Vector3 targetPosition = target.TransformPoint(new Vector3(30.8f, 0, 0));

    //     transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    // }
}
