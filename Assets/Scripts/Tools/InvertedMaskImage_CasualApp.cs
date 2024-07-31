using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class InvertedMaskImage_CasualApp : Image
{
    public override Material materialForRendering
    {
        get
        {
            Material result = Instantiate(base.materialForRendering);
            result.SetInt("_StencilComp", (int)CompareFunction.NotEqual);
            return result;
        }
    }
}
