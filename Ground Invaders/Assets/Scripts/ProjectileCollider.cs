using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollider : MonoBehaviour
{
    #region fields
    private CannonShoot _cannon;

    #endregion

    #region publics methods

    public void Init(CannonShoot cannon)
    {
        _cannon = cannon;
    }

    #endregion



    #region unity messages
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Destroy");
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        _cannon.CanShoot = true;
    }

    #endregion unity messages
}