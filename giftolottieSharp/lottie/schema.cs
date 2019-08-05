﻿//// <auto-generated />
////
//// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
////
////    using QuickType;
////
////    var welcome = Welcome.FromJson(jsonString);

//namespace giftolottieSharp.Schema
//{
//    using System;
//    using System.Collections.Generic;

//    using System.Globalization;
//    using Newtonsoft.Json;
//    using Newtonsoft.Json.Converters;

//    public partial class Welcome
//    {
//        [JsonProperty("tgs")]
//        public long Tgs { get; set; }

//        [JsonProperty("v")]
//        public string V { get; set; }

//        [JsonProperty("fr")]
//        public long Fr { get; set; }

//        [JsonProperty("ip")]
//        public long Ip { get; set; }

//        [JsonProperty("op")]
//        public long Op { get; set; }

//        [JsonProperty("w")]
//        public long W { get; set; }

//        [JsonProperty("h")]
//        public long H { get; set; }

//        [JsonProperty("nm")]
//        public string Nm { get; set; }

//        [JsonProperty("ddd")]
//        public long Ddd { get; set; }

//        [JsonProperty("assets")]
//        public object[] Assets { get; set; }

//        [JsonProperty("layers")]
//        public Layer[] Layers { get; set; }
//    }

//    public partial class Layer
//    {
//        [JsonProperty("ddd")]
//        public long Ddd { get; set; }

//        [JsonProperty("ind")]
//        public long Ind { get; set; }

//        [JsonProperty("ty")]
//        public long Type { get; set; }

//        [JsonProperty("nm")]
//        public string Nm { get; set; }

//        [JsonProperty("sr")]
//        public long Sr { get; set; }

//        [JsonProperty("ks")]
//        public LayerKs Ks { get; set; }

//        [JsonProperty("ao")]
//        public long Ao { get; set; }

//        [JsonProperty("shapes")]
//        public Shape[] Shapes { get; set; }

//        [JsonProperty("ip")]
//        public long Ip { get; set; }

//        [JsonProperty("op")]
//        public long Op { get; set; }

//        [JsonProperty("st")]
//        public long St { get; set; }

//        [JsonProperty("bm")]
//        public long Bm { get; set; }
//    }

//    public partial class LayerKs
//    {
//        [JsonProperty("o")]
//        public O O { get; set; }

//        [JsonProperty("r")]
//        public O R { get; set; }

//        [JsonProperty("p")]
//        public A P { get; set; }

//        [JsonProperty("a")]
//        public A A { get; set; }

//        [JsonProperty("s")]
//        public A S { get; set; }
//    }

//    public partial class A
//    {
//        [JsonProperty("a")]
//        public long AA { get; set; }

//        [JsonProperty("k")]
//        public double[] K { get; set; }
//    }

//    public partial class O
//    {
//        [JsonProperty("a")]
//        public long A { get; set; }

//        [JsonProperty("k")]
//        public long K { get; set; }
//    }

//    public partial class Shape
//    {
//        [JsonProperty("ty")]
//        public ShapeTy Ty { get; set; }

//        [JsonProperty("it")]
//        public It[] It { get; set; }

//        [JsonProperty("nm")]
//        public string Nm { get; set; }

//        [JsonProperty("bm")]
//        public long Bm { get; set; }

//        [JsonProperty("hd")]
//        public bool Hd { get; set; }
//    }

//    public partial class It
//    {
//        [JsonProperty("ind", NullValueHandling = NullValueHandling.Ignore)]
//        public long? Ind { get; set; }

//        [JsonProperty("ty")]
//        public ItTy Ty { get; set; }

//        [JsonProperty("ks", NullValueHandling = NullValueHandling.Ignore)]
//        public ItKs Ks { get; set; }

//        [JsonProperty("nm")]
//        public Nm Nm { get; set; }

//        [JsonProperty("hd", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? Hd { get; set; }

//        [JsonProperty("c", NullValueHandling = NullValueHandling.Ignore)]
//        public A C { get; set; }

//        [JsonProperty("o", NullValueHandling = NullValueHandling.Ignore)]
//        public O O { get; set; }

//        [JsonProperty("r", NullValueHandling = NullValueHandling.Ignore)]
//        public R? R { get; set; }

//        [JsonProperty("bm", NullValueHandling = NullValueHandling.Ignore)]
//        public long? Bm { get; set; }

//        [JsonProperty("p", NullValueHandling = NullValueHandling.Ignore)]
//        public A P { get; set; }

//        [JsonProperty("a", NullValueHandling = NullValueHandling.Ignore)]
//        public A A { get; set; }

//        [JsonProperty("s", NullValueHandling = NullValueHandling.Ignore)]
//        public A S { get; set; }

//        [JsonProperty("sk", NullValueHandling = NullValueHandling.Ignore)]
//        public O Sk { get; set; }

//        [JsonProperty("sa", NullValueHandling = NullValueHandling.Ignore)]
//        public O Sa { get; set; }

//        [JsonProperty("mm", NullValueHandling = NullValueHandling.Ignore)]
//        public long? Mm { get; set; }
//    }

//    public partial class ItKs
//    {
//        [JsonProperty("a")]
//        public long A { get; set; }

//        [JsonProperty("k")]
//        public K K { get; set; }
//    }

//    public partial class K
//    {
//        [JsonProperty("i")]
//        public double[][] I { get; set; }

//        [JsonProperty("o")]
//        public double[][] O { get; set; }

//        [JsonProperty("v")]
//        public double[][] V { get; set; }

//        [JsonProperty("c")]
//        public bool C { get; set; }
//    }

//    public enum Nm { Fill1, MergePaths1, Path1, Path2, Path3, Path4, Path5, Path6, Path7, Path8, Transform };

//    public enum ItTy { Fl, Mm, Sh, Tr };

//    public enum ShapeTy { Gr };

//    public partial struct R
//    {
//        public long? Integer;
//        public O O;

//        public static implicit operator R(long Integer) => new R { Integer = Integer };
//        public static implicit operator R(O O) => new R { O = O };
//    }

//    public partial class Welcome
//    {
//        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, Schema.Converter.Settings);
//    }

//    public static class Serialize
//    {
//        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, Schema.Converter.Settings);
//    }

//    internal static class Converter
//    {
//        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//        {
//            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//            DateParseHandling = DateParseHandling.None,
//            Converters =
//            {
//                NmConverter.Singleton,
//                RConverter.Singleton,
//                ItTyConverter.Singleton,
//                ShapeTyConverter.Singleton,
//                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//            },
//        };
//    }

//    internal class NmConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Nm) || t == typeof(Nm?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "Fill 1":
//                    return Nm.Fill1;
//                case "Merge Paths 1":
//                    return Nm.MergePaths1;
//                case "Path 1":
//                    return Nm.Path1;
//                case "Path 2":
//                    return Nm.Path2;
//                case "Path 3":
//                    return Nm.Path3;
//                case "Path 4":
//                    return Nm.Path4;
//                case "Path 5":
//                    return Nm.Path5;
//                case "Path 6":
//                    return Nm.Path6;
//                case "Path 7":
//                    return Nm.Path7;
//                case "Path 8":
//                    return Nm.Path8;
//                case "Transform":
//                    return Nm.Transform;
//            }
//            throw new Exception("Cannot unmarshal type Nm");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (Nm)untypedValue;
//            switch (value)
//            {
//                case Nm.Fill1:
//                    serializer.Serialize(writer, "Fill 1");
//                    return;
//                case Nm.MergePaths1:
//                    serializer.Serialize(writer, "Merge Paths 1");
//                    return;
//                case Nm.Path1:
//                    serializer.Serialize(writer, "Path 1");
//                    return;
//                case Nm.Path2:
//                    serializer.Serialize(writer, "Path 2");
//                    return;
//                case Nm.Path3:
//                    serializer.Serialize(writer, "Path 3");
//                    return;
//                case Nm.Path4:
//                    serializer.Serialize(writer, "Path 4");
//                    return;
//                case Nm.Path5:
//                    serializer.Serialize(writer, "Path 5");
//                    return;
//                case Nm.Path6:
//                    serializer.Serialize(writer, "Path 6");
//                    return;
//                case Nm.Path7:
//                    serializer.Serialize(writer, "Path 7");
//                    return;
//                case Nm.Path8:
//                    serializer.Serialize(writer, "Path 8");
//                    return;
//                case Nm.Transform:
//                    serializer.Serialize(writer, "Transform");
//                    return;
//            }
//            throw new Exception("Cannot marshal type Nm");
//        }

//        public static readonly NmConverter Singleton = new NmConverter();
//    }

//    internal class RConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(R) || t == typeof(R?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            switch (reader.TokenType)
//            {
//                case JsonToken.Integer:
//                    var integerValue = serializer.Deserialize<long>(reader);
//                    return new R { Integer = integerValue };
//                case JsonToken.StartObject:
//                    var objectValue = serializer.Deserialize<O>(reader);
//                    return new R { O = objectValue };
//            }
//            throw new Exception("Cannot unmarshal type R");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            var value = (R)untypedValue;
//            if (value.Integer != null)
//            {
//                serializer.Serialize(writer, value.Integer.Value);
//                return;
//            }
//            if (value.O != null)
//            {
//                serializer.Serialize(writer, value.O);
//                return;
//            }
//            throw new Exception("Cannot marshal type R");
//        }

//        public static readonly RConverter Singleton = new RConverter();
//    }

//    internal class ItTyConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(ItTy) || t == typeof(ItTy?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "fl":
//                    return ItTy.Fl;
//                case "mm":
//                    return ItTy.Mm;
//                case "sh":
//                    return ItTy.Sh;
//                case "tr":
//                    return ItTy.Tr;
//            }
//            throw new Exception("Cannot unmarshal type ItTy");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (ItTy)untypedValue;
//            switch (value)
//            {
//                case ItTy.Fl:
//                    serializer.Serialize(writer, "fl");
//                    return;
//                case ItTy.Mm:
//                    serializer.Serialize(writer, "mm");
//                    return;
//                case ItTy.Sh:
//                    serializer.Serialize(writer, "sh");
//                    return;
//                case ItTy.Tr:
//                    serializer.Serialize(writer, "tr");
//                    return;
//            }
//            throw new Exception("Cannot marshal type ItTy");
//        }

//        public static readonly ItTyConverter Singleton = new ItTyConverter();
//    }

//    internal class ShapeTyConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(ShapeTy) || t == typeof(ShapeTy?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "gr")
//            {
//                return ShapeTy.Gr;
//            }
//            throw new Exception("Cannot unmarshal type ShapeTy");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (ShapeTy)untypedValue;
//            if (value == ShapeTy.Gr)
//            {
//                serializer.Serialize(writer, "gr");
//                return;
//            }
//            throw new Exception("Cannot marshal type ShapeTy");
//        }

//        public static readonly ShapeTyConverter Singleton = new ShapeTyConverter();
//    }
//}
