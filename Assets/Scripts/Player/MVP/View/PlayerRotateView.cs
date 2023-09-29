using UnityEngine;

public class PlayerRotateView : BasePlayerView
{
    private float _xRotation;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SetDirectionAction(Vector2 direction) => Presenter.SetRotation(direction, ref _xRotation);
}
