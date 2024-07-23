using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Xml.Linq;
using FastMember;
using System.Linq.Expressions;
namespace HKX2E.Tests
{
    [TestClass]
    public class CompareTests
    {
        [TestMethod]
        public void PartialDeserializeTest()
		{
            var rawValue = "<hkobject name=\"#0051\" class=\"hkbStateMachineStateInfo\" signature=\"0x0ed7f9d0\"><hkparam name=\"variableBindingSet\">null</hkparam><hkparam name=\"listeners\" numelements=\"0\"></hkparam><hkparam name=\"enterNotifyEvents\">null</hkparam><hkparam name=\"exitNotifyEvents\">null</hkparam><hkparam name=\"transitions\">null</hkparam><hkparam name=\"generator\">RootModifierGenerator</hkparam><hkparam name=\"name\">Root</hkparam><hkparam name=\"stateId\">0</hkparam><hkparam name=\"probability\">1.000000</hkparam><hkparam name=\"enable\">true</hkparam></hkobject>"; 
            XElement element = XElement.Parse(rawValue);
            HavokXmlDeserializerOptions options = HavokXmlDeserializerOptions.IgnoreNonFatalErrors | HavokXmlDeserializerOptions.IgnoreMissingPointers;
            HavokXmlPartialDeserializer deserializer = new(options);
            var obj = deserializer.DeserializeRuntimeObject(element);
            RuntimePatcher.SetValue(obj, "name", "piss");
            HavokXmlPartialSerializer serializer = new();
            XElement outelement = serializer.SerializeObject(obj);

			Debug.WriteLine(outelement.ToString());
        }
    }
}