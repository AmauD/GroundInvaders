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
    #endregion fields



    #region unity messages
    private void Awake()
    {
        if (_transform == null) { _transform = GetComponent<Transform>(); }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(_parent);
    }

    private void OnDestroy() 
    {
        _enemyRemain.Value -= 1;

        var newEnemyDead = Instantiate(_enemyDeadPrefab, _transform.position, _transform.rotation);

        Destroy(newEnemyDead, 10f);
    }
    #endregion unity messages
}