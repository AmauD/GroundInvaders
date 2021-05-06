using UnityEngine;

public class CannonAngle : MonoBehaviour
{
    #region fields
    private Transform _transform;
    private Quaternion _minimumCannonRotation;
    private Quaternion _maximumCannonRotation;
    [SerializeField] [Range(0, 1f)] private float _cannonRotation;
    // private float _speed = 5f;
    #endregion

    #region publics methods

    public float GetCannonRotation() => _cannonRotation;

    #endregion

    #region unity messages

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _minimumCannonRotation = Quaternion.Euler(0f, 90f, 0f);
        _maximumCannonRotation = Quaternion.Euler(_transform.rotation.x, 90f, -50f);
    }

    private void Update()
    {
        OrientationCannon();
    }

    #endregion

    #region privates methods

    private void OrientationCannon()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _cannonRotation += 0.002f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _cannonRotation -= 0.002f;
        }
        _cannonRotation = Mathf.Clamp(_cannonRotation, 0.0f, 1.0f);
        _transform.rotation = Quaternion.Slerp(_minimumCannonRotation, _maximumCannonRotation, _cannonRotation);
    }

    #endregion


}