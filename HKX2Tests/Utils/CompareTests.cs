using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Xml.Linq;

namespace HKX2E.Tests;

[TestClass]
public class CompareTests
{
    public TestContext TestContext { get; set; }

    private string _testRootPath;

    string rawValueLong = @"<hkobject name=""#1786"" class=""hkbStateMachineTransitionInfoArray"" signature=""0xe397b11e"">
      <!--memSizeAndFlags SERIALIZE_IGNORED-->
      <!--referenceCount SERIALIZE_IGNORED-->
      <hkparam name=""transitions"" numelements=""6"">
        <hkobject>
          <hkparam name=""triggerInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""initiateInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""transition"">DefaultBlendTransition</hkparam>
          <hkparam name=""condition"">null</hkparam>
          <hkparam name=""eventId"">809</hkparam>
          <hkparam name=""toStateId"">22</hkparam>
          <hkparam name=""fromNestedStateId"">0</hkparam>
          <hkparam name=""toNestedStateId"">0</hkparam>
          <hkparam name=""priority"">0</hkparam>
          <hkparam name=""flags"">FLAG_TO_NESTED_STATE_ID_IS_VALID|FLAG_IS_LOCAL_WILDCARD|FLAG_DISABLE_CONDITION</hkparam>
        </hkobject>
        <hkobject>
          <hkparam name=""triggerInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""initiateInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""transition"">DefaultBlendResetTransition</hkparam>
          <hkparam name=""condition"">#1787</hkparam>
          <hkparam name=""eventId"">176</hkparam>
          <hkparam name=""toStateId"">23</hkparam>
          <hkparam name=""fromNestedStateId"">0</hkparam>
          <hkparam name=""toNestedStateId"">0</hkparam>
          <hkparam name=""priority"">0</hkparam>
          <hkparam name=""flags"">FLAG_IS_LOCAL_WILDCARD</hkparam>
        </hkobject>
        <hkobject>
          <hkparam name=""triggerInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""initiateInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""transition"">null</hkparam>
          <hkparam name=""condition"">null</hkparam>
          <hkparam name=""eventId"">1009</hkparam>
          <hkparam name=""toStateId"">23</hkparam>
          <hkparam name=""fromNestedStateId"">0</hkparam>
          <hkparam name=""toNestedStateId"">0</hkparam>
          <hkparam name=""priority"">0</hkparam>
          <hkparam name=""flags"">FLAG_IS_LOCAL_WILDCARD|FLAG_DISABLE_CONDITION</hkparam>
        </hkobject>
        <hkobject>
          <hkparam name=""triggerInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""initiateInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""transition"">DefaultBlendTransition</hkparam>
          <hkparam name=""condition"">null</hkparam>
          <hkparam name=""eventId"">1010</hkparam>
          <hkparam name=""toStateId"">22</hkparam>
          <hkparam name=""fromNestedStateId"">0</hkparam>
          <hkparam name=""toNestedStateId"">1</hkparam>
          <hkparam name=""priority"">0</hkparam>
          <hkparam name=""flags"">FLAG_TO_NESTED_STATE_ID_IS_VALID|FLAG_IS_GLOBAL_WILDCARD|FLAG_DISABLE_CONDITION</hkparam>
        </hkobject>
        <hkobject>
          <hkparam name=""triggerInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""initiateInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""transition"">DefaultBlendTransition</hkparam>
          <hkparam name=""condition"">null</hkparam>
          <hkparam name=""eventId"">1172</hkparam>
          <hkparam name=""toStateId"">115</hkparam>
          <hkparam name=""fromNestedStateId"">0</hkparam>
          <hkparam name=""toNestedStateId"">0</hkparam>
          <hkparam name=""priority"">0</hkparam>
          <hkparam name=""flags"">FLAG_IS_LOCAL_WILDCARD|FLAG_IS_GLOBAL_WILDCARD|FLAG_DISABLE_CONDITION</hkparam>
        </hkobject>
        <hkobject>
          <hkparam name=""triggerInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""initiateInterval"">
            <hkobject>
              <hkparam name=""enterEventId"">-1</hkparam>
              <hkparam name=""exitEventId"">-1</hkparam>
              <hkparam name=""enterTime"">0.000000</hkparam>
              <hkparam name=""exitTime"">0.000000</hkparam>
            </hkobject>
          </hkparam>
          <hkparam name=""transition"">DefaultBlendTransition</hkparam>
          <hkparam name=""condition"">null</hkparam>
          <hkparam name=""eventId"">1188</hkparam>
          <hkparam name=""toStateId"">122</hkparam>
          <hkparam name=""fromNestedStateId"">0</hkparam>
          <hkparam name=""toNestedStateId"">0</hkparam>
          <hkparam name=""priority"">0</hkparam>
          <hkparam name=""flags"">FLAG_IS_LOCAL_WILDCARD|FLAG_IS_GLOBAL_WILDCARD|FLAG_DISABLE_CONDITION</hkparam>
        </hkobject>
      </hkparam>
    </hkobject>";

    [TestInitialize]
    public void TestInitialize()
    {
        _testRootPath = Path.Combine(TestContext.DeploymentDirectory, "Assets", "HkxCompareTest");
        Directory.CreateDirectory(_testRootPath);
    }

    [TestMethod]
    public void PartialDeserializeTest()
	{
        var rawValue = "<hkobject name=\"#0051\" class=\"hkbStateMachineStateInfo\" signature=\"0x0ed7f9d0\"><hkparam name=\"variableBindingSet\">null</hkparam><hkparam name=\"listeners\" numelements=\"0\"></hkparam><hkparam name=\"enterNotifyEvents\">null</hkparam><hkparam name=\"exitNotifyEvents\">null</hkparam><hkparam name=\"transitions\">null</hkparam><hkparam name=\"generator\">RootModifierGenerator</hkparam><hkparam name=\"name\">Root</hkparam><hkparam name=\"stateId\">0</hkparam><hkparam name=\"probability\">1.000000</hkparam><hkparam name=\"enable\">true</hkparam></hkobject>";


        XElement element = XElement.Parse(rawValueLong);
        HavokXmlDeserializerOptions options = HavokXmlDeserializerOptions.IgnoreNonFatalErrors | HavokXmlDeserializerOptions.IgnoreMissingPointers;
        HavokXmlPartialDeserializer deserializer = new(options);
        var obj = deserializer.DeserializeRuntimeObject(element);
        RuntimePatcher.SetProperty(obj, "name", "piss");
        HavokXmlPartialSerializer serializer = new();
        XElement outelement = serializer.SerializeObject(obj);
        Debug.WriteLine(outelement.ToString());
    }
    [TestMethod]
    public void TypeTest()
    {
        IHavokObject obj = new hkbClipGenerator(); 
        Debug.WriteLine(obj.GetType());
    }

    [TestMethod]
    public void PipelineBinaryCompareTest()
    {
        var assemblyLocation = TestContext.DeploymentDirectory;
        var sourceFilePath = Path.Combine(assemblyLocation, "Assets", "chickenbehavior.hkx");
        Assert.IsTrue(File.Exists(sourceFilePath), $"Test input file not found at: {sourceFilePath}");

        var tempInputFile = Path.Combine(_testRootPath, "chickenbehavior_original.hkx");
        File.Copy(sourceFilePath, tempInputFile, true);

        var intermediateXmlPath = Path.Combine(_testRootPath, "chickenbehavior_intermediate.xml");
        var finalBinaryPath = Path.Combine(_testRootPath, "chickenbehavior_final.hkx");


        TestContext.WriteLine("Step 1: Deserializing Binary --> Object with reference tracking...");
        var binaryDeserializer = new MetaPackFileReferenceDeserializer();
        IHavokObject objectFromBinary;
        using (var stream = File.OpenRead(tempInputFile))
        {
            objectFromBinary = binaryDeserializer.Deserialize(new BinaryReaderEx(stream), true);
        }
        Assert.IsNotNull(objectFromBinary);
        TestContext.WriteLine("Step 1 complete.");


        TestContext.WriteLine("Step 2: Serializing Object --> XML...");
        var xmlSerializer = new HavokXmlMetaDataSerializer();
        xmlSerializer.ShareContext(binaryDeserializer.Context);
        using (var stream = File.Create(intermediateXmlPath))
        {
            xmlSerializer.Serialize(objectFromBinary, HKXHeader.SkyrimSE(), stream);
        }
        Assert.IsTrue(File.Exists(intermediateXmlPath), "Intermediate XML file was not created.");
        TestContext.WriteLine("Step 2 complete.");


        TestContext.WriteLine("Step 3: Deserializing XML --> Object with reference tracking...");
        var xmlDeserializer = new HavokXmlReferenceDeserializer();
        IHavokObject objectFromXml;
        using (var stream = File.OpenRead(intermediateXmlPath))
        {
            objectFromXml = xmlDeserializer.Deserialize(stream);
        }
        Assert.IsNotNull(objectFromXml);
        TestContext.WriteLine("Step 3 complete.");


        TestContext.WriteLine("Step 4: Serializing Object --> Binary...");
        var binarySerializer = new MetaPackFileSerializer();
        binarySerializer.ShareContext(xmlDeserializer.Context);
        using (var stream = File.Create(finalBinaryPath))
        {
            binarySerializer.Serialize(objectFromXml, new BinaryWriterEx(stream), HKXHeader.SkyrimSE());
        }
        Assert.IsTrue(File.Exists(finalBinaryPath), "Final binary file was not created.");
        TestContext.WriteLine("Step 4 complete.");


        TestContext.WriteLine("Assert: Comparing original and final binary files...");
        var originalBytes = File.ReadAllBytes(tempInputFile);
        var finalBytes = File.ReadAllBytes(finalBinaryPath);

        Assert.AreEqual(originalBytes.Length, finalBytes.Length, "File lengths are different.");
        CollectionAssert.AreEqual(originalBytes, finalBytes, "Binary files are not identical.");
        TestContext.WriteLine("Assert complete: Files are identical.");
    }
}