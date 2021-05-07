using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    #region fields
    private float _nextShootTime;
    private float _randomDelay;
    private AudioSource _audioSource;
    [SerializeField] [Range(0.01f, 1f)] private float _bulletSpeed = 0.1f;
    [SerializeField] [Range(0.5f, 10f)] private float _maxDelay = 10f;
    [SerializeField] private Transform _shooterTransform;
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private AudioClip[] _audioClipArray;
    [SerializeField] private IntVariable _enemyRemain;
    #endregion fields



    #region unity messages
    private void Awake()
    {
        if (_audioSource == null) {_audioSource = GetComponent<AudioSource>();}
        _randomDelay = Random.Range(0.5f, _maxDelay);
        _nextShootTime = Random.Range(2f, 10f);
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
            PlayAudioClip();

            _randomDelay = Random.Range(0.5f, _maxDelay * _enemyRemain.Value);
            _nextShootTime = Time.time + _randomDelay;

        }
    }

    private void SpawnProjectile()
    {
        var newProjectile = Instantiate(_projectilePrefab, _shooterTransform.position, _shooterTransform.rotation);

        newProjectile.GetComponent<ProjectileMove>().SetSpeed(_bulletSpeed);

        Destroy(newProjectile, 5f);
    }

    private void PlayAudioClip()
    {
        var choose = Random.Range(0, _audioClipArray.Length);

        _audioSource.PlayOneShot(_audioClipArray[choose]);
    }
    #endregion private methods
}