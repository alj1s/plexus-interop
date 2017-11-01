/**
 * Copyright 2017 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
import { ClientConnectionFactory } from "../../src/transport/ClientConnectionFactory";
import { ServerConnectionFactory } from "../../src/transport/ServerConnectionFactory";
import { TransportConnection } from "../../src/transport/TransportConnection";
import { Frame } from "../../src/transport/frame/model/Frame";
import { TestBufferedInMemoryFramedTransport } from "./TestBufferedInMemoryFramedTransport";;
import { UniqueId } from "../../src/transport/UniqueId";
import { FramedTransportConnection } from "../../src/transport/frame/FramedTransportConnection";
import { Queue } from "typescript-collections";
import { LoggerFactory } from "@plexus-interop/common";

export class InMemoryConnectionFactory implements ClientConnectionFactory, ServerConnectionFactory {

    constructor(
        public readonly clientInBuffer: Queue<Frame> = new Queue<Frame>(),
        public readonly serverInBuffer: Queue<Frame> = new Queue<Frame>()) { }

    public async connect(): Promise<TransportConnection> {
        const connection = new FramedTransportConnection(
            new TestBufferedInMemoryFramedTransport(UniqueId.generateNew(), this.clientInBuffer, this.serverInBuffer, 8, LoggerFactory.getLogger("ClientTransport")));
        return connection.open().then(() => connection);
    }

    public async acceptConnection(): Promise<TransportConnection> {
        const connection = new FramedTransportConnection(new TestBufferedInMemoryFramedTransport(UniqueId.generateNew(), this.serverInBuffer, this.clientInBuffer, 8, LoggerFactory.getLogger("ServerTransport")));
        return connection.acceptingConnection().then(() => connection);
    }

}