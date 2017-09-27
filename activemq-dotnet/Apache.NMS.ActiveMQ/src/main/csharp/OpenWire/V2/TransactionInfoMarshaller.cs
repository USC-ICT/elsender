/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/*
 *
 *  Marshaler code for OpenWire format for TransactionInfo
 *
 *  NOTE!: This file is auto generated - do not modify!
 *         if you need to make a change, please see the Java Classes
 *         in the nms-activemq-openwire-generator module
 *
 */

using System;
using System.IO;

using Apache.NMS.ActiveMQ.Commands;

namespace Apache.NMS.ActiveMQ.OpenWire.V2
{
    /// <summary>
    ///  Marshalling code for Open Wire Format for TransactionInfo
    /// </summary>
    class TransactionInfoMarshaller : BaseCommandMarshaller
    {
        /// <summery>
        ///  Creates an instance of the Object that this marshaller handles.
        /// </summery>
        public override DataStructure CreateObject() 
        {
            return new TransactionInfo();
        }

        /// <summery>
        ///  Returns the type code for the Object that this Marshaller handles..
        /// </summery>
        public override byte GetDataStructureType() 
        {
            return TransactionInfo.ID_TRANSACTIONINFO;
        }

        // 
        // Un-marshal an object instance from the data input stream
        // 
        public override void TightUnmarshal(OpenWireFormat wireFormat, Object o, BinaryReader dataIn, BooleanStream bs) 
        {
            base.TightUnmarshal(wireFormat, o, dataIn, bs);

            TransactionInfo info = (TransactionInfo)o;
            info.ConnectionId = (ConnectionId) TightUnmarshalCachedObject(wireFormat, dataIn, bs);
            info.TransactionId = (TransactionId) TightUnmarshalCachedObject(wireFormat, dataIn, bs);
            info.Type = dataIn.ReadByte();
        }

        //
        // Write the booleans that this object uses to a BooleanStream
        //
        public override int TightMarshal1(OpenWireFormat wireFormat, Object o, BooleanStream bs)
        {
            TransactionInfo info = (TransactionInfo)o;

            int rc = base.TightMarshal1(wireFormat, o, bs);
            rc += TightMarshalCachedObject1(wireFormat, (DataStructure)info.ConnectionId, bs);
            rc += TightMarshalCachedObject1(wireFormat, (DataStructure)info.TransactionId, bs);

            return rc + 1;
        }

        // 
        // Write a object instance to data output stream
        //
        public override void TightMarshal2(OpenWireFormat wireFormat, Object o, BinaryWriter dataOut, BooleanStream bs)
        {
            base.TightMarshal2(wireFormat, o, dataOut, bs);

            TransactionInfo info = (TransactionInfo)o;
            TightMarshalCachedObject2(wireFormat, (DataStructure)info.ConnectionId, dataOut, bs);
            TightMarshalCachedObject2(wireFormat, (DataStructure)info.TransactionId, dataOut, bs);
            dataOut.Write(info.Type);
        }

        // 
        // Un-marshal an object instance from the data input stream
        // 
        public override void LooseUnmarshal(OpenWireFormat wireFormat, Object o, BinaryReader dataIn) 
        {
            base.LooseUnmarshal(wireFormat, o, dataIn);

            TransactionInfo info = (TransactionInfo)o;
            info.ConnectionId = (ConnectionId) LooseUnmarshalCachedObject(wireFormat, dataIn);
            info.TransactionId = (TransactionId) LooseUnmarshalCachedObject(wireFormat, dataIn);
            info.Type = dataIn.ReadByte();
        }

        // 
        // Write a object instance to data output stream
        //
        public override void LooseMarshal(OpenWireFormat wireFormat, Object o, BinaryWriter dataOut)
        {

            TransactionInfo info = (TransactionInfo)o;

            base.LooseMarshal(wireFormat, o, dataOut);
            LooseMarshalCachedObject(wireFormat, (DataStructure)info.ConnectionId, dataOut);
            LooseMarshalCachedObject(wireFormat, (DataStructure)info.TransactionId, dataOut);
            dataOut.Write(info.Type);
        }
    }
}
