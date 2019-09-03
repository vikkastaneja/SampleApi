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
        internal int area;

        [DataMember]
        internal int side1;

        [DataMember]
        internal int side2;

        [DataMember]
        internal string result;
    }
}
