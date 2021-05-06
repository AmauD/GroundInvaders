using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    #region fields
    private float _nextShootTime;
    private float _randomDelay;
    [SerializeField] [Range(0.01f, 1f)] private float _bulletSpeed = 0.1f;
    [SerializeField] [Range(0.5f, 10f)] private float _maxDelay = 2f;
    [SerializeField] private Transform _shooterTransform;
    [SerializeField] private GameObject _projectilePrefab;
    #endregion fields



    #region unity messages
    private void Awake()
    {
        _randomDelay = Random.Range(0.5f, _maxDelay);
    }

    private void Update()
    {
        ShootProjectile();
    }
    #endregion unity messages



    #region private methods
    private void ShootProjectile()
    {
        if (Time.time >= _nextShootTime)
        {
            SpawnProjectile();
            _nextShootTime = Time.time + _randomDelay;

            _randomDelay = Random.Range(0.5f, _maxDelay);
        }
    }

    private void SpawnProjectile()
    {
        var newProjectile = Instantiate(_projectilePrefab, _shooterTransform.position, _shooterTransform.rotation);

        newProjectile.GetComponent<ProjectileMove>().SetSpeed(_bulletSpeed);

        Destroy(newProjectile, 5f);
    }
    #endregion private methods
}