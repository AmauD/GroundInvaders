using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollider : MonoBehaviour
{
    #region unity messages
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Destroy");
        Destroy(gameObject);
    }
    #endregion unity messages
}