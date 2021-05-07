using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    #region fields
    [SerializeField] private CannonAngle _cannonRotation;
    private Transform _transform;
    private float _minZPosition;
    private float _maxZPosition;
    #endregion fields



    #region unity messages
    private void Awake()
    {
        if (_transform == null) { _transform = GetComponent<Transform>(); }
        _minZPosition = _transform.position.z;
        _maxZPosition = 7.5f;
    }

    private void Update()
    {
        var closePosition = new Vector3(_transform.position.x, 0.015f, _minZPosition);
        var farPosition = new Vector3(_transform.position.x, 0.015f, _maxZPosition);

        _transform.position = Vector3.Lerp(closePosition, farPosition, _cannonRotation.GetCannonRotation());
    }
    #endregion unity messages



    #region private methods
    
    #endregion private methods
}