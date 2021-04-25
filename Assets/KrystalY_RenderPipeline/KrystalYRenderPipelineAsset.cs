using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Rendering/Krystal Y Render Pipeline")]
public class KrystalYRenderPipelineAsset : RenderPipelineAsset 
{
    protected override RenderPipeline CreatePipeline()
    {
        return new KrystalYRenderPipeline();
    }

}
