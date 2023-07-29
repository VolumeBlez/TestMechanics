using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _gravityScale = -9.81f;
    [SerializeField] private LayerMask _groundLayer;

    private CharacterController _controller;
    private Vector3 _velocity;
    private float _groundDistance = 0.4f;

    private bool _isGrounded;
    private bool _isJumpSystemActive = false;

    public void Start()
    {
        _controller = GetComponent<CharacterController>();
        _isJumpSystemActive = true;
    }

    private void FixedUpdate() 
    {
        if(_isJumpSystemActive)
        {
            _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundLayer);

            if(_isGrounded && _velocity.y < 0)
                _velocity.y = -2f;
            
            _velocity.y += _gravityScale;
            _controller.Move(_velocity * Time.fixedDeltaTime);
        }
    }
}
