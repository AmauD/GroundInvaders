using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    #region fields
    private float _limitX = 3.5f;
    private Rigidbody _rigidbody;
    private Vector3 _movementInput;
    private Transform _transform;
    [SerializeField] [Range(0f, 50f)] private float _speed = 2f;
    #endregion fields



    #region unity messages
    private void Awake()
    {
        if (_rigidbody == null)
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        if (_transform == null)
        {
            _transform = GetComponent<Transform>();
        }

    }

    private void Update()
    {
        UpdateInputMove();
    }

    private void FixedUpdate()
    {
        Move();
    }
    #endregion unity messages



    #region privates methods
    private void UpdateInputMove()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");

        _movementInput = new Vector3(horizontal, 0f, 0f);

    }

    private void ClampMove()
    {
        var positionX = _transform.position.x;

        if (positionX > _limitX || positionX < -_limitX)
        {
            var newPositionX = Mathf.Clamp(positionX, -_limitX, _limitX);
            _transform.position = new Vector3(newPositionX, _transform.position.y, _transform.position.z);
        }
    }

    private void Move()
    {
        var Velocity = _movementInput * _speed;

        _rigidbody.velocity = Velocity;

        ClampMove();
    }
    #endregion privates methods
}