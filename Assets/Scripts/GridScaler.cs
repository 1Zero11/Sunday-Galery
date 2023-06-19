using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GridScaler : UIBehaviour
{
    float baseWidth = 1080f;
    Vector2 baseCellSize; // In editor Cell Size for GridLayoutComponent
    Vector2 baseCellSpacing; // In editor Cell Spacing for GridLayoutComponent
    GridLayoutGroup layoutGroup; //Component

    protected override void Start()
    {
        base.Start();
        RecalculateImages();
    }

    public void RecalculateImages()
    {
        layoutGroup = GetComponent<GridLayoutGroup>();
        baseCellSize = layoutGroup.cellSize;
        baseCellSpacing = layoutGroup.spacing;

        var scale = Screen.width / baseWidth;
        baseWidth = Screen.width;

        layoutGroup.cellSize = scale * baseCellSize;
        layoutGroup.spacing = scale * baseCellSpacing;
        Debug.Log("Image Scale Recalculated");
        Debug.Log($"Width {Screen.width},Height {Screen.height}, Cell Size {layoutGroup.cellSize}");
    }

    protected override void OnRectTransformDimensionsChange()
    {
        base.OnRectTransformDimensionsChange();
        RecalculateImages();
        
    }
}
