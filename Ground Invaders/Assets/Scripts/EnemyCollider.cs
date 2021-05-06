using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    #region fields
    [SerializeField] private IntVariable _enemyRemain;
    #endregion fields



    #region unity messages
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    private void OnDestroy() 
    {
        _enemyRemain.Value -= 1;
    }
    #endregion unity messages
}