using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region properties

    #endregion



    #region fields
    private Transform _transform;
    private Rigidbody _rigidBody;

    #endregion



    #region publics methods

    #endregion



    #region unity messages

    private void Awake()
    {
        _transform = gameObject.GetComponent<Transform>();
        _rigidBody = gameObject.GetComponent<Rigidbody>();
    }


    #endregion



    #region privates methods

    #endregion
}
