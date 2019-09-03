using System;
using System.Runtime.Serialization;
namespace ShapeApi.Json
{
    [DataContract]
    internal class JsonShape
    {
        [DataMember]
        internal string shape;

        [DataMember]
        internal uint area;

        [DataMember]
        internal uint side1;

        [DataMember]
        internal uint side2;

        [DataMember]
        internal string result;
    }
}
