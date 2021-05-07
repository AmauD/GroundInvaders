using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    #region fields
    [SerializeField] private BoolVariable _playerIsAlive;
    [SerializeField] private IntVariable _EnemyRemain;
    private bool _levelEnd = false;
    #endregion fields



    #region public methods
    public void Lose()
    {
        if (!_playerIsAlive.Value && !_levelEnd)
        {
            _levelEnd = true;
            StartCoroutine("Restart");
        }
    }
    #endregion public methods



    #region unity messages
    private void Awake()
    {
        _playerIsAlive.Value = true;
    }

    private void Update()
    {
        Lose();
        Win();
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    #endregion unity messages



    #region private methods
    private void Win()
    {
        if(_EnemyRemain.Value <= 0 && !_levelEnd)
        {
            _levelEnd = true;
            StartCoroutine("Restart");
        }
    }
    #endregion private methods
}