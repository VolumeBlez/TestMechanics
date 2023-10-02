using UnityEngine;

public class ProductReceiver : MonoBehaviour, IInteractable
{
    public void Interact(IPlayerPresenter presenter)
    {
        presenter.Inventory.RemoveProduct();
    }
}
