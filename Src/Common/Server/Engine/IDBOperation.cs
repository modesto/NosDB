﻿// /*
// * Copyright (c) 2016, Alachisoft. All Rights Reserved.
// *
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// *
// * http://www.apache.org/licenses/LICENSE-2.0
// *
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// */
using System;
using Alachisoft.NosDB.Common.Communication;
using Alachisoft.NosDB.Common.JSON.CustomConverter;
using Alachisoft.NosDB.Common.Security.Interfaces;
using Alachisoft.NosDB.Common.Server.Engine.Impl;
using Newtonsoft.Json;

namespace Alachisoft.NosDB.Common.Server.Engine
{
    [JsonConverter(typeof(LogOperationConverter))]
    public interface IDBOperation : IRequest
    {
        //long RequestId { get; set; }
        string Database { get; set; }
        string Collection { get; set; }
        IOperationContext Context { get; set; }
        byte[] Serialize();
        DatabaseOperationType OperationType { get; set; }
        IDBOperation Clone();
        IDBResponse CreateResponse();

        /// <summary>
        /// used to identify which client is performing an operatoin on database engine
        /// </summary>
        ISessionId SessionId { set; get; } 
    }
}