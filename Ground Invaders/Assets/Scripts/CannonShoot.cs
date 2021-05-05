using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    #region fields

    [SerializeField] private GameObject _bulletPrefab;
    private Transform _cannonTransform;
    [SerializeField] private Vector3 _bulletForce = Vector3.zero;
    [SerializeField] Transform _extremityCannon;

    #endregion



    #region publics methods

    #endregion



    #region unity messages

    private void Awake()
    {
        _cannonTransform = gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        Shoot();
    }

    #endregion



    #region privates methods

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(_bulletPrefab, _extremityCannon.position, _cannonTransform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(_bulletForce, ForceMode.Impulse);
        }
    }

    #endregion
}
