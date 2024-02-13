using Godot;
using System;
using System.Runtime.CompilerServices;

namespace Scripts
{
    public partial class GameCamera : Camera2D
    {
        float minZoom = 0.5f;
        float maxZoom = 2f;
        float zoomFactor = 0.1f;
        float zoomDuration = 0.2f;

        float zoomLevel = 1.0f;

        public override void _Ready()
        {
            
        }

        public void _SetZoomLevel(float value)
        {
            zoomLevel = Mathf.Clamp(value, minZoom, maxZoom);

            Zoom = new Vector2(zoomLevel, zoomLevel);
        }

        public override void _UnhandledInput(InputEvent @event)
        {
            if (@event.IsActionPressed("ZoomOut"))
                _SetZoomLevel(zoomLevel - zoomFactor);
            else if (@event.IsActionPressed("ZoomIn"))
                _SetZoomLevel(zoomLevel + zoomFactor);
        }
    }
}