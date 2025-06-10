using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UIGradient : BaseMeshEffect
{
    public Color topColor = Color.white;
    public Color bottomColor = Color.black;

    public override void ModifyMesh(VertexHelper vh)
    {
        if (!IsActive()) return;

        UIVertex vertex = new UIVertex();
        int count = vh.currentVertCount;

        for (int i = 0; i < count; i++)
        {
            vh.PopulateUIVertex(ref vertex, i);
            float normalizedY = vertex.position.y / GetComponent<RectTransform>().rect.height;
            vertex.color = Color.Lerp(bottomColor, topColor, normalizedY + 0.5f);
            vh.SetUIVertex(vertex, i);
        }
    }
}
