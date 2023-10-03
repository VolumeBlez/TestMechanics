using UnityEngine;

public interface IPlayerModel
{
    PlayerData Data { get; }
    Rigidbody Rb { get; }
    Transform RotateObject { get; }
    Camera Camera { get; }

    Health Health { get; }
    PlayerInventory Inventory { get; }
    FlashLight FlashLight { get; }
}
