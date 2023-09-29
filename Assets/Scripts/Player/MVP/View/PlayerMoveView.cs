using UnityEngine;

public class PlayerMoveView : BasePlayerView
{
    private Vector3 _newDirection;
    private Vector3 _moveDirection;

    private void Update() 
    {
        _moveDirection = transform.right * _newDirection.x + transform.forward * _newDirection.y;
        _moveDirection = _moveDirection.normalized * Time.deltaTime;

        if(_moveDirection != _newDirection)
        {
           // Debug.Log($"move Dir {_moveDirection} ---- new Direction {_newDirection}");
            Presenter.SetMove(_moveDirection);
        }
    }

    public void SetDirectionAction(Vector2 direction)
    {
        _newDirection = direction;
    }
    
    public void ResetAction()
    {
        _newDirection = Vector3.zero;
    }


}
