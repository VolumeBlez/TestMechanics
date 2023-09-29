using UnityEngine;

public interface IPlayerModel
{
    public PlayerData Data { get; }
    public CharacterController CharacterController { get; }
    public Transform RotateObject { get; }
    public Camera Camera { get; }
    public PlayerHealth Health { get; }
}
