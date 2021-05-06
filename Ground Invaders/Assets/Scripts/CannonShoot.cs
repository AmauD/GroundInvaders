using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    #region properties
    public bool CanShoot { get => _canShoot; set => _canShoot = value; }

    #endregion

    #region fields
    [SerializeField] private ProjectileCollider _bulletPrefab;
    private Transform _cannonTransform;
    [SerializeField] private Vector3 _bulletForce = Vector3.zero;
    [SerializeField] Transform _extremityCannon;
    private CannonAngle _cannonRotation;
    [SerializeField] AudioSource _audioSource;
    private bool _canShoot = true;

    #endregion



    #region publics methods

    #endregion



    #region unity messages

    private void Awake()
    {
        _cannonTransform = gameObject.GetComponent<Transform>();
        _cannonRotation = gameObject.GetComponent<CannonAngle>();
        _audioSource = GetComponent<AudioSource>();

    }

    private void Update()
    {
        Shoot();
    }

    #endregion



    #region privates methods

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canShoot)
        {
            _canShoot = false;
            var yForce = _cannonRotation.GetCannonRotation() * 5f;
            _bulletForce.y = yForce;
            ProjectileCollider bullet = Instantiate(_bulletPrefab, _extremityCannon.position, _cannonTransform.rotation);
            bullet.Init(this);
            bullet.GetComponent<Rigidbody>().AddForce(_bulletForce, ForceMode.Impulse);
            _audioSource.Play();
        }
    }

    #endregion
}
