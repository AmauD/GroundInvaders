using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    #region fields
    private Transform _transform;
    [SerializeField] private IntVariable _enemyRemain;
    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _enemyDeadPrefab;
    [SerializeField] private IntVariable _myScore;
    #endregion fields



    #region unity messages
    private void Awake()
    {
        if (_transform == null) { _transform = GetComponent<Transform>(); }
        if (_myScore.Value != 0) { _myScore.Value = 0; }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(_parent);
        var newEnemyDead = Instantiate(_enemyDeadPrefab, _transform.position, _transform.rotation);
        Destroy(newEnemyDead, 10f);
    }

    private void OnDestroy() 
    {
        _enemyRemain.Value -= 1;
        _myScore.Value += 10;
        Debug.Log(_myScore.Value);
    }
    #endregion unity messages
}