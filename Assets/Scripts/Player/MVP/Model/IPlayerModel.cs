using Cinemachine;
using UnityEngine;

public interface IPlayerModel
{
    PlayerData Data { get; }
    CharacterController CharacterController { get; }
    Transform RotateObject { get; }
    Camera Camera { get; }

    Health Health { get; }
    PlayerInventory Inventory { get; }
    FlashLight FlashLight { get; }
}
