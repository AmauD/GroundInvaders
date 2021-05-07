using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region fields
    [SerializeField] private BoolVariable _playerIsAlive;
    [SerializeField] private IntVariable _EnemyRemain;
    private bool _levelEnd = false;
    #endregion fields



    #region unity messages
    private void Update()
    {
        Lose();
        Win();
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3f);

        Debug.Log("Must restart");
    }
    #endregion unity messages



    #region private methods
    private void Win()
    {
        if(_EnemyRemain.Value <= 0 && !_levelEnd)
        {
            _levelEnd = true;
            Debug.Log("Win");
            StartCoroutine("Restart");
        }
    }

    private void Lose()
    {
        if(_playerIsAlive.Value && !_levelEnd)
        {
            _levelEnd = true;
            Debug.Log("Lose");
            StartCoroutine("Restart");
        }
    }
    #endregion private methods
}