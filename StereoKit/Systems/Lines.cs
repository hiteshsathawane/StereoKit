﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StereoKit
{
    /// <summary>A line drawing class! This is an easy way to visualize lines or relationships 
    /// between objects. The current implementatation uses a quad strip that always faces the 
    /// user, via vertex shader manipulation.</summary>
    public static class Lines
    {
        /// <summary>Adds a line to the environment for the current frame.</summary>
        /// <param name="start">Starting point of the line.</param>
        /// <param name="end">End point of the line.</param>
        /// <param name="color">Color for the line, this is embedded in the vertex color of the line.</param>
        /// <param name="thickness">Thickness of the line in meters.</param>
        public static void Add(Vec3 start, Vec3 end, Color32 color, float thickness)
            =>NativeAPI.line_add(start, end, color, thickness);
    }
}
