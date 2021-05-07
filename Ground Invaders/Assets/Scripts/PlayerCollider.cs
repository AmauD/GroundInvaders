using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    #region fields
    private Transform _transform;
    [SerializeField] AudioClip _audioClip;
    [SerializeField] AudioManager _audioManager;
    [SerializeField] BoolVariable _playerIsAlive;
    [SerializeField] GameObject _tankDestroyedPrefab;

    #endregion
    #region unity messages
    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _playerIsAlive.Value = false;
        Instantiate(_tankDestroyedPrefab, _transform.position, _transform.rotation);
        Destroy(gameObject);
        _audioManager.Play(_audioClip);
    }
    #endregion unity messages
}