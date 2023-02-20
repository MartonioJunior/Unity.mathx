﻿
namespace Unity.Mathematics
{
    public partial class Math
    {
        // Shorthands -----------------------------------------
        
        
    
        // float2
        public static readonly float2 f2one = 1;
        /// Shorthand for new float2(0,0)
        public static readonly float2 f2zero = 0;
        /// Shorthand for new float2(0,1)
        public static readonly float2 f2up = new(0, 1);
        /// Shorthand for new float2(0,-1)
        public static readonly float2 f2down = new(0, -1);
        /// Shorthand for new float2(1,0)
        public static readonly float2 f2right = new(1, 0);
        /// Shorthand for new float2(-1,0)
        public static readonly float2 f2left = new(-1, 0);
    
        // float3
        /// Shorthand for new float3(1,1,1)
        public static readonly float3 f3one = 1;
        /// Shorthand for new float3(0,0,0)
        public static readonly float3 f3zero = 0;
        /// Shorthand for new float3(0,1,0)
        public static readonly float3 f3up = new(0, 1, 0);
        /// Shorthand for new float3(1,0,0);
        public static readonly float3 f3right = new(1, 0, 0);
        /// Shorthand for new float3(0,0,1)
        public static readonly float3 f3forward = new(0, 0, 1);
        /// Shorthand for new new float3(0,-1,0)
        public static readonly float3 f3down = new(0, -1, 0);
        /// Shorthand for new float3(-1,0,0)
        public static readonly float3 f3left = new(-1, 0, 0);
        /// Shorthand for new float3(0,0,-1)
        public static readonly float3 f3back = new(0, 0, -1);

        // float3 with implicit naming
        /// Shorthand for new float3(0,1,0)
        public static readonly float3 up = new(0, 1, 0);
        /// Shorthand for new float3(1,0,0);
        public static readonly float3 right = new(1, 0, 0);
        /// Shorthand for new float3(0,0,1)
        public static readonly float3 forward = new(0, 0, 1);
        /// Shorthand for new new float3(0,-1,0)
        public static readonly float3 down = new(0, -1, 0);
        /// Shorthand for new float3(-1,0,0)
        public static readonly float3 left = new(-1, 0, 0);
        /// Shorthand for new float3(0,0,-1)
        public static readonly float3 back = new(0, 0, -1);

        
        // int3
        /// Shorthand for new int3(1,1,1)
        public static readonly int3 i3one = 1;
        /// Shorthand for new int3(0,0,0)
        public static readonly int3 i3zero = 0;
        /// Shorthand for new int3(0,1,0)
        public static readonly int3 i3up = new(0, 1, 0);
        /// Shorthand for new int3(1,0,0);
        public static readonly int3 i3right = new(1, 0, 0);
        /// Shorthand for new int3(0,0,1)
        public static readonly int3 i3forward = new(0, 0, 1);
        /// Shorthand for new new float3(0,-1,0)
        public static readonly int3 i3down = new(0, -1, 0);
        /// Shorthand for new int3(-1,0,0)
        public static readonly int3 i3left = new(-1, 0, 0);
        /// Shorthand for new int3(0,0,-1)
        public static readonly int3 i3back = new(0, 0, -1);

        // float4
        /// Shorthand for new float4(1,1,1,1)
        public static readonly float4 f4one = 1;
        /// Shorthand for new float4(0,0,0,0)
        public static readonly float4 f4zero = 0;
        
        // double2
        /// Shorthand for new double2(1,1)
        public static readonly double2 d2one = 1;
        /// Shorthand for new double2(0,0)
        public static readonly double2 d2zero = 0;
        /// Shorthand for new double2(0,1)
        public static readonly double2 d2up = new(0, 1);
        /// Shorthand for new double2(0,-1)
        public static readonly double2 d2down = new(0, -1);
        /// Shorthand for new double2(1,0)
        public static readonly double2 d2right = new(1, 0);
        /// Shorthand for new double2(-1,0)
        public static readonly double2 leftd2 = new(-1, 0);

        // double3
        /// Shorthand for new double3(1,1,1)
        public static readonly double3 oned3 = 1;
        /// Shorthand for new double3(0,0,0)
        public static readonly double3 zerod3 = 0;
        /// Shorthand for new double3(0,1,0)
        public static readonly double3 upd3 = new(0, 1, 0);
        /// Shorthand for new double3(1,0,0);
        public static readonly double3 d3right = new(1, 0, 0);
        /// Shorthand for new double3(0,0,1)
        public static readonly double3 d3forward = new(0, 0, 1);
        /// Shorthand for new new double3(0,-1,0)
        public static readonly double3 d3down = new(0, -1, 0);
        /// Shorthand for new double3(-1,0,0)
        public static readonly double3 d3left = new(-1, 0, 0);
        /// Shorthand for new double3(0,0,-1)
        public static readonly double3 d3back = new(0, 0, -1);
    
        //double4
        /// Shorthand for new double4(1,1,1,1)
        public static double4 d4one = 1;
        /// Shorthand for new float4(0,0,0,0)
        public static double4 d4zero = 0;

        // .xxxx shader syntax 
        
        /// Shorthand for new float2(f)
        public static float2 xx(this float f) => new(f);
        /// Shorthand for new float3(f)
        public static float3 xxx(this float f) => new(f);
        /// Shorthand for new float4(f)
        public static float4 xxxx(this float f) => new(f);
        
        /// Shorthand for new double2(f)
        public static double2 xx(this double f) => new(f);
        /// Shorthand for new double3(f)
        public static double3 xxx(this double f) => new(f);
        /// Shorthand for new double4(f)
        public static double4 xxxx(this double f) => new(f);

        /// Shorthand for new int2(i)
        public static int2 xx(this int i) => new(i);
        /// Shorthand for new int3(i)
        public static int3 xxx(this int i) => new(i);
        /// Shorthand for new int4(i)
        public static int4 xxxx(this int i) => new(i);
        
        /// Shorthand for new bool2(i)
        public static bool2 xx(this bool b) => new(b);
        /// Shorthand for new bool3(i)
        public static bool3 xxx(this bool b) => new(b);
        /// Shorthand for new bool4(i)
        public static bool4 xxxx(this bool b) => new(b);

        
        /// appends a float to a float to create a float2
        public static float2 xy(this float x, float y) => new(x, y);
        
        /// appends a float to a float2 to create a float3
        public static float3 xyz(this float2 xy, float z) => new(xy, z);
        /// appends a float2 to a float to create a float3
        public static float3 xyz(this float x, float2 yz) => new(x, yz);
        /// appends a float to a float3 to create a float4
        public static float4 xyzw(this float3 xyz, float w) => new(xyz, w);
        /// appends a float2 to a float2 to create a float4
        public static float4 xyzw(this float2 xy, float2 zw) => new(xy, zw);
        /// appends a float3 to a float to create a float4
        public static float4 xyzw(this float x, float3 yzw) => new(x, yzw);

        // Append -------------------------------------------
        
        /// appends a float to a float to create a float2
        public static float2 append(this float x, float y) => new(x, y);
        
        /// appends a float to a float2 to create a float3
        public static float3 append(this float2 xy, float z) => new(xy, z);
        /// appends a float2 to a float to create a float3
        public static float3 append(this float x, float2 yz) => new(x, yz);
        /// appends a float to a float3 to create a float4
        public static float4 append(this float3 xyz, float w) => new(xyz, w);
        /// appends a float2 to a float2 to create a float4
        public static float4 append(this float2 xy, float2 zw) => new(xy, zw);
        /// appends a float3 to a float to create a float4
        public static float4 append(this float x, float3 yzw) => new(x, yzw);
        
        
        // Matrix Shorthands -------------------------------------------
        /// Creates a matrix with the same value in every row
        public static float4x4 f4x4(this float4 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static float4x3 f4x3(this float4 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static float4x2 f4x2(this float4 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static float3x4 f3x4(this float3 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static float3x3 f3x3(this float3 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static float3x2 f3x2(this float3 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static float2x4 f2x4(this float2 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static float2x3 f2x3(this float2 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static float2x2 f2x2(this float2 f) => new(f, f);
        
        
        ///<inheritdoc cref="f4x4(float4)"/>
        public static bool4x4 b4x4(this bool4 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static bool4x3 b4x3(this bool4 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static bool4x2 b4x2(this bool4 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static bool3x4 b3x4(this bool3 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static bool3x3 b3x3(this bool3 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static bool3x2 b3x2(this bool3 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static bool2x4 b2x4(this bool2 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static bool2x3 b2x3(this bool2 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static bool2x2 b2x2(this bool2 f) => new(f, f);
        
        
        ///<inheritdoc cref="f4x4(float4)"/>
        public static int4x4 i4x4(this int4 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static int4x3 i4x3(this int4 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static int4x2 i4x2(this int4 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static int3x4 i3x4(this int3 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static int3x3 i3x3(this int3 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static int3x2 i3x2(this int3 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static int2x4 i2x4(this int2 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static int2x3 i2x3(this int2 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static int2x2 i2x2(this int2 f) => new(f, f);
        
        
        ///<inheritdoc cref="f4x4(float4)"/>
        public static uint4x4 u4x4(this uint4 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static uint4x3 u4x3(this uint4 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static uint4x2 u4x2(this uint4 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static uint3x4 u3x4(this uint3 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static uint3x3 u3x3(this uint3 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static uint3x2 u3x2(this uint3 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static uint2x4 u2x4(this uint2 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static uint2x3 u2x3(this uint2 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        public static uint2x2 u2x2(this uint2 f) => new(f, f);

    }
}