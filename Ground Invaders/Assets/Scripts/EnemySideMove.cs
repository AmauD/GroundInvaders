using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySideMove : MonoBehaviour
{
    #region fields
    private Transform _transform;
    private Vector3 _direction = Vector3.right;
    #endregion fields



    #region unity messages
    private void Awake()
    {
        if (_transform == null) { _transform = GetComponent<Transform>(); }
    }

    private void Update()
    {
        if (_transform.position.x > 3.5f)
        {
            Move(Vector3.right);
        }
        if (_transform.position.x < -3.5f)
        {
            Move(Vector3.left);
        }
    }
    #endregion unity messages

    private void Move(Vector3 direction)
    {
        _transform.Translate(_direction * Time.deltaTime * 1f);
    }
}