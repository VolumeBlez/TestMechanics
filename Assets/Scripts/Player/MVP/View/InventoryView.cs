using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryView : BasePlayerView
{
    [SerializeField] private TMP_Text _productCountView;

    public override void InitView(IPlayerPresenter presenter)
    {
        base.InitView(presenter);
        presenter.Inventory.ProductCountChanged += UpdateProductCount;

        UpdateProductCount();
    }

    private void UpdateProductCount() 
    {
        _productCountView.text = $"Product Count: {Presenter.Inventory.ProductCount}";
    }
}
