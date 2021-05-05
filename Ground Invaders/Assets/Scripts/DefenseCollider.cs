using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseCollider : MonoBehaviour
{
    #region fields
    [SerializeField] [Range(0, 10)] private int _health = 4;
    private Transform _transform;
    private Vector3 _descent;
    private MeshRenderer _meshRenderer;
    private float _currentHealth = 1f;
    #endregion fields



    #region unity messages
    private void Awake()
    {
        if (_transform == null) {_transform = GetComponent<Transform>();}
        if (_meshRenderer == null) { _meshRenderer = GetComponent<MeshRenderer>();}

        _descent.y = -((_transform.position.y * 2f) / _health);
    }

    private void OnCollisionEnter(Collision collision)
    {
        ReceiveDamage();
    }
    #endregion unity messages



    #region private methods
    private void ReceiveDamage()
    {
        _currentHealth -= (1f / _health);

        Color actualColor = Color.Lerp(Color.red, Color.green, _currentHealth);

        _meshRenderer.material.color = actualColor;

        if (_currentHealth > 0.01f) return;

        Destroy(gameObject);
    }
    #endregion private methods
}