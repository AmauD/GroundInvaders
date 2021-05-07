using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    #region fields
    [SerializeField] AudioClip _audioClip;
    [SerializeField] AudioManager _audioManager;
    #endregion
    #region unity messages
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        _audioManager.Play(_audioClip);
    }
    #endregion unity messages
}