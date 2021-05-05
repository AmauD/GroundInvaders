using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    #region properties

    #endregion properties



    #region fields
    private Transform _enemyMove;
    [SerializeField] private float _speed = 2f;
    #endregion fields



    #region publics methods
    public void moveLeftRight()
    {
        var moveSpeed = Mathf.Pow ((Mathf.Sqrt (56 - EnemyCounter.count) / (Mathf.Sqrt (Mathf.Pow (56, 2) - Mathf.Pow (EnemyCounter.count, 2)))) * 10, 3) - 0.25f;

        var velocity = moveSpeed * Time.deltaTime;
    }
    #endregion publics methods



    #region unity messages

    #endregion unity messages



    #region privates methods

    #endregion privates methods
}