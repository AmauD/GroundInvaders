using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollider : MonoBehaviour
{
    #region fields
    private CannonShoot _cannon;
    private Transform _transform;
    [SerializeField] GameObject _bulletExplosionPrefab;

    #endregion

    #region publics methods

    public void Init(CannonShoot cannon)
    {
        _cannon = cannon;
    }
    #endregion



    #region unity messages
    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        var newExplosion = Instantiate(_bulletExplosionPrefab, _transform.position, _transform.rotation);
        Destroy(gameObject);
        Destroy(newExplosion, 1f);
    }

    private void OnDestroy()
    {
        _cannon.CanShoot = true;
    }
    #endregion unity messages
}