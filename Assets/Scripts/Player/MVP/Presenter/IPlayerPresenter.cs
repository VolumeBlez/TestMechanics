using UnityEngine;

public interface IPlayerPresenter
{
    void PerformRay();
    void SetNewMoveSpeed(float newSpeed);
    void SetMove(Vector3 moveDirection);
    void SetRotation(Vector2 rotation, ref float xRotation);
}
