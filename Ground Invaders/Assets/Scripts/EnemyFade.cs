using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFade : MonoBehaviour
{
    #region fields
    private float _interpolate = 0f;
    private float _startFade;
    private MeshRenderer _meshRenderer; 
    #endregion fields



    #region unity messages
    private void Awake()
    {
        if(_meshRenderer == null) {_meshRenderer = GetComponent<MeshRenderer>();}
        _startFade = Time.time + 4f;
    }

    private void Update()
    {
        FadeOut();
    }
    #endregion unity messages



    #region private methods
    private void FadeOut()
    {
        if (Time.time > _startFade)
        {
            _interpolate += 0.5f * Time.deltaTime;
        }

        var color = Color.Lerp(Color.white, new Color(0f, 0f, 0f, 0f), _interpolate);

        _meshRenderer.material.color = color;
    }
    #endregion private methods
}