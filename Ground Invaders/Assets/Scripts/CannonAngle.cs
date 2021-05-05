using UnityEngine;

public class CannonAngle : MonoBehaviour
{
    #region fields
    private Transform _transform;
    private float _speed = 5f;
    #endregion

    #region unity messages

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        OrientationCannon();
    }

    #endregion

    #region privates methods

    private void OrientationCannon()
    {
        Vector3 angle = _transform.eulerAngles;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            angle.z -= _speed;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            angle.z += _speed;
        }

        angle.z = Mathf.Clamp(angle.z, 310f, 359.9f);

        _transform.eulerAngles = angle;
    }

    #endregion
}
