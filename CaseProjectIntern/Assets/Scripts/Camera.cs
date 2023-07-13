using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 _Offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    private Vector3 _currentlyVelocity = Vector3.zero;

    private void Awake()
    {
        _Offset = transform.position - target.position;

    }

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + _Offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentlyVelocity, smoothTime);
    }

}
