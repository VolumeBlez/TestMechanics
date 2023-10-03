using UnityEngine;

public class ProductReceiver : MonoBehaviour, IInteractable
{
    public void Interact(IPlayerPresenter playerPresenter)
    {
        playerPresenter.Inventory.RemoveProduct();
    }
}
