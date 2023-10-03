using UnityEngine;

public class PlayerModel : IPlayerModel
{
    
    public PlayerData Data { get; }
    public Transform RotateObject { get; }
    public Rigidbody Rb { get; }
    public Camera Camera { get; }

    public Health Health { get; }
    public PlayerInventory Inventory { get; }
    public FlashLight FlashLight { get; }


    public PlayerModel(PlayerData data, Rigidbody rb, Transform rotateObject, Camera camera)
    {
        Data = data;
        Rb = rb;
        RotateObject = rotateObject;
        Camera = camera;

        Health = new(Data);
        Inventory = new();
        FlashLight = new();
    }
}
