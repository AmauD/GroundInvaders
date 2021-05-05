using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    #region fields
    private Transform _transform;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private FloatVariable _limitPosition;
    [SerializeField] private float _time = 1f;
    private Vector3 _direction = Vector3.right;
    #endregion fields



    #region unity messages
    private void Awake()
    {
        if (_transform == null) { _transform = GetComponent<Transform>(); }
    }

    private void Update()
    {
        SetDirectionLeft();
        SetDirectionRight();
        Move(_direction);
    }
    #endregion unity messages

    private void Move(Vector3 direction)
    {
        _transform.Translate(direction * Time.deltaTime * _speed);
    }

    private void SetDirectionLeft()
    {
    if (_transform.position.x > _limitPosition.Value)
        {
            _direction = Vector3.forward;
            StartCoroutine("Delay", Vector3.left);
            _transform.Translate(new Vector3(-0.01f, 0 , 0));
        }
    }

    private void SetDirectionRight()
    {
    if (_transform.position.x < -_limitPosition.Value)
        {
            _direction= Vector3.forward;
            StartCoroutine("Delay", Vector3.right);
            _transform.Translate(new Vector3(0.01f, 0 , 0));
        }
    }

    IEnumerator Delay(Vector3 direction)
    {
        yield return new WaitForSeconds(_time);
        _direction = direction;
    }
}