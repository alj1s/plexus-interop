/**
 * Copyright 2017-2018 Plexus Interop Deutsche Bank AG
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
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: interop/app_lifecycle_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Plexus.Interop.Apps.Internal.Generated {

  /// <summary>Holder for reflection information generated from interop/app_lifecycle_service.proto</summary>
  internal static partial class AppLifecycleServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for interop/app_lifecycle_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppLifecycleServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNpbnRlcm9wL2FwcF9saWZlY3ljbGVfc2VydmljZS5wcm90bxIHaW50ZXJv",
            "cBoXaW50ZXJvcC91bmlxdWVfaWQucHJvdG8aHWludGVyb3AvYXBwX2xhdW5j",
            "aF9tb2RlLnByb3RvGidpbnRlcm9wL2FwcF9jb25uZWN0aW9uX2Rlc2NyaXB0",
            "b3IucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90bxoVaW50ZXJv",
            "cC9vcHRpb25zLnByb3RvInQKEVJlc29sdmVBcHBSZXF1ZXN0Eg4KBmFwcF9p",
            "ZBgBIAEoCRIwChBhcHBfcmVzb2x2ZV9tb2RlGAIgASgOMhYuaW50ZXJvcC5B",
            "cHBMYXVuY2hNb2RlOh2S2wQZaW50ZXJvcC5SZXNvbHZlQXBwUmVxdWVzdCKw",
            "AQoSUmVzb2x2ZUFwcFJlc3BvbnNlEioKD2FwcF9pbnN0YW5jZV9pZBgBIAEo",
            "CzIRLmludGVyb3AuVW5pcXVlSWQSLAoRYXBwX2Nvbm5lY3Rpb25faWQYAiAB",
            "KAsyES5pbnRlcm9wLlVuaXF1ZUlkEiAKGGlzX25ld19pbnN0YW5jZV9sYXVu",
            "Y2hlZBgDIAEoCDoektsEGmludGVyb3AuUmVzb2x2ZUFwcFJlc3BvbnNlIqMB",
            "ChFBcHBMaWZlY3ljbGVFdmVudBIvCgljb25uZWN0ZWQYASABKAsyGi5pbnRl",
            "cm9wLkFwcENvbm5lY3RlZEV2ZW50SAASNQoMZGlzY29ubmVjdGVkGAIgASgL",
            "Mh0uaW50ZXJvcC5BcHBEaXNjb25uZWN0ZWRFdmVudEgAOh2S2wQZaW50ZXJv",
            "cC5BcHBMaWZlY3ljbGVFdmVudEIHCgVldmVudCJzChFBcHBDb25uZWN0ZWRF",
            "dmVudBI/ChVjb25uZWN0aW9uX2Rlc2NyaXB0b3IYASABKAsyIC5pbnRlcm9w",
            "LkFwcENvbm5lY3Rpb25EZXNjcmlwdG9yOh2S2wQZaW50ZXJvcC5BcHBDb25u",
            "ZWN0ZWRFdmVudCJ5ChRBcHBEaXNjb25uZWN0ZWRFdmVudBI/ChVjb25uZWN0",
            "aW9uX2Rlc2NyaXB0b3IYASABKAsyIC5pbnRlcm9wLkFwcENvbm5lY3Rpb25E",
            "ZXNjcmlwdG9yOiCS2wQcaW50ZXJvcC5BcHBEaXNjb25uZWN0ZWRFdmVudDLO",
            "AQoTQXBwTGlmZWN5Y2xlU2VydmljZRJFCgpSZXNvbHZlQXBwEhouaW50ZXJv",
            "cC5SZXNvbHZlQXBwUmVxdWVzdBobLmludGVyb3AuUmVzb2x2ZUFwcFJlc3Bv",
            "bnNlEk8KF0dldExpZmVjeWNsZUV2ZW50U3RyZWFtEhYuZ29vZ2xlLnByb3Rv",
            "YnVmLkVtcHR5GhouaW50ZXJvcC5BcHBMaWZlY3ljbGVFdmVudDABGh+S2wQb",
            "aW50ZXJvcC5BcHBMaWZlY3ljbGVTZXJ2aWNlQimqAiZQbGV4dXMuSW50ZXJv",
            "cC5BcHBzLkludGVybmFsLkdlbmVyYXRlZGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Plexus.Interop.Apps.Internal.Generated.UniqueIdReflection.Descriptor, global::Plexus.Interop.Apps.Internal.Generated.AppLaunchModeReflection.Descriptor, global::Plexus.Interop.Apps.Internal.Generated.AppConnectionDescriptorReflection.Descriptor, global::Plexus.Interop.Apps.Internal.Generated.EmptyReflection.Descriptor, global::Plexus.Interop.Apps.Internal.Generated.OptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.ResolveAppRequest), global::Plexus.Interop.Apps.Internal.Generated.ResolveAppRequest.Parser, new[]{ "AppId", "AppResolveMode" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.ResolveAppResponse), global::Plexus.Interop.Apps.Internal.Generated.ResolveAppResponse.Parser, new[]{ "AppInstanceId", "AppConnectionId", "IsNewInstanceLaunched" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleEvent), global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleEvent.Parser, new[]{ "Connected", "Disconnected" }, new[]{ "Event" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.AppConnectedEvent), global::Plexus.Interop.Apps.Internal.Generated.AppConnectedEvent.Parser, new[]{ "ConnectionDescriptor" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.AppDisconnectedEvent), global::Plexus.Interop.Apps.Internal.Generated.AppDisconnectedEvent.Parser, new[]{ "ConnectionDescriptor" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ResolveAppRequest : pb::IMessage<ResolveAppRequest> {
    private static readonly pb::MessageParser<ResolveAppRequest> _parser = new pb::MessageParser<ResolveAppRequest>(() => new ResolveAppRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResolveAppRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppRequest(ResolveAppRequest other) : this() {
      appId_ = other.appId_;
      appResolveMode_ = other.appResolveMode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppRequest Clone() {
      return new ResolveAppRequest(this);
    }

    /// <summary>Field number for the "app_id" field.</summary>
    public const int AppIdFieldNumber = 1;
    private string appId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppId {
      get { return appId_; }
      set {
        appId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "app_resolve_mode" field.</summary>
    public const int AppResolveModeFieldNumber = 2;
    private global::Plexus.Interop.Apps.Internal.Generated.AppLaunchMode appResolveMode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.AppLaunchMode AppResolveMode {
      get { return appResolveMode_; }
      set {
        appResolveMode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResolveAppRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResolveAppRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AppId != other.AppId) return false;
      if (AppResolveMode != other.AppResolveMode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AppId.Length != 0) hash ^= AppId.GetHashCode();
      if (AppResolveMode != 0) hash ^= AppResolveMode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AppId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AppId);
      }
      if (AppResolveMode != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) AppResolveMode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AppId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppId);
      }
      if (AppResolveMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AppResolveMode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResolveAppRequest other) {
      if (other == null) {
        return;
      }
      if (other.AppId.Length != 0) {
        AppId = other.AppId;
      }
      if (other.AppResolveMode != 0) {
        AppResolveMode = other.AppResolveMode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AppId = input.ReadString();
            break;
          }
          case 16: {
            appResolveMode_ = (global::Plexus.Interop.Apps.Internal.Generated.AppLaunchMode) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ResolveAppResponse : pb::IMessage<ResolveAppResponse> {
    private static readonly pb::MessageParser<ResolveAppResponse> _parser = new pb::MessageParser<ResolveAppResponse>(() => new ResolveAppResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResolveAppResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppResponse(ResolveAppResponse other) : this() {
      AppInstanceId = other.appInstanceId_ != null ? other.AppInstanceId.Clone() : null;
      AppConnectionId = other.appConnectionId_ != null ? other.AppConnectionId.Clone() : null;
      isNewInstanceLaunched_ = other.isNewInstanceLaunched_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppResponse Clone() {
      return new ResolveAppResponse(this);
    }

    /// <summary>Field number for the "app_instance_id" field.</summary>
    public const int AppInstanceIdFieldNumber = 1;
    private global::Plexus.Interop.Apps.Internal.Generated.UniqueId appInstanceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.UniqueId AppInstanceId {
      get { return appInstanceId_; }
      set {
        appInstanceId_ = value;
      }
    }

    /// <summary>Field number for the "app_connection_id" field.</summary>
    public const int AppConnectionIdFieldNumber = 2;
    private global::Plexus.Interop.Apps.Internal.Generated.UniqueId appConnectionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.UniqueId AppConnectionId {
      get { return appConnectionId_; }
      set {
        appConnectionId_ = value;
      }
    }

    /// <summary>Field number for the "is_new_instance_launched" field.</summary>
    public const int IsNewInstanceLaunchedFieldNumber = 3;
    private bool isNewInstanceLaunched_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsNewInstanceLaunched {
      get { return isNewInstanceLaunched_; }
      set {
        isNewInstanceLaunched_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResolveAppResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResolveAppResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AppInstanceId, other.AppInstanceId)) return false;
      if (!object.Equals(AppConnectionId, other.AppConnectionId)) return false;
      if (IsNewInstanceLaunched != other.IsNewInstanceLaunched) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (appInstanceId_ != null) hash ^= AppInstanceId.GetHashCode();
      if (appConnectionId_ != null) hash ^= AppConnectionId.GetHashCode();
      if (IsNewInstanceLaunched != false) hash ^= IsNewInstanceLaunched.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (appInstanceId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AppInstanceId);
      }
      if (appConnectionId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AppConnectionId);
      }
      if (IsNewInstanceLaunched != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsNewInstanceLaunched);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (appInstanceId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppInstanceId);
      }
      if (appConnectionId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppConnectionId);
      }
      if (IsNewInstanceLaunched != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResolveAppResponse other) {
      if (other == null) {
        return;
      }
      if (other.appInstanceId_ != null) {
        if (appInstanceId_ == null) {
          appInstanceId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
        }
        AppInstanceId.MergeFrom(other.AppInstanceId);
      }
      if (other.appConnectionId_ != null) {
        if (appConnectionId_ == null) {
          appConnectionId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
        }
        AppConnectionId.MergeFrom(other.AppConnectionId);
      }
      if (other.IsNewInstanceLaunched != false) {
        IsNewInstanceLaunched = other.IsNewInstanceLaunched;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (appInstanceId_ == null) {
              appInstanceId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
            }
            input.ReadMessage(appInstanceId_);
            break;
          }
          case 18: {
            if (appConnectionId_ == null) {
              appConnectionId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
            }
            input.ReadMessage(appConnectionId_);
            break;
          }
          case 24: {
            IsNewInstanceLaunched = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class AppLifecycleEvent : pb::IMessage<AppLifecycleEvent> {
    private static readonly pb::MessageParser<AppLifecycleEvent> _parser = new pb::MessageParser<AppLifecycleEvent>(() => new AppLifecycleEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppLifecycleEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppLifecycleEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppLifecycleEvent(AppLifecycleEvent other) : this() {
      switch (other.EventCase) {
        case EventOneofCase.Connected:
          Connected = other.Connected.Clone();
          break;
        case EventOneofCase.Disconnected:
          Disconnected = other.Disconnected.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppLifecycleEvent Clone() {
      return new AppLifecycleEvent(this);
    }

    /// <summary>Field number for the "connected" field.</summary>
    public const int ConnectedFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.AppConnectedEvent Connected {
      get { return eventCase_ == EventOneofCase.Connected ? (global::Plexus.Interop.Apps.Internal.Generated.AppConnectedEvent) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.Connected;
      }
    }

    /// <summary>Field number for the "disconnected" field.</summary>
    public const int DisconnectedFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.AppDisconnectedEvent Disconnected {
      get { return eventCase_ == EventOneofCase.Disconnected ? (global::Plexus.Interop.Apps.Internal.Generated.AppDisconnectedEvent) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.Disconnected;
      }
    }

    private object event_;
    /// <summary>Enum of possible cases for the "event" oneof.</summary>
    public enum EventOneofCase {
      None = 0,
      Connected = 1,
      Disconnected = 2,
    }
    private EventOneofCase eventCase_ = EventOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventOneofCase EventCase {
      get { return eventCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearEvent() {
      eventCase_ = EventOneofCase.None;
      event_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppLifecycleEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppLifecycleEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Connected, other.Connected)) return false;
      if (!object.Equals(Disconnected, other.Disconnected)) return false;
      if (EventCase != other.EventCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (eventCase_ == EventOneofCase.Connected) hash ^= Connected.GetHashCode();
      if (eventCase_ == EventOneofCase.Disconnected) hash ^= Disconnected.GetHashCode();
      hash ^= (int) eventCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (eventCase_ == EventOneofCase.Connected) {
        output.WriteRawTag(10);
        output.WriteMessage(Connected);
      }
      if (eventCase_ == EventOneofCase.Disconnected) {
        output.WriteRawTag(18);
        output.WriteMessage(Disconnected);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (eventCase_ == EventOneofCase.Connected) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Connected);
      }
      if (eventCase_ == EventOneofCase.Disconnected) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Disconnected);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppLifecycleEvent other) {
      if (other == null) {
        return;
      }
      switch (other.EventCase) {
        case EventOneofCase.Connected:
          if (Connected == null) {
            Connected = new global::Plexus.Interop.Apps.Internal.Generated.AppConnectedEvent();
          }
          Connected.MergeFrom(other.Connected);
          break;
        case EventOneofCase.Disconnected:
          if (Disconnected == null) {
            Disconnected = new global::Plexus.Interop.Apps.Internal.Generated.AppDisconnectedEvent();
          }
          Disconnected.MergeFrom(other.Disconnected);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            global::Plexus.Interop.Apps.Internal.Generated.AppConnectedEvent subBuilder = new global::Plexus.Interop.Apps.Internal.Generated.AppConnectedEvent();
            if (eventCase_ == EventOneofCase.Connected) {
              subBuilder.MergeFrom(Connected);
            }
            input.ReadMessage(subBuilder);
            Connected = subBuilder;
            break;
          }
          case 18: {
            global::Plexus.Interop.Apps.Internal.Generated.AppDisconnectedEvent subBuilder = new global::Plexus.Interop.Apps.Internal.Generated.AppDisconnectedEvent();
            if (eventCase_ == EventOneofCase.Disconnected) {
              subBuilder.MergeFrom(Disconnected);
            }
            input.ReadMessage(subBuilder);
            Disconnected = subBuilder;
            break;
          }
        }
      }
    }

  }

  internal sealed partial class AppConnectedEvent : pb::IMessage<AppConnectedEvent> {
    private static readonly pb::MessageParser<AppConnectedEvent> _parser = new pb::MessageParser<AppConnectedEvent>(() => new AppConnectedEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppConnectedEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppConnectedEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppConnectedEvent(AppConnectedEvent other) : this() {
      ConnectionDescriptor = other.connectionDescriptor_ != null ? other.ConnectionDescriptor.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppConnectedEvent Clone() {
      return new AppConnectedEvent(this);
    }

    /// <summary>Field number for the "connection_descriptor" field.</summary>
    public const int ConnectionDescriptorFieldNumber = 1;
    private global::Plexus.Interop.Apps.Internal.Generated.AppConnectionDescriptor connectionDescriptor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.AppConnectionDescriptor ConnectionDescriptor {
      get { return connectionDescriptor_; }
      set {
        connectionDescriptor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppConnectedEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppConnectedEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ConnectionDescriptor, other.ConnectionDescriptor)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (connectionDescriptor_ != null) hash ^= ConnectionDescriptor.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (connectionDescriptor_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ConnectionDescriptor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (connectionDescriptor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConnectionDescriptor);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppConnectedEvent other) {
      if (other == null) {
        return;
      }
      if (other.connectionDescriptor_ != null) {
        if (connectionDescriptor_ == null) {
          connectionDescriptor_ = new global::Plexus.Interop.Apps.Internal.Generated.AppConnectionDescriptor();
        }
        ConnectionDescriptor.MergeFrom(other.ConnectionDescriptor);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (connectionDescriptor_ == null) {
              connectionDescriptor_ = new global::Plexus.Interop.Apps.Internal.Generated.AppConnectionDescriptor();
            }
            input.ReadMessage(connectionDescriptor_);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class AppDisconnectedEvent : pb::IMessage<AppDisconnectedEvent> {
    private static readonly pb::MessageParser<AppDisconnectedEvent> _parser = new pb::MessageParser<AppDisconnectedEvent>(() => new AppDisconnectedEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppDisconnectedEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppDisconnectedEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppDisconnectedEvent(AppDisconnectedEvent other) : this() {
      ConnectionDescriptor = other.connectionDescriptor_ != null ? other.ConnectionDescriptor.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppDisconnectedEvent Clone() {
      return new AppDisconnectedEvent(this);
    }

    /// <summary>Field number for the "connection_descriptor" field.</summary>
    public const int ConnectionDescriptorFieldNumber = 1;
    private global::Plexus.Interop.Apps.Internal.Generated.AppConnectionDescriptor connectionDescriptor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.AppConnectionDescriptor ConnectionDescriptor {
      get { return connectionDescriptor_; }
      set {
        connectionDescriptor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppDisconnectedEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppDisconnectedEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ConnectionDescriptor, other.ConnectionDescriptor)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (connectionDescriptor_ != null) hash ^= ConnectionDescriptor.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (connectionDescriptor_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ConnectionDescriptor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (connectionDescriptor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConnectionDescriptor);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppDisconnectedEvent other) {
      if (other == null) {
        return;
      }
      if (other.connectionDescriptor_ != null) {
        if (connectionDescriptor_ == null) {
          connectionDescriptor_ = new global::Plexus.Interop.Apps.Internal.Generated.AppConnectionDescriptor();
        }
        ConnectionDescriptor.MergeFrom(other.ConnectionDescriptor);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (connectionDescriptor_ == null) {
              connectionDescriptor_ = new global::Plexus.Interop.Apps.Internal.Generated.AppConnectionDescriptor();
            }
            input.ReadMessage(connectionDescriptor_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
