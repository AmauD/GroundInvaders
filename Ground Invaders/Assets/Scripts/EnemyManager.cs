using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    #region fields
    private Transform _transform;
    private Vector3 _direction = Vector3.right;
    [SerializeField] private FloatVariable _limitPosition;
    [SerializeField] private float _speed = 0.2f;
    [SerializeField] private float _time = 1f;
    [SerializeField] private IntVariable _enemyRemain;
    private List<Transform> _enemiesTransform;
    #endregion fields



    #region unity messages
    private void Awake()
    {
        _enemiesTransform = new List<Transform>();
        if (_transform == null) { _transform = GetComponent<Transform>(); }
        for (int i = 0; i < _transform.childCount; i++)
        {
            _enemiesTransform.Add(_transform.GetChild(i));
        }
        _enemyRemain.Value = _enemiesTransform.Count;
    }

    private void Update()
    {
        if (_enemiesTransform.Count <= 0) return;

        for (int i = 0; i < _enemiesTransform.Count; i++)
        {
            if (_enemiesTransform[i] == null)
            {
                _enemiesTransform.RemoveAt(i);
                continue;
            }

            if (_enemiesTransform[i].position.x > _limitPosition.Value)
            {
                SetDirectionLeft();
            }
            if (_enemiesTransform[i].position.x < -_limitPosition.Value)
            {
                SetDirectionRight();
            }
        }

        Move(_direction);
    }
    #endregion unity messages

    private void Move(Vector3 direction)
    {
        _transform.Translate(direction * Time.deltaTime * (_speed / (_enemyRemain.Value + 1)));
    }

    private void SetDirectionLeft()
    {
        _direction = Vector3.forward;
        StartCoroutine("Delay", Vector3.right);
        _transform.Translate(new Vector3(0.01f, 0 , 0));
    }

    private void SetDirectionRight()
    {
        _direction= Vector3.forward;
        StartCoroutine("Delay", Vector3.left);
        _transform.Translate(new Vector3(-0.01f, 0 , 0));
    }

    IEnumerator Delay(Vector3 direction)
    {
        yield return new WaitForSeconds(_time);
        _direction = direction;
    }
}