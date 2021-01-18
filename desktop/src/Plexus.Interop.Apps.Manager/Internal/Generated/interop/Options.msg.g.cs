/**
 * Copyright 2017-2021 Plexus Interop Deutsche Bank AG
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
//     source: interop/options.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Plexus.Interop.Apps.Internal.Generated {

  /// <summary>Holder for reflection information generated from interop/options.proto</summary>
  internal static partial class OptionsReflection {

    #region Descriptor
    /// <summary>File descriptor for interop/options.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OptionsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVpbnRlcm9wL29wdGlvbnMucHJvdG8SB2ludGVyb3AaIGdvb2dsZS9wcm90",
            "b2J1Zi9kZXNjcmlwdG9yLnByb3RvOjQKCm1lc3NhZ2VfaWQSHy5nb29nbGUu",
            "cHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYsksgASgJOjQKCnNlcnZpY2VfaWQS",
            "Hy5nb29nbGUucHJvdG9idWYuU2VydmljZU9wdGlvbnMYsksgASgJOjIKCW1l",
            "dGhvZF9pZBIeLmdvb2dsZS5wcm90b2J1Zi5NZXRob2RPcHRpb25zGLJLIAEo",
            "CUIpqgImUGxleHVzLkludGVyb3AuQXBwcy5JbnRlcm5hbC5HZW5lcmF0ZWRi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { OptionsExtensions.MessageId, OptionsExtensions.ServiceId, OptionsExtensions.MethodId }, null));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of interop/options.proto</summary>
  internal static partial class OptionsExtensions {
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, string> MessageId =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, string>(9650, pb::FieldCodec.ForString(77202, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.ServiceOptions, string> ServiceId =
      new pb::Extension<global::Google.Protobuf.Reflection.ServiceOptions, string>(9650, pb::FieldCodec.ForString(77202, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, string> MethodId =
      new pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, string>(9650, pb::FieldCodec.ForString(77202, ""));
  }

}

#endregion Designer generated code
