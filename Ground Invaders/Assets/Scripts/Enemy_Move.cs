using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    #region properties

    #endregion properties



    #region fields
    private Transform _enemyMove;
    [SerializeField] private Rigidbody _myRigidbody;
    [SerializeField] private float _speed = 2f;
    private Vector3 _directionEnemy;
    #endregion fields



    #region publics methods
    public void moveForward()
    {

        _enemyMove.Translate(direction * Time.deltaTime * _speed);
    }

    public void moveLeft()
    {

        _enemyMove.Translate(direction * Time.deltaTime * _speed);
    }

    public void moveRight()
    {

        _enemyMove.Translate(direction * Time.deltaTime * _speed);
    }
    #endregion publics methods



    #region unity messages
    private void Awake() 
    {
        if (_enemyMove == null) 
        {
        _enemyMove = GetComponent<Transform>();
        }
    }
    
    private void Update() 
    {
        if (_enemyMove.position.x > 3.5f)
        {
            moveRight();
        } else if (_enemyMove.position.x < -3.5f)
        {
            moveLeft();
        }
    }
    #endregion unity messages



    #region privates methods

    #endregion privates methods
}