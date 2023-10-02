using UnityEngine;

public class ProductCreator : MonoBehaviour, IInteractable
{
    public void Interact(IPlayerPresenter presenter)
    {
        presenter.Inventory.AddProduct();
    }
}
