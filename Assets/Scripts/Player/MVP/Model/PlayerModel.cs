using UnityEngine;

public class PlayerModel : IPlayerModel
{
    public PlayerData Data { get; }
    public CharacterController CharacterController { get; }
    public Transform RotateObject { get; }
    public Camera Camera { get; }

    public Health Health { get; }
    public PlayerInventory Inventory { get; }
    public FlashLight FlashLight { get; }

    public PlayerModel(PlayerData data, CharacterController controller, Transform rotateObject, Camera camera)
    {
        Data = data;
        CharacterController = controller;
        RotateObject = rotateObject;
        Camera = camera;

        Health = new(Data);
        Inventory = new();
        FlashLight = new();
    }
}
