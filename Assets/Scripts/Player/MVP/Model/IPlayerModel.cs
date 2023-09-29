using UnityEngine;

public interface IPlayerModel
{
    PlayerData Data { get; }
    CharacterController CharacterController { get; }
    Transform RotateObject { get; }
    Camera Camera { get; }

    PlayerHealth Health { get; }
    PlayerInventory Inventory { get; }
}
