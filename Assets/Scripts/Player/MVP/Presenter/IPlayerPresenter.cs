using UnityEngine;

public interface IPlayerPresenter
{
    Health Health { get; }
    PlayerInventory Inventory { get; }
    FlashLight FlashLight { get; }

    void PerformRay();
    void SetNewMoveSpeed(float newSpeed);

    void SetMove(Vector3 moveDirection);
    void SetImpact(Vector3 direction, float force, ForceMode mode = ForceMode.Impulse);
    void SetRotation(Vector2 rotation, ref float xRotation);
}
