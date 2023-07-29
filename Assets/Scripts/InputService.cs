using UnityEngine;

public class InputService : MonoBehaviour
{
    [SerializeField] private PlayerMovement _move;
    //[SerializeField] private PlayerJump _jump;
    [SerializeField] private PlayerRotationService _rotate;

    private Input _input;

    public Input Input
    {
        get
        {
            if(_input != null) return _input;
            return _input = new Input();
        }
    }

    private void Start()
    {
        Input.Enable();

        Input.Gameplay.Move.performed += ctx => _move.SetDirectionAction(ctx.ReadValue<Vector2>());
        Input.Gameplay.Move.canceled += ctx => _move.ResetAction();

        //Input.Gameplay.Jump.performed += ctx => _jump.SetAction();
        //Input.Gameplay.Jump.canceled += ctx => _jump.ResetAction();

        Input.Gameplay.Look.performed += ctx => _rotate.SetDirectionAction(ctx.ReadValue<Vector2>());
    }

    private void OnDisable()
    {
        Input.Disable();
    }

    
}
