﻿using Bridge.Html5;

namespace Bridge.Pixi
{
	[External]
	[ObjectLiteral]
	public class RendererOptions
	{
		/// <summary>
		/// The canvas to use as a view.
		/// </summary>
		[FieldProperty]
		public CanvasElement View { get; set; }

		/// <summary>
		/// If the render view is transparent.
		/// </summary>
		[FieldProperty]
		public bool Transparent { get; set; }

		/// <summary>
		/// Sets antialias (only applicable in Chrome at the moment).
		/// </summary>
		[FieldProperty]
		public bool Antialias { get; set; }

		/// <summary>
		/// Enables drawing buffer preservation, enable this if you need to call ToDataUrl on the WebGL context.
		/// </summary>
		[FieldProperty]
		public bool PreserveDrawingBuffer { get; set; }

		/// <summary>
		/// The resolution of the renderer.
		/// </summary>
		[FieldProperty]
		public Resolution Resolution { get; set; }

		/// <summary>
		/// The background color of the rendered area (shown if not transparent).
		/// </summary>
		[FieldProperty]
		public int BackgroundColor { get; set; }

		/// <summary>
		/// If the render view is automatically resized.
		/// </summary>
		[FieldProperty]
		public bool AutoResize { get; set; }

		/// <summary>
		/// This sets if the CanvasRenderer will clear the canvas or not before the new render pass.
		/// If you wish to set this to false, you must set PreserveDrawingBuffer to true.
		/// </summary>
		[FieldProperty]
		public bool ClearBeforeRender { get; set; }
	}
}