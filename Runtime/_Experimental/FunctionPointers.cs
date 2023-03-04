using System;
using System.Collections;
using System.Collections.Generic;
using AOT;
using Mono.Cecil;
using Unity.Burst;
using UnityEngine;
using static Unity.Burst.BurstCompiler;
using static Unity.Mathematics.Operations;


namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // public static Func<float, float> floatFunctionPointer;
        // public static FunctionPointer<float> t = CompileFunctionPointer<float>(()=> floatFunctionPointer.Invoke);
        // public static float ProcessFloat(this float f, FunctionPointer<float> pointer) => pointer.Invoke(f);
    }
    
    [BurstCompile]
    public static class Operations {
        // [BurstCompile]
        // [MonoPInvokeCallback(typeof(p2f))]
        // public static float mul(this float a, float b) => a * b;
        //
        // [BurstCompile]
        // [MonoPInvokeCallback(typeof(p2f))]
        // public static float add(this float a, float b) => a + b;

        // A common interface for both MultiplyFloat and AddFloat methods
        
        
        // Operation Interfaces
        [BurstCompile]
        [MonoPInvokeCallback(typeof(delf2))]
        static float2 f2OP(float2 f1, float2 f2, FunctionPointer<p2f> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y));
        [BurstCompile]
        [MonoPInvokeCallback(typeof(delf3))]
        static float3 f3OP(float3 f1, float3 f2, FunctionPointer<p2f> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y), func.Invoke(f1.z, f2.z));
        [BurstCompile]
        [MonoPInvokeCallback(typeof(delf4))]
        static float4 f4OP(float4 f1, float4 f2, FunctionPointer<p2f> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y), func.Invoke(f1.z, f2.z), func.Invoke(f1.w, f2.w));
        

        // Delegates
        delegate float delf(float a, float b, FunctionPointer<p2f> function);
        delegate float2 delf2(float2 a, float2 b, FunctionPointer<p2f> function);
        delegate float3 delf3(float3 a, float3 b, FunctionPointer<p2f> function);
        delegate float4 delf4(float4 a, float4 b, FunctionPointer<p2f> function);
        
        // operation interfaces
        public delegate float p2f(float a, float b);
        public delegate float2 p2f2(float2 a, float2 b);
        public delegate float3 p2f3(float3 a, float3 b);
        public delegate float4 p2f4(float4 a, float4 b);
        





        // Compiled function pointers
        static FunctionPointer<delf2> funcf2 = Comp<delf2>(f2OP);
        static FunctionPointer<delf3> funcf3 = Comp<delf3>(f3OP);
        static FunctionPointer<delf4> funcf4 = Comp<delf4>(f4OP);
        // static FunctionPointer<p2f2> funcF2OP = Comp<p2f2>(mul);
            
        static FunctionPointer<p2f> FP_mul = Comp<p2f>(math.mul);
        static FunctionPointer<p2f> FP_sum = Comp<p2f>(Unity.Mathematics.mathx.sum);
        static FunctionPointer<p2f> FP_max = Comp<p2f>(math.mul);
        static FunctionPointer<p2f> FP_min = Comp<p2f>(math.mul);
        static FunctionPointer<p2f> Compile(p2f func) => Comp(func);


        // Todo : Clean up
// Works !!!
        public static float2 test2 = f2OP(1.0f, 2.0f, Compile(mathx.mul));
        public static float2 test3 = Process((float2)1.0f, 2.0f, mathx.mul);
        public static float2 test4 = Process((float2)1.0f, 2.0f, mathx.mul);
        
        public static float2 Process(float2 f1, float2 f2, p2f func) => funcf2.Invoke(f1, f2, Compile(func));
        public static float3 Process(float3 f1, float3 f2, p2f func) => funcf3.Invoke(f1, f2, Compile(func));
        public static float4 Process(float4 f1, float4 f2, p2f func) => funcf4.Invoke(f1, f2, Compile(func));

        
        static FunctionPointer<T> Comp<T>(T delegatMethod) where T : Delegate => CompileFunctionPointer(delegatMethod);
    }
    public static partial class mathx
    {
        // [MonoPInvokeCallbackAttribute] attribute to the functions. You need to add this so that IL2CPP works with these functions.
        [BurstCompile, MonoPInvokeCallback(typeof(p2f))] public static float mul(float a, float b) => a * b;
        [BurstCompile, MonoPInvokeCallback(typeof(p2f))] public static float sum(float a, float b) => a + b;
        // [BurstCompile, MonoPInvokeCallback(typeof(p2f))] static float max(float a, float b) => math.max(a, b);
        // [BurstCompile, MonoPInvokeCallback(typeof(p2f))] static float min(float a, float b) => math.min(a, b);
    }
}
