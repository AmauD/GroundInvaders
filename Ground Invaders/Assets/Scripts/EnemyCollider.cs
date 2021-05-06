using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    #region unity messages
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    #endregion unity messages
}