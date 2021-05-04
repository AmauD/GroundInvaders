using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    #region properties

    #endregion properties



    #region fields
    private Rigidbody _rigidbody;
    private Vector3 _movementInput;
    [SerializeField] [Range(0f, 50f)] private float _speed = 2f;
    #endregion fields



    #region publics methods

    #endregion publics methods



    #region unity messages
    private void Awake()
    {
        if (_rigidbody == null)
        {
            _rigidbody = GetComponent<Rigidbody>();
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

    private void Move()
    {
        var Velocity = _movementInput * _speed;

        _rigidbody.velocity = Velocity;
    }
    #endregion privates methods
}