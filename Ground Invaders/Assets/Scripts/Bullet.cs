using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region properties

    #endregion



    #region fields
    private Transform _transform;
    private Rigidbody _rigidBody;
    [SerializeField] private float _bulletSpeed;

    #endregion



    #region publics methods

    #endregion



    #region unity messages

    private void Awake()
    {
        _transform = gameObject.GetComponent<Transform>();
        _rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        BulletMove();
    }

    #endregion



    #region privates methods

    private void BulletMove()
    {
        Vector3 velocity = _transform.forward * _bulletSpeed;
        Vector3 movementStep = velocity * Time.fixedDeltaTime;
        Vector3 newPos = _transform.position + movementStep;
        _rigidBody.MovePosition(newPos);
    }

    public void Shoot(float speed)
    {
        _bulletSpeed = speed;
    }

    #endregion
}
