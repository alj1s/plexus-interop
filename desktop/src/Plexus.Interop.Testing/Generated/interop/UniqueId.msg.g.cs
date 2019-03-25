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
//     source: interop/unique_id.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Plexus.Interop.Testing.Generated {

  /// <summary>Holder for reflection information generated from interop/unique_id.proto</summary>
  public static partial class UniqueIdReflection {

    #region Descriptor
    /// <summary>File descriptor for interop/unique_id.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UniqueIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdpbnRlcm9wL3VuaXF1ZV9pZC5wcm90bxIHaW50ZXJvcBoVaW50ZXJvcC9v",
            "cHRpb25zLnByb3RvIjgKCFVuaXF1ZUlkEgoKAmxvGAEgASgGEgoKAmhpGAIg",
            "ASgGOhSS2wQQaW50ZXJvcC5VbmlxdWVJZEIjqgIgUGxleHVzLkludGVyb3Au",
            "VGVzdGluZy5HZW5lcmF0ZWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Plexus.Interop.Testing.Generated.OptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Testing.Generated.UniqueId), global::Plexus.Interop.Testing.Generated.UniqueId.Parser, new[]{ "Lo", "Hi" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Stores UUID in little-endian format (i.e. reversed).
  /// To convert to bytes on little-endian systems (most common case): concat (toBytes(hi), toBytes(lo))
  /// To convert to bytes on big-endian systems need to additionally reverse "hi" and "lo" parts: concat( reverse(toBytes(hi)), reverse(toBytes(lo)) )
  /// </summary>
  public sealed partial class UniqueId : pb::IMessage<UniqueId> {
    private static readonly pb::MessageParser<UniqueId> _parser = new pb::MessageParser<UniqueId>(() => new UniqueId());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UniqueId> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Testing.Generated.UniqueIdReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UniqueId() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UniqueId(UniqueId other) : this() {
      lo_ = other.lo_;
      hi_ = other.hi_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UniqueId Clone() {
      return new UniqueId(this);
    }

    /// <summary>Field number for the "lo" field.</summary>
    public const int LoFieldNumber = 1;
    private ulong lo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Lo {
      get { return lo_; }
      set {
        lo_ = value;
      }
    }

    /// <summary>Field number for the "hi" field.</summary>
    public const int HiFieldNumber = 2;
    private ulong hi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Hi {
      get { return hi_; }
      set {
        hi_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UniqueId);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UniqueId other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Lo != other.Lo) return false;
      if (Hi != other.Hi) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Lo != 0UL) hash ^= Lo.GetHashCode();
      if (Hi != 0UL) hash ^= Hi.GetHashCode();
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
      if (Lo != 0UL) {
        output.WriteRawTag(9);
        output.WriteFixed64(Lo);
      }
      if (Hi != 0UL) {
        output.WriteRawTag(17);
        output.WriteFixed64(Hi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Lo != 0UL) {
        size += 1 + 8;
      }
      if (Hi != 0UL) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UniqueId other) {
      if (other == null) {
        return;
      }
      if (other.Lo != 0UL) {
        Lo = other.Lo;
      }
      if (other.Hi != 0UL) {
        Hi = other.Hi;
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
          case 9: {
            Lo = input.ReadFixed64();
            break;
          }
          case 17: {
            Hi = input.ReadFixed64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
