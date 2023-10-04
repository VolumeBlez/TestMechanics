using UnityEngine;

public class InputService : MonoBehaviour
{
    [Header("View Services")]
    [SerializeField] private PlayerMoveView _move;
    [SerializeField] private PlayerInteract _interact;
    [SerializeField] private PlayerRotateView _rotate;
    [SerializeField] private FlashLightView _flashLight;

    [Header("CutScene")]
    [SerializeField] private ExitCutScene _exitCutScene;

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
        Input.Gameplay.ExitCutScene.performed += ctx => _exitCutScene.Exit();
        
    }

    [ContextMenu("Enable Input Manual")]
    public void EnablePlayerInput()
    {
        Input.Gameplay.Move.performed += ctx => _move.SetDirectionAction(ctx.ReadValue<Vector2>());
        Input.Gameplay.Move.canceled += ctx => _move.ResetAction();

        Input.Gameplay.Interact.performed += ctx => _interact.PerformInteract();
        Input.Gameplay.FlashLight.performed += ctx => _flashLight.TurnFlashLight();

        Input.Gameplay.Look.performed += ctx => _rotate.SetDirectionAction(ctx.ReadValue<Vector2>());
    }

    private void OnDisable()
    {
        Input.Disable();
    }

    
}
