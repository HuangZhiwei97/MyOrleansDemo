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
[assembly: global::Orleans.Metadata.FeaturePopulatorAttribute(typeof(OrleansGeneratedCode.OrleansCodeGen50188aa380FeaturePopulator))]
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute(@"Goods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace OrleansGeneratedCodeF9E94E02
{
    using global::Orleans;
    using global::System.Reflection;
}

namespace OrleansGeneratedCode
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
    internal sealed class OrleansCodeGen50188aa380FeaturePopulator : global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainInterfaceFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainClassFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Serialization.SerializerFeature>
    {
        public void Populate(global::Orleans.Metadata.GrainInterfaceFeature feature)
        {
        }

        public void Populate(global::Orleans.Metadata.GrainClassFeature feature)
        {
        }

        public void Populate(global::Orleans.Serialization.SerializerFeature feature)
        {
            feature.AddKnownType(@"System.Action`9,System.Runtime", @"Action`9'9");
            feature.AddKnownType(@"System.Action`10,System.Runtime", @"Action`10'10");
            feature.AddKnownType(@"System.Action`11,System.Runtime", @"Action`11'11");
            feature.AddKnownType(@"System.Action`12,System.Runtime", @"Action`12'12");
            feature.AddKnownType(@"System.Action`13,System.Runtime", @"Action`13'13");
            feature.AddKnownType(@"System.Action`14,System.Runtime", @"Action`14'14");
            feature.AddKnownType(@"System.Action`15,System.Runtime", @"Action`15'15");
            feature.AddKnownType(@"System.Action`16,System.Runtime", @"Action`16'16");
            feature.AddKnownType(@"System.Func`10,System.Runtime", @"Func`10'10");
            feature.AddKnownType(@"System.Func`11,System.Runtime", @"Func`11'11");
            feature.AddKnownType(@"System.Func`12,System.Runtime", @"Func`12'12");
            feature.AddKnownType(@"System.Func`13,System.Runtime", @"Func`13'13");
            feature.AddKnownType(@"System.Func`14,System.Runtime", @"Func`14'14");
            feature.AddKnownType(@"System.Func`15,System.Runtime", @"Func`15'15");
            feature.AddKnownType(@"System.Func`16,System.Runtime", @"Func`16'16");
            feature.AddKnownType(@"System.Func`17,System.Runtime", @"Func`17'17");
            feature.AddKnownType(@"System.Lazy`2,System.Runtime", @"Lazy`2'2");
            feature.AddKnownType(@"System.Threading.WaitHandleExtensions,System.Runtime", @"WaitHandleExtensions");
            feature.AddKnownType(@"System.Runtime.AssemblyTargetedPatchBandAttribute,System.Runtime", @"AssemblyTargetedPatchBandAttribute");
            feature.AddKnownType(@"System.Runtime.TargetedPatchingOptOutAttribute,System.Runtime", @"TargetedPatchingOptOutAttribute");
            feature.AddKnownType(@"System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute,System.Runtime", @"PrePrepareMethodAttribute");
            feature.AddKnownType(@"System.Reflection.RuntimeReflectionExtensions,System.Runtime", @"RuntimeReflectionExtensions");
            feature.AddKnownType(@"System.IO.FileAttributes,System.Runtime", @"FileAttributes");
            feature.AddKnownType(@"System.IO.HandleInheritability,System.Runtime", @"HandleInheritability");
            feature.AddKnownType(@"FxResources.System.Collections.SR,System.Collections", @"FxResources.System.Collections.SR");
            feature.AddKnownType(@"System.SR,System.Collections", @"SR");
            feature.AddKnownType(@"System.Collections.BitArray,System.Collections", @"BitArray");
            feature.AddKnownType(@"System.Collections.StructuralComparisons,System.Collections", @"StructuralComparisons");
            feature.AddKnownType(@"System.Collections.StructuralEqualityComparer,System.Collections", @"StructuralEqualityComparer");
            feature.AddKnownType(@"System.Collections.StructuralComparer,System.Collections", @"StructuralComparer");
            feature.AddKnownType(@"System.Collections.HashHelpers,System.Collections", @"HashHelpers");
            feature.AddKnownType(@"System.Collections.Generic.BitHelper,System.Collections", @"BitHelper");
            feature.AddKnownType(@"System.Collections.Generic.CollectionExtensions,System.Collections", @"CollectionExtensions");
            feature.AddKnownType(@"System.Collections.Generic.ICollectionDebugView`1,System.Collections", @"ICollectionDebugView`1'1");
            feature.AddKnownType(@"System.Collections.Generic.IDictionaryDebugView`2,System.Collections", @"IDictionaryDebugView`2'2");
            feature.AddKnownType(@"System.Collections.Generic.DictionaryKeyCollectionDebugView`2,System.Collections", @"DictionaryKeyCollectionDebugView`2'2");
            feature.AddKnownType(@"System.Collections.Generic.DictionaryValueCollectionDebugView`2,System.Collections", @"DictionaryValueCollectionDebugView`2'2");
            feature.AddKnownType(@"System.Collections.Generic.HashSet`1+ElementCount,System.Collections", @"ElementCount'1");
            feature.AddKnownType(@"System.Collections.Generic.HashSet`1+Slot,System.Collections", @"Slot'1");
            feature.AddKnownType(@"System.Collections.Generic.HashSet`1+Enumerator,System.Collections", @"HashSet`1'1.Enumerator'1");
            feature.AddKnownType(@"System.Collections.Generic.HashSetEqualityComparer`1,System.Collections", @"HashSetEqualityComparer`1'1");
            feature.AddKnownType(@"System.Collections.Generic.LinkedList`1+Enumerator,System.Collections", @"LinkedList`1'1.Enumerator'1");
            feature.AddKnownType(@"System.Collections.Generic.LinkedListNode`1,System.Collections", @"LinkedListNode`1'1");
            feature.AddKnownType(@"System.Collections.Generic.Queue`1+Enumerator,System.Collections", @"Queue`1'1.Enumerator'1");
            feature.AddKnownType(@"System.Collections.Generic.QueueDebugView`1,System.Collections", @"QueueDebugView`1'1");
            feature.AddKnownType(@"System.Collections.Generic.SortedDictionary`2+Enumerator,System.Collections", @"SortedDictionary`2'2.Enumerator'2");
            feature.AddKnownType(@"System.Collections.Generic.SortedDictionary`2+KeyCollection,System.Collections", @"SortedDictionary`2'2.KeyCollection'2");
            feature.AddKnownType(@"System.Collections.Generic.SortedDictionary`2+KeyCollection+Enumerator,System.Collections", @"SortedDictionary`2'2.KeyCollection'2.Enumerator'2");
            feature.AddKnownType(@"System.Collections.Generic.SortedDictionary`2+ValueCollection,System.Collections", @"SortedDictionary`2'2.ValueCollection'2");
            feature.AddKnownType(@"System.Collections.Generic.SortedDictionary`2+ValueCollection+Enumerator,System.Collections", @"SortedDictionary`2'2.ValueCollection'2.Enumerator'2");
            feature.AddKnownType(@"System.Collections.Generic.SortedDictionary`2+KeyValuePairComparer,System.Collections", @"SortedDictionary`2'2.KeyValuePairComparer'2");
            feature.AddKnownType(@"System.Collections.Generic.TreeSet`1,System.Collections", @"TreeSet`1'1");
            feature.AddKnownType(@"System.Collections.Generic.SortedList`2+KeyList,System.Collections", @"SortedList`2'2.KeyList'2");
            feature.AddKnownType(@"System.Collections.Generic.SortedList`2+ValueList,System.Collections", @"SortedList`2'2.ValueList'2");
            feature.AddKnownType(@"System.Collections.Generic.NodeColor,System.Collections", @"NodeColor");
            feature.AddKnownType(@"System.Collections.Generic.TreeWalkPredicate`1,System.Collections", @"TreeWalkPredicate`1'1");
            feature.AddKnownType(@"System.Collections.Generic.TreeRotation,System.Collections", @"TreeRotation");
            feature.AddKnownType(@"System.Collections.Generic.SortedSet`1+Node,System.Collections", @"Node'1");
            feature.AddKnownType(@"System.Collections.Generic.SortedSet`1+Enumerator,System.Collections", @"SortedSet`1'1.Enumerator'1");
            feature.AddKnownType(@"System.Collections.Generic.SortedSet`1+ElementCount,System.Collections", @"ElementCount'1");
            feature.AddKnownType(@"System.Collections.Generic.SortedSet`1+TreeSubSet,System.Collections", @"TreeSubSet'1");
            feature.AddKnownType(@"System.Collections.Generic.SortedSetEqualityComparer`1,System.Collections", @"SortedSetEqualityComparer`1'1");
            feature.AddKnownType(@"System.Collections.Generic.Stack`1+Enumerator,System.Collections", @"Stack`1'1.Enumerator'1");
            feature.AddKnownType(@"System.Collections.Generic.StackDebugView`1,System.Collections", @"StackDebugView`1'1");
            feature.AddKnownType(@"System.Collections.Generic.EnumerableHelpers,System.Collections", @"EnumerableHelpers");
            feature.AddKnownType(@"Interop,System.Console", @"Interop");
            feature.AddKnownType(@"Interop+Kernel32,System.Console", @"Kernel32");
            feature.AddKnownType(@"Interop+Kernel32+CONSOLE_CURSOR_INFO,System.Console", @"CONSOLE_CURSOR_INFO");
            feature.AddKnownType(@"Interop+Kernel32+CONSOLE_SCREEN_BUFFER_INFO,System.Console", @"CONSOLE_SCREEN_BUFFER_INFO");
            feature.AddKnownType(@"Interop+Kernel32+COORD,System.Console", @"COORD");
            feature.AddKnownType(@"Interop+Kernel32+SMALL_RECT,System.Console", @"SMALL_RECT");
            feature.AddKnownType(@"Interop+Kernel32+Color,System.Console", @"Color");
            feature.AddKnownType(@"Interop+Kernel32+CHAR_INFO,System.Console", @"CHAR_INFO");
            feature.AddKnownType(@"Interop+Kernel32+ConsoleCtrlHandlerRoutine,System.Console", @"ConsoleCtrlHandlerRoutine");
            feature.AddKnownType(@"Interop+BOOL,System.Console", @"BOOL");
            feature.AddKnownType(@"Interop+User32,System.Console", @"User32");
            feature.AddKnownType(@"Interop+KeyEventRecord,System.Console", @"KeyEventRecord");
            feature.AddKnownType(@"Interop+InputRecord,System.Console", @"InputRecord");
            feature.AddKnownType(@"FxResources.System.Console.SR,System.Console", @"FxResources.System.Console.SR");
            feature.AddKnownType(@"System.Console,System.Console", @"Console");
            feature.AddKnownType(@"System.ConsoleCancelEventHandler,System.Console", @"ConsoleCancelEventHandler");
            feature.AddKnownType(@"System.ConsoleCancelEventArgs,System.Console", @"ConsoleCancelEventArgs");
            feature.AddKnownType(@"System.ConsoleColor,System.Console", @"ConsoleColor");
            feature.AddKnownType(@"System.ConsoleSpecialKey,System.Console", @"ConsoleSpecialKey");
            feature.AddKnownType(@"System.ConsoleKey,System.Console", @"ConsoleKey");
            feature.AddKnownType(@"System.ConsoleKeyInfo,System.Console", @"ConsoleKeyInfo");
            feature.AddKnownType(@"System.ConsoleModifiers,System.Console", @"ConsoleModifiers");
            feature.AddKnownType(@"System.ConsolePal,System.Console", @"ConsolePal");
            feature.AddKnownType(@"System.ConsolePal+ControlKeyState,System.Console", @"ControlKeyState");
            feature.AddKnownType(@"System.IO.ConsoleStream,System.Console", @"ConsoleStream");
            feature.AddKnownType(@"System.ConsolePal+ControlCHandlerRegistrar,System.Console", @"ControlCHandlerRegistrar");
            feature.AddKnownType(@"System.SR,System.Console", @"SR");
            feature.AddKnownType(@"System.Text.ConsoleEncoding,System.Console", @"ConsoleEncoding");
            feature.AddKnownType(@"System.Text.OSEncoding,System.Console", @"OSEncoding");
            feature.AddKnownType(@"System.Text.OSEncoder,System.Console", @"OSEncoder");
            feature.AddKnownType(@"System.Text.DecoderDBCS,System.Console", @"DecoderDBCS");
            feature.AddKnownType(@"System.Text.EncodingHelper,System.Console", @"EncodingHelper");
            feature.AddKnownType(@"System.IO.SyncTextReader,System.Console", @"SyncTextReader");
            feature.AddKnownType(@"System.IO.SyncTextWriter,System.Console", @"SyncTextWriter");
            feature.AddKnownType(@"System.IO.Error,System.Console", @"Error");
            feature.AddKnownType(@"System.IO.Win32Marshal,System.Console", @"Win32Marshal");
            feature.AddKnownType(@"FxResources.System.Linq.SR,System.Linq", @"FxResources.System.Linq.SR");
            feature.AddKnownType(@"System.SR,System.Linq", @"SR");
            feature.AddKnownType(@"System.Linq.Enumerable,System.Linq", @"Enumerable");
            feature.AddKnownType(@"System.Linq.Enumerable+Iterator`1,System.Linq", @"Iterator`1'1");
            feature.AddKnownType(@"System.Linq.IIListProvider`1,System.Linq", @"IIListProvider`1'1");
            feature.AddKnownType(@"System.Linq.IPartition`1,System.Linq", @"IPartition`1'1");
            feature.AddKnownType(@"System.Linq.Enumerable+WhereArrayIterator`1,System.Linq", @"WhereArrayIterator`1'1");
            feature.AddKnownType(@"System.Linq.Buffer`1,System.Linq", @"Buffer`1'1");
            feature.AddKnownType(@"System.Linq.SystemCore_EnumerableDebugView`1,System.Linq", @"SystemCore_EnumerableDebugView`1'1");
            feature.AddKnownType(@"System.Linq.SystemCore_EnumerableDebugViewEmptyException,System.Linq", @"SystemCore_EnumerableDebugViewEmptyException");
            feature.AddKnownType(@"System.Linq.SystemCore_EnumerableDebugView,System.Linq", @"SystemCore_EnumerableDebugView");
            feature.AddKnownType(@"System.Linq.SystemLinq_GroupingDebugView`2,System.Linq", @"SystemLinq_GroupingDebugView`2'2");
            feature.AddKnownType(@"System.Linq.SystemLinq_LookupDebugView`2,System.Linq", @"SystemLinq_LookupDebugView`2'2");
            feature.AddKnownType(@"System.Linq.Error,System.Linq", @"Error");
            feature.AddKnownType(@"System.Linq.IGrouping`2,System.Linq", @"IGrouping`2'2");
            feature.AddKnownType(@"System.Linq.Grouping`2,System.Linq", @"Grouping`2'2");
            feature.AddKnownType(@"System.Linq.GroupedResultEnumerable`4,System.Linq", @"GroupedResultEnumerable`4'4");
            feature.AddKnownType(@"System.Linq.GroupedResultEnumerable`3,System.Linq", @"GroupedResultEnumerable`3'3");
            feature.AddKnownType(@"System.Linq.GroupedEnumerable`3,System.Linq", @"GroupedEnumerable`3'3");
            feature.AddKnownType(@"System.Linq.GroupedEnumerable`2,System.Linq", @"GroupedEnumerable`2'2");
            feature.AddKnownType(@"System.Linq.ILookup`2,System.Linq", @"ILookup`2'2");
            feature.AddKnownType(@"System.Linq.Lookup`2,System.Linq", @"Lookup`2'2");
            feature.AddKnownType(@"System.Linq.IOrderedEnumerable`1,System.Linq", @"IOrderedEnumerable`1'1");
            feature.AddKnownType(@"System.Linq.OrderedEnumerable`1,System.Linq", @"OrderedEnumerable`1'1");
            feature.AddKnownType(@"System.Linq.OrderedEnumerable`2,System.Linq", @"OrderedEnumerable`2'2");
            feature.AddKnownType(@"System.Linq.CachingComparer`1,System.Linq", @"CachingComparer`1'1");
            feature.AddKnownType(@"System.Linq.CachingComparer`2,System.Linq", @"CachingComparer`2'2");
            feature.AddKnownType(@"System.Linq.CachingComparerWithChild`2,System.Linq", @"CachingComparerWithChild`2'2");
            feature.AddKnownType(@"System.Linq.EnumerableSorter`1,System.Linq", @"EnumerableSorter`1'1");
            feature.AddKnownType(@"System.Linq.EnumerableSorter`2,System.Linq", @"EnumerableSorter`2'2");
            feature.AddKnownType(@"System.Linq.EmptyPartition`1,System.Linq", @"EmptyPartition`1'1");
            feature.AddKnownType(@"System.Linq.OrderedPartition`1,System.Linq", @"OrderedPartition`1'1");
            feature.AddKnownType(@"System.Linq.Set`1,System.Linq", @"Set`1'1");
            feature.AddKnownType(@"System.Linq.SingleLinkedNode`1,System.Linq", @"SingleLinkedNode`1'1");
            feature.AddKnownType(@"System.Linq.Utilities,System.Linq", @"Utilities");
            feature.AddKnownType(@"System.Collections.Generic.ArrayBuilder`1,System.Linq", @"ArrayBuilder`1'1");
            feature.AddKnownType(@"System.Collections.Generic.EnumerableHelpers,System.Linq", @"EnumerableHelpers");
            feature.AddKnownType(@"System.Collections.Generic.CopyPosition,System.Linq", @"CopyPosition");
            feature.AddKnownType(@"System.Collections.Generic.LargeArrayBuilder`1,System.Linq", @"LargeArrayBuilder`1'1");
            feature.AddKnownType(@"System.Collections.Generic.Marker,System.Linq", @"Marker");
            feature.AddKnownType(@"System.Collections.Generic.SparseArrayBuilder`1,System.Linq", @"SparseArrayBuilder`1'1");
            feature.AddKnownType(@"Newtonsoft.Json.SerializationBinder,Newtonsoft.Json", @"Newtonsoft.Json.SerializationBinder");
            feature.AddKnownType(@"Goods.Program,Goods", @"Goods.Program");
            feature.AddKnownType(@"System.Runtime.Serialization.Formatters.FormatterAssemblyStyle,Newtonsoft.Json", @"FormatterAssemblyStyle");
            feature.AddKnownType(@"Newtonsoft.Json.TraceLevel,Newtonsoft.Json", @"Newtonsoft.Json.TraceLevel");
            feature.AddKnownType(@"Newtonsoft.Json.Utilities.MethodBinder,Newtonsoft.Json", @"Newtonsoft.Json.Utilities.MethodBinder");
            feature.AddKnownType(@"Newtonsoft.Json.Utilities.MemberTypes,Newtonsoft.Json", @"Newtonsoft.Json.Utilities.MemberTypes");
            feature.AddKnownType(@"Newtonsoft.Json.Utilities.BindingFlags,Newtonsoft.Json", @"Newtonsoft.Json.Utilities.BindingFlags");
            feature.AddKnownType(@"Newtonsoft.Json.Serialization.FormatterConverter,Newtonsoft.Json", @"Newtonsoft.Json.Serialization.FormatterConverter");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.ConsoleLoggerExtensions,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.ConsoleLoggerExtensions");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.ConfigurationConsoleLoggerSettings,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.ConfigurationConsoleLoggerSettings");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.ConsoleLogger,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.ConsoleLogger");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.ConsoleLoggerOptions,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.ConsoleLoggerOptions");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.ConsoleLoggerProvider,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.ConsoleLoggerProvider");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.ConsoleLoggerSettings,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.ConsoleLoggerSettings");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.ConsoleLogScope,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.ConsoleLogScope");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.Internal.AnsiLogConsole,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.Internal.AnsiLogConsole");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.Internal.IConsole,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.Internal.IConsole");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.Internal.ConsoleLoggerProcessor,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.Internal.ConsoleLoggerProcessor");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.Internal.IAnsiSystemConsole,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.Internal.IAnsiSystemConsole");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.Internal.LogMessageEntry,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.Internal.LogMessageEntry");
            feature.AddKnownType(@"Microsoft.Extensions.Logging.Console.Internal.WindowsLogConsole,Microsoft.Extensions.Logging.Console", @"Microsoft.Extensions.Logging.Console.Internal.WindowsLogConsole");
            feature.AddKnownType(@"Interop,System.Net.Primitives", @"Interop");
            feature.AddKnownType(@"Interop+IpHlpApi,System.Net.Primitives", @"IpHlpApi");
            feature.AddKnownType(@"Interop+IpHlpApi+FIXED_INFO,System.Net.Primitives", @"IpHlpApi.FIXED_INFO");
            feature.AddKnownType(@"Interop+IpHlpApi+IP_ADDR_STRING,System.Net.Primitives", @"IpHlpApi.IP_ADDR_STRING");
            feature.AddKnownType(@"Interop+Kernel32,System.Net.Primitives", @"Kernel32");
            feature.AddKnownType(@"FxResources.System.Net.Primitives.SR,System.Net.Primitives", @"FxResources.System.Net.Primitives.SR");
            feature.AddKnownType(@"Microsoft.Win32.SafeHandles.SafeLocalAllocHandle,System.Net.Primitives", @"Microsoft.Win32.SafeHandles.SafeLocalAllocHandle");
            feature.AddKnownType(@"System.IPv4AddressHelper,System.Net.Primitives", @"IPv4AddressHelper");
            feature.AddKnownType(@"System.IPv6AddressHelper,System.Net.Primitives", @"IPv6AddressHelper");
            feature.AddKnownType(@"System.StringExtensions,System.Net.Primitives", @"StringExtensions");
            feature.AddKnownType(@"System.Marvin,System.Net.Primitives", @"Marvin");
            feature.AddKnownType(@"System.NotImplemented,System.Net.Primitives", @"NotImplemented");
            feature.AddKnownType(@"System.SR,System.Net.Primitives", @"SR");
            feature.AddKnownType(@"System.IO.StringBuilderCache,System.Net.Primitives", @"StringBuilderCache");
            feature.AddKnownType(@"System.Security.Authentication.SslProtocols,System.Net.Primitives", @"SslProtocols");
            feature.AddKnownType(@"System.Security.Authentication.ExchangeAlgorithmType,System.Net.Primitives", @"ExchangeAlgorithmType");
            feature.AddKnownType(@"System.Security.Authentication.CipherAlgorithmType,System.Net.Primitives", @"CipherAlgorithmType");
            feature.AddKnownType(@"System.Security.Authentication.HashAlgorithmType,System.Net.Primitives", @"HashAlgorithmType");
            feature.AddKnownType(@"System.Security.Authentication.ExtendedProtection.ChannelBinding,System.Net.Primitives", @"ChannelBinding");
            feature.AddKnownType(@"System.Security.Authentication.ExtendedProtection.ChannelBindingKind,System.Net.Primitives", @"ChannelBindingKind");
            feature.AddKnownType(@"System.Net.AuthenticationSchemes,System.Net.Primitives", @"AuthenticationSchemes");
            feature.AddKnownType(@"System.Net.CookieVariant,System.Net.Primitives", @"CookieVariant");
            feature.AddKnownType(@"System.Net.Cookie,System.Net.Primitives", @"Cookie");
            feature.AddKnownType(@"System.Net.HeaderVariantInfo,System.Net.Primitives", @"HeaderVariantInfo");
            feature.AddKnownType(@"System.Net.CookieContainer,System.Net.Primitives", @"CookieContainer");
            feature.AddKnownType(@"System.Net.PathList,System.Net.Primitives", @"PathList");
            feature.AddKnownType(@"System.Net.CookieCollection,System.Net.Primitives", @"CookieCollection");
            feature.AddKnownType(@"System.Net.CookieCollection+Stamp,System.Net.Primitives", @"Stamp");
            feature.AddKnownType(@"System.Net.CookieException,System.Net.Primitives", @"CookieException");
            feature.AddKnownType(@"System.Net.CredentialCache,System.Net.Primitives", @"CredentialCache");
            feature.AddKnownType(@"System.Net.ICredentials,System.Net.Primitives", @"ICredentials");
            feature.AddKnownType(@"System.Net.ICredentialsByHost,System.Net.Primitives", @"ICredentialsByHost");
            feature.AddKnownType(@"System.Net.CredentialKey,System.Net.Primitives", @"CredentialKey");
            feature.AddKnownType(@"System.Net.SystemNetworkCredential,System.Net.Primitives", @"SystemNetworkCredential");
            feature.AddKnownType(@"System.Net.NetworkCredential,System.Net.Primitives", @"NetworkCredential");
            feature.AddKnownType(@"System.Net.CredentialHostKey,System.Net.Primitives", @"CredentialHostKey");
            feature.AddKnownType(@"System.Net.DecompressionMethods,System.Net.Primitives", @"DecompressionMethods");
            feature.AddKnownType(@"System.Net.DnsEndPoint,System.Net.Primitives", @"DnsEndPoint");
            feature.AddKnownType(@"System.Net.EndPoint,System.Net.Primitives", @"EndPoint");
            feature.AddKnownType(@"System.Net.HttpStatusCode,System.Net.Primitives", @"HttpStatusCode");
            feature.AddKnownType(@"System.Net.HttpVersion,System.Net.Primitives", @"HttpVersion");
            feature.AddKnownType(@"System.Net.IPAddressParser,System.Net.Primitives", @"IPAddressParser");
            feature.AddKnownType(@"System.Net.IWebProxy,System.Net.Primitives", @"IWebProxy");
            feature.AddKnownType(@"System.Net.NetEventSource,System.Net.Primitives", @"NetEventSource");
            feature.AddKnownType(@"System.Net.NetEventSource+Keywords,System.Net.Primitives", @"NetEventSource.Keywords");
            feature.AddKnownType(@"System.Net.TransportContext,System.Net.Primitives", @"TransportContext");
            feature.AddKnownType(@"System.Net.ByteOrder,System.Net.Primitives", @"ByteOrder");
            feature.AddKnownType(@"System.Net.CookieComparer,System.Net.Primitives", @"CookieComparer");
            feature.AddKnownType(@"System.Net.CookieToken,System.Net.Primitives", @"CookieToken");
            feature.AddKnownType(@"System.Net.CookieTokenizer,System.Net.Primitives", @"CookieTokenizer");
            feature.AddKnownType(@"System.Net.CookieParser,System.Net.Primitives", @"CookieParser");
            feature.AddKnownType(@"System.Net.TcpValidationHelpers,System.Net.Primitives", @"TcpValidationHelpers");
            feature.AddKnownType(@"System.Net.SocketAddress,System.Net.Primitives", @"SocketAddress");
            feature.AddKnownType(@"System.Net.SocketAddressPal,System.Net.Primitives", @"SocketAddressPal");
            feature.AddKnownType(@"System.Net.Cache.RequestCacheLevel,System.Net.Primitives", @"RequestCacheLevel");
            feature.AddKnownType(@"System.Net.Cache.RequestCachePolicy,System.Net.Primitives", @"RequestCachePolicy");
            feature.AddKnownType(@"System.Net.NetworkInformation.IPAddressCollection,System.Net.Primitives", @"IPAddressCollection");
            feature.AddKnownType(@"System.Net.NetworkInformation.HostInformation,System.Net.Primitives", @"HostInformation");
            feature.AddKnownType(@"System.Net.NetworkInformation.HostInformationPal,System.Net.Primitives", @"HostInformationPal");
            feature.AddKnownType(@"System.Net.Security.AuthenticationLevel,System.Net.Primitives", @"AuthenticationLevel");
            feature.AddKnownType(@"System.Net.Security.SslPolicyErrors,System.Net.Primitives", @"SslPolicyErrors");
            feature.AddKnownType(@"System.Net.Sockets.SocketException,System.Net.Primitives", @"SocketException");
            feature.AddKnownType(@"System.Net.Sockets.AddressFamily,System.Net.Primitives", @"AddressFamily");
            feature.AddKnownType(@"System.Net.Sockets.SocketError,System.Net.Primitives", @"SocketError");
            feature.AddKnownType(@"Interop,System.Net.NameResolution", @"Interop");
            feature.AddKnownType(@"Interop+Winsock,System.Net.NameResolution", @"Winsock");
            feature.AddKnownType(@"Interop+Winsock+WSAData,System.Net.NameResolution", @"WSAData");
            feature.AddKnownType(@"Interop+Winsock+LPLOOKUPSERVICE_COMPLETION_ROUTINE,System.Net.NameResolution", @"LPLOOKUPSERVICE_COMPLETION_ROUTINE");
            feature.AddKnownType(@"Interop+Kernel32,System.Net.NameResolution", @"Kernel32");
            feature.AddKnownType(@"FxResources.System.Net.NameResolution.SR,System.Net.NameResolution", @"FxResources.System.Net.NameResolution.SR");
            feature.AddKnownType(@"Microsoft.Win32.SafeHandles.SafeLibraryHandle,System.Net.NameResolution", @"Microsoft.Win32.SafeHandles.SafeLibraryHandle");
            feature.AddKnownType(@"System.SR,System.Net.NameResolution", @"SR");
            feature.AddKnownType(@"System.Net.Dns,System.Net.NameResolution", @"Dns");
            feature.AddKnownType(@"System.Net.IPHostEntry,System.Net.NameResolution", @"IPHostEntry");
            feature.AddKnownType(@"System.Net.NameResolutionUtilities,System.Net.NameResolution", @"NameResolutionUtilities");
            feature.AddKnownType(@"System.Net.NetEventSource,System.Net.NameResolution", @"NetEventSource");
            feature.AddKnownType(@"System.Net.NetEventSource+Keywords,System.Net.NameResolution", @"NetEventSource.Keywords");
            feature.AddKnownType(@"System.Net.ContextAwareResult,System.Net.NameResolution", @"ContextAwareResult");
            feature.AddKnownType(@"System.Net.LazyAsyncResult,System.Net.NameResolution", @"LazyAsyncResult");
            feature.AddKnownType(@"System.Net.DnsResolveAsyncResult,System.Net.NameResolution", @"DnsResolveAsyncResult");
            feature.AddKnownType(@"System.Net.NameResolutionPal,System.Net.NameResolution", @"NameResolutionPal");
            feature.AddKnownType(@"System.Net.SocketProtocolSupportPal,System.Net.NameResolution", @"SocketProtocolSupportPal");
            feature.AddKnownType(@"System.Net.SocketAddressPal,System.Net.NameResolution", @"SocketAddressPal");
            feature.AddKnownType(@"System.Net.Sockets.AddressInfo,System.Net.NameResolution", @"AddressInfo");
            feature.AddKnownType(@"System.Net.Sockets.AddressInfoHints,System.Net.NameResolution", @"AddressInfoHints");
            feature.AddKnownType(@"System.Net.Sockets.SafeFreeAddrInfo,System.Net.NameResolution", @"SafeFreeAddrInfo");
            feature.AddKnownType(@"System.Net.Sockets.AddressInfoEx,System.Net.NameResolution", @"AddressInfoEx");
            feature.AddKnownType(@"System.Net.Internals.ProtocolType,System.Net.NameResolution", @"ProtocolType");
            feature.AddKnownType(@"System.Net.Internals.SocketType,System.Net.NameResolution", @"SocketType");
            feature.AddKnownType(@"System.Net.Internals.SocketExceptionFactory,System.Net.NameResolution", @"SocketExceptionFactory");
            feature.AddKnownType(@"System.Net.Internals.ProtocolFamily,System.Net.NameResolution", @"ProtocolFamily");
            feature.AddKnownType(@"Orleans.Serialization.ProtobufSerializer,Orleans.Serialization.Protobuf", @"Orleans.Serialization.ProtobufSerializer");
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
