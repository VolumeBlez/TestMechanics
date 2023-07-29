using UnityEngine;

public class PlayerRotationService : MonoBehaviour
{
    [SerializeField] private GameObject _playerCamera;
    [SerializeField] private  Transform _playerBody;
    private float _xRotation = 0f;
    [SerializeField] private float _mouseSensivity = 9f;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SetDirectionAction(Vector2 direction)
    {
        SetRotation(direction);
    }

    public void SetRotation(Vector2 rotation)
    {
        rotation = rotation * _mouseSensivity * Time.deltaTime;

        _xRotation -= rotation.y;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        _playerCamera.transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        _playerBody.Rotate(Vector3.up * rotation.x);
    }
}
    
