using UnityEngine;

public class ChangeSpeed : MonoBehaviour, IInteractable
{
    [SerializeField] private int value = 12;
    public void Interact(IPlayerPresenter playerPresenter)
    {
        playerPresenter.SetNewMoveSpeed(value);
    }
}
