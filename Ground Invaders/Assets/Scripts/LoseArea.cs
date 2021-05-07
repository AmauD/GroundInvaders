using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseArea : MonoBehaviour
{
    #region fields
    [SerializeField] LevelManager _levelManager;
    #endregion fields


    #region unity messages
    private void OnTriggerEnter(Collider other)
    {
        _levelManager.Lose();
    }
    #endregion unity messages
}