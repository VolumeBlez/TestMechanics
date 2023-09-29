using UnityEngine;

public class ChangeSpeed : MonoBehaviour, IInteractable
{
    [SerializeField] private int value = 12;
    public void Interact(IPlayerPresenter presenter)
    {
        presenter.SetNewMoveSpeed(value);
    }
}
