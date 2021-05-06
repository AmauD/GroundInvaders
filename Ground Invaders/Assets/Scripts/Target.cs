using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    #region properties

    #endregion properties



    #region fields
    private CannonAngle _cannonRotation;
    private Transform _transform;
    #endregion fields



    #region public methods

    #endregion public methods



    #region unity messages
    private void Awake()
    {
        if (_transform == null) { _transform = GetComponent<Transform>(); }
        if (_cannonRotation == null) {_cannonRotation = GetComponent<CannonAngle>();}
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    #endregion unity messages



    #region private methods
    
    #endregion private methods
}