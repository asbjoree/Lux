﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lux.Resources.ObjLoader
{
	internal class Material
	{
		public Material(string materialName)
		{
			Name = materialName;
		}

		public string Name { get; set; }

		public Framework.Color AmbientColor { get; set; }
		public Framework.Color DiffuseColor { get; set; }
		public Framework.Color SpecularColor { get; set; }
		public float SpecularCoefficient { get; set; }

		public float Transparency { get; set; }

		public int IlluminationModel { get; set; }

		public string AmbientTextureMap { get; set; }
		public string DiffuseTextureMap { get; set; }

		public string SpecularTextureMap { get; set; }
		public string SpecularHighlightTextureMap { get; set; }

		public string BumpMap { get; set; }
		public string DisplacementMap { get; set; }
		public string StencilDecalMap { get; set; }

		public string AlphaTextureMap { get; set; }
	}
}
