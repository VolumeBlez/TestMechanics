using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPresenter : IPlayerPresenter
{
    private IPlayerModel _model;
    
    public PlayerPresenter(IPlayerModel model) 
    {
        _model = model;
    }

    public void SetNewMoveSpeed(float newMoveSpeed) 
    {
        if(newMoveSpeed <= 0) return;
        _model.Data.SetMoveSpeed(newMoveSpeed);
    }

    public void SetMove(Vector3 moveDirection)
    {
        _model.CharacterController.Move(moveDirection * _model.Data.MoveSpeed);
    }

    public void SetRotation(Vector2 rotation, ref float xRotation)
    {
        rotation = rotation * _model.Data.MouseSens * Time.deltaTime;

        xRotation -= rotation.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        _model.Camera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        _model.RotateObject.Rotate(Vector3.up * rotation.x);
    }

    public void PerformRay()
    {
        Ray ray = _model.Camera.ScreenPointToRay(Mouse.current.position.ReadValue());

        if(Physics.Raycast(ray, out RaycastHit hit, 10f))
        {
            if(hit.transform.TryGetComponent(out IInteractable interactable))
            {
                interactable.Interact();
            }
        }
    }
}
