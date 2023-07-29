using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speedMove = 12f;
    
    private CharacterController _controller;
    private Vector3 _currentDirection;
    private Vector3 _moveDirection;
    private bool _isMoveSystemActive = false;

    public void Start()
    {
        _controller = GetComponent<CharacterController>();
        _isMoveSystemActive = true;
    }

    public void EnableMove()
    {
        _isMoveSystemActive = true;
    }

    public void DisableMove()
    {
        _isMoveSystemActive  = false;
    }

    private void FixedUpdate()
    {
        if(_isMoveSystemActive)
        {
            _moveDirection = transform.right * _currentDirection.x + transform.forward * _currentDirection.y;
            _controller.Move( _moveDirection * _speedMove * Time.deltaTime);
        }
    }

    public void SetDirectionAction(Vector2 direction)
    {
        _currentDirection = direction;
    }
    
    public void ResetAction()
    {
        _currentDirection = Vector3.zero;
    }
}

