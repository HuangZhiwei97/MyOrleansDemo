// <auto-generated />
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 618
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::Orleans.Metadata.FeaturePopulatorAttribute(typeof(OrleansGeneratedCode.OrleansCodeGena3b8c287d4FeaturePopulator))]
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute(@"IGoods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace IGoods
{
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof(global::IGoods.IGoods))]
    internal class OrleansCodeGenGoodsReference : global::Orleans.Runtime.GrainReference, global::IGoods.IGoods
    {
        protected OrleansCodeGenGoodsReference(global::Orleans.Runtime.GrainReference other): base(other)
        {
        }

        OrleansCodeGenGoodsReference(global::Orleans.Runtime.GrainReference other, global::Orleans.CodeGeneration.InvokeMethodOptions invokeMethodOptions): base(other, invokeMethodOptions)
        {
        }

        protected OrleansCodeGenGoodsReference(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context): base(info, context)
        {
        }

        public override global::System.Int32 InterfaceId
        {
            get
            {
                return 192295384;
            }
        }

        public override global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return @"global::IGoods.IGoods";
            }
        }

        public override global::System.Boolean IsCompatible(global::System.Int32 interfaceId)
        {
            return interfaceId == 192295384;
        }

        public override global::System.String GetMethodName(global::System.Int32 interfaceId, global::System.Int32 methodId)
        {
            switch (interfaceId)
            {
                case 192295384:
                    switch (methodId)
                    {
                        case 1255870734:
                            return @"GetGoodsDescribe";
                        case -2121337655:
                            return @"GetGoodsDesc";
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + 192295384 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> GetGoodsDescribe()
        {
            return base.InvokeMethodAsync<global::System.String>(1255870734, null);
        }

        public global::System.Threading.Tasks.Task<global::Entity.GoodsEntity> GetGoodsDesc()
        {
            return base.InvokeMethodAsync<global::Entity.GoodsEntity>(-2121337655, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof(global::IGoods.IGoods), 192295384), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenGoodsMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public async global::System.Threading.Tasks.Task<global::System.Object> Invoke(global::Orleans.Runtime.IAddressable grain, global::Orleans.CodeGeneration.InvokeMethodRequest request)
        {
            global::System.Int32 interfaceId = request.InterfaceId;
            global::System.Int32 methodId = request.MethodId;
            global::System.Object[] arguments = request.Arguments;
            if (grain == null)
                throw new global::System.ArgumentNullException(@"grain");
            switch (interfaceId)
            {
                case 192295384:
                    switch (methodId)
                    {
                        case 1255870734:
                            return await ((global::IGoods.IGoods)grain).GetGoodsDescribe();
                        case -2121337655:
                            return await ((global::IGoods.IGoods)grain).GetGoodsDesc();
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + 192295384 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 192295384;
            }
        }

        public global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }
    }
}

namespace OrleansGeneratedCodeA4356694
{
    using global::Orleans;
    using global::System.Reflection;
}

namespace OrleansGeneratedCode
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
    internal sealed class OrleansCodeGena3b8c287d4FeaturePopulator : global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainInterfaceFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainClassFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Serialization.SerializerFeature>
    {
        public void Populate(global::Orleans.Metadata.GrainInterfaceFeature feature)
        {
            feature.Interfaces.Add(new global::Orleans.Metadata.GrainInterfaceMetadata(typeof(global::IGoods.IGoods), typeof(IGoods.OrleansCodeGenGoodsReference), typeof(IGoods.OrleansCodeGenGoodsMethodInvoker), 192295384));
        }

        public void Populate(global::Orleans.Metadata.GrainClassFeature feature)
        {
        }

        public void Populate(global::Orleans.Serialization.SerializerFeature feature)
        {
            feature.AddKnownType(@"IGoods.IGoods,IGoods", @"IGoods.IGoods");
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
