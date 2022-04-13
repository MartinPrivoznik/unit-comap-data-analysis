using System.Xml.Serialization;
using System.Collections.Generic;

namespace UnIT_ComAp.Models.Schemes
{
	
	[XmlRoot(ElementName = "product")]
	public class Product
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "code")]
		public string Code { get; set; }
		[XmlAttribute(AttributeName = "sf-code")]
		public string Sfcode { get; set; }
		[XmlAttribute(AttributeName = "family")]
		public string Family { get; set; }
		[XmlAttribute(AttributeName = "sn")]
		public string Sn { get; set; }
		[XmlAttribute(AttributeName = "sf-sn")]
		public string Sfsn { get; set; }
		[XmlAttribute(AttributeName = "sf-id-string")]
		public string Sfidstring { get; set; }
		[XmlAttribute(AttributeName = "hw-version")]
		public string Hwversion { get; set; }
	}

	[XmlRoot(ElementName = "result")]
	public class Result
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "fail-test-name")]
		public string Failtestname { get; set; }
		[XmlAttribute(AttributeName = "fail-group-name")]
		public string Failgroupname { get; set; }
	}

	[XmlRoot(ElementName = "upload-state")]
	public class Uploadstate
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "test-total-time")]
	public class Testtotaltime
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "security-check")]
	public class Securitycheck
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "tester-info")]
	public class Testerinfo
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "user-name")]
	public class Username
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "dmm-info")]
	public class Dmminfo
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "timestamp")]
	public class Timestamp
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "ini-security")]
	public class Inisecurity
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "version")]
	public class Version
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "version-number")]
		public string Versionnumber { get; set; }
	}

	[XmlRoot(ElementName = "component-versions")]
	public class Componentversions
	{
		[XmlElement(ElementName = "version")]
		public List<Version> Version { get; set; }
	}

	[XmlRoot(ElementName = "head")]
	public class Head
	{
		[XmlElement(ElementName = "product")]
		public Product Product { get; set; }
		[XmlElement(ElementName = "result")]
		public Result Result { get; set; }
		[XmlElement(ElementName = "upload-state")]
		public Uploadstate Uploadstate { get; set; }
		[XmlElement(ElementName = "test-total-time")]
		public Testtotaltime Testtotaltime { get; set; }
		[XmlElement(ElementName = "security-check")]
		public Securitycheck Securitycheck { get; set; }
		[XmlElement(ElementName = "tester-info")]
		public Testerinfo Testerinfo { get; set; }
		[XmlElement(ElementName = "user-name")]
		public Username Username { get; set; }
		[XmlElement(ElementName = "dmm-info")]
		public Dmminfo Dmminfo { get; set; }
		[XmlElement(ElementName = "timestamp")]
		public Timestamp Timestamp { get; set; }
		[XmlElement(ElementName = "ini-security")]
		public Inisecurity Inisecurity { get; set; }
		[XmlElement(ElementName = "component-versions")]
		public Componentversions Componentversions { get; set; }
	}

	[XmlRoot(ElementName = "group")]
	public class Group
	{
		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }
		[XmlAttribute(AttributeName = "group-id")]
		public string Groupid { get; set; }
		[XmlAttribute(AttributeName = "group-sequence-number")]
		public string Groupsequencenumber { get; set; }
		[XmlAttribute(AttributeName = "retest")]
		public string Retest { get; set; }
		[XmlAttribute(AttributeName = "result")]
		public string Result { get; set; }
		[XmlElement(ElementName = "test")]
		public List<Test> Test { get; set; }
	}

	[XmlRoot(ElementName = "value")]
	public class Value
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlText]
		public string Text { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "value")]
		public string _value { get; set; }
		[XmlAttribute(AttributeName = "extended-info")]
		public string Extendedinfo { get; set; }
	}

	[XmlRoot(ElementName = "config")]
	public class Config
	{
		[XmlElement(ElementName = "value")]
		public List<Value> Value { get; set; }
	}

	[XmlRoot(ElementName = "check")]
	public class Check
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "value-type")]
		public string Valuetype { get; set; }
		[XmlAttribute(AttributeName = "expected")]
		public string Expected { get; set; }
		[XmlAttribute(AttributeName = "expected-type")]
		public string Expectedtype { get; set; }
		[XmlAttribute(AttributeName = "expected-low")]
		public string Expectedlow { get; set; }
		[XmlAttribute(AttributeName = "expected-high")]
		public string Expectedhigh { get; set; }
		[XmlAttribute(AttributeName = "extended-info")]
		public string Extendedinfo { get; set; }
		[XmlAttribute(AttributeName = "result")]
		public string Result { get; set; }
		[XmlAttribute(AttributeName = "side")]
		public string Side { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "operations")]
	public class Operations
	{
		[XmlElement(ElementName = "check")]
		public List<Check> Check { get; set; }
		[XmlElement(ElementName = "info")]
		public List<Info> Info { get; set; }
		[XmlElement(ElementName = "value")]
		public List<Value> Value { get; set; }
	}

	[XmlRoot(ElementName = "test")]
	public class Test
	{
		[XmlElement(ElementName = "config")]
		public Config Config { get; set; }
		[XmlElement(ElementName = "operations")]
		public Operations Operations { get; set; }
		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }
		[XmlAttribute(AttributeName = "checked")]
		public string Checked { get; set; }
		[XmlAttribute(AttributeName = "test-class")]
		public string Testclass { get; set; }
		[XmlAttribute(AttributeName = "test-id")]
		public string Testid { get; set; }
		[XmlAttribute(AttributeName = "retest")]
		public string Retest { get; set; }
		[XmlAttribute(AttributeName = "test-sequence-number")]
		public string Testsequencenumber { get; set; }
		[XmlAttribute(AttributeName = "test-group-sequence-number")]
		public string Testgroupsequencenumber { get; set; }
		[XmlAttribute(AttributeName = "result")]
		public string Result { get; set; }
		[XmlElement(ElementName = "error-info")]
		public Errorinfo Errorinfo { get; set; }
	}

	[XmlRoot(ElementName = "info")]
	public class Info
	{
		[XmlAttribute(AttributeName = "text")]
		public string _Text { get; set; }
		[XmlText]
		public string __Text { get; set; }
		[XmlAttribute(AttributeName = "extended-info")]
		public string Extendedinfo { get; set; }
	}

	[XmlRoot(ElementName = "error-info")]
	public class Errorinfo
	{
		[XmlElement(ElementName = "error")]
		public List<string> Error { get; set; }
	}

	[XmlRoot(ElementName = "test_set")]
	public class Test_set
	{
		[XmlElement(ElementName = "group")]
		public List<Group> Group { get; set; }
	}

	[XmlRoot(ElementName = "test_report")]
	public class Test_report
	{
		[XmlElement(ElementName = "head")]
		public Head Head { get; set; }
		[XmlElement(ElementName = "test_set")]
		public Test_set Test_set { get; set; }
		[XmlElement(ElementName = "id_chip_spc")]
		public string Id_chip_spc { get; set; }
		[XmlElement(ElementName = "id_chip_icd")]
		public string Id_chip_icd { get; set; }
		[XmlAttribute(AttributeName = "format-version")]
		public string Formatversion { get; set; }
	}

}
