using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    #region fields
    private Rigidbody _rigidbody;
    private Transform _transform;
    private Vector3 _movementInput;
    [SerializeField] [Range(0f, 50f)] private float _speed = 2f;
    [SerializeField] private FloatVariable _limit;
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
        var position = _transform.position;

        position.x = Mathf.Clamp(position.x, -_limit.Value, _limit.Value);

        _transform.position = new Vector3(position.x, position.y, position.z);
    }

    private void Move()
    {
        var Velocity = _movementInput * _speed;

        _rigidbody.velocity = Velocity;

        ClampMove();
    }
    #endregion privates methods
}