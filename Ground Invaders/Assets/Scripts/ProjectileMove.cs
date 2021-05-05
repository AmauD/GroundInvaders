using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    #region fields
    private Transform _transform;
    private Rigidbody _rigidbody;
    private float _speed = 0.1f;
    #endregion fields



    #region public methods
    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    #endregion public methods



    #region unity messages
    private void Awake()
    {
        if (_transform == null) {_transform = GetComponent<Transform>();}
        if (_rigidbody == null) {_rigidbody = GetComponent<Rigidbody>();}
    }

    private void FixedUpdate()
    {
        Move();
    }
    #endregion unity messages



    #region private methods
    private void Move()
    {
        Vector3 velocity = _transform.forward * _speed;
        Vector3 newPosition = _transform.position + velocity;

        _rigidbody.MovePosition(newPosition);
    }
    #endregion private methods
}