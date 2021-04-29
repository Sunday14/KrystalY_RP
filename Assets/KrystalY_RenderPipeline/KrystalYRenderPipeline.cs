using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class KrystalYRenderPipeline : RenderPipeline
{
    CommandBuffer buffer = new CommandBuffer {name = "Camera Renderer"};
    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        // BeginFrameRendering(context, cameras);
        foreach(Camera  k_camera in cameras)
        {
            RenderSingleCamera(context,k_camera);
        }
    }


    public void RenderSingleCamera(ScriptableRenderContext context, Camera k_camera)
    {
        buffer.BeginSample("Camera Renderer");
        context.ExecuteCommandBuffer(buffer);
        buffer.Clear();
        context.SetupCameraProperties(k_camera);
        context.DrawSkybox(k_camera);
        buffer.EndSample("Camera Renderer"); 
        context.ExecuteCommandBuffer(buffer);
        buffer.Clear();
        context.Submit();
    }
}
