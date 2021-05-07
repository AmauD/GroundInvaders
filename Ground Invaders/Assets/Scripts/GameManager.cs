using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region fields
    [SerializeField] private SceneLoader _sceneLoader;

    #endregion

    #region unity messages
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    #endregion



    #region public methods
    public void GameQuit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void StartGame()
    {
        _sceneLoader.LoadLevel(1);
    }

    #endregion

}
