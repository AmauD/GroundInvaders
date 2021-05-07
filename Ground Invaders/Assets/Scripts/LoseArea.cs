using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseArea : MonoBehaviour
{
    #region fields
    [SerializeField] LevelManager _levelManager;
    [SerializeField] BoolVariable _playerIsAlive;
    #endregion fields


    #region unity messages
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enemy enter");
        _playerIsAlive.Value = false;
        _levelManager.Lose();
    }
    #endregion unity messages
}