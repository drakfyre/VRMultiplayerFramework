﻿ using System.Runtime.Serialization;
 using UnityEngine;
 
 sealed class Vector3SerializationSurrogate : ISerializationSurrogate
{
     // Method called to serialize a Vector3 object
     public void GetObjectData(object obj,
                               SerializationInfo info, StreamingContext context) {
         
         Vector3 v3 = (Vector3)obj;
         info.AddValue("x", v3.x);
         info.AddValue("y", v3.y);
         info.AddValue("z", v3.z);
         Debug.Log(v3);
     }
     
     // Method called to deserialize a Vector3 object
     public object SetObjectData(object obj,
                                        SerializationInfo info, StreamingContext context,
                                        ISurrogateSelector selector) {
         
         Vector3 v3 = (Vector3)obj;
         v3.x = (float)info.GetValue("x", typeof(float));
         v3.y = (float)info.GetValue("y", typeof(float));
         v3.z = (float)info.GetValue("z", typeof(float));
         obj = v3;
         return obj;   // Formatters ignore this return value //Seems to have been fixed!
     }
 }
