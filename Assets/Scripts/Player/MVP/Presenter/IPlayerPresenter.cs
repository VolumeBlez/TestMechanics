using UnityEngine;

public interface IPlayerPresenter
{
    Health Health { get; }
    PlayerInventory Inventory { get; }
    FlashLight FlashLight { get; }

    void PerformRay();
    void SetNewMoveSpeed(float newSpeed);

    void SetMove(Vector3 moveDirection);
    void SetRotation(Vector2 rotation, ref float xRotation);
}
