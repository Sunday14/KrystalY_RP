using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class KrystalYRenderPipeline : RenderPipeline
{
    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        BeginFrameRendering(context, cameras);
        foreach(Camera  k_camera in cameras)
        {
            RenderSingleCamera(context,k_camera);
        }
    }

    public static void RenderSingleCamera(ScriptableRenderContext context, Camera k_camera)
    {
        context.SetupCameraProperties(k_camera);
        context.DrawSkybox(k_camera);
        context.Submit();
    }
}
