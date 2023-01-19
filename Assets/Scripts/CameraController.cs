using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WatcherHome
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform _targetObject;
        [SerializeField] private float _cameraSpeed;

        private Vector3 _offset;

        private void Start()
        {
            _offset = _targetObject.position - transform.position;
        }

        private void Update()
        {
            transform.position = Vector3.Slerp(transform.position, _targetObject.position - _offset,
                Time.deltaTime * _cameraSpeed);
        }
    }
}