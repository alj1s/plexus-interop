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
// 	Generated by the Plexus Interop compiler.  DO NOT EDIT!
// 	source: interop\app_lifecycle_manager.interop
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code
namespace Plexus.Interop.Apps.Internal.Generated {
	
	using System;
	using global::Plexus;
	using global::Plexus.Channels;
	using global::Plexus.Interop;
	using global::System.Threading.Tasks;
					
					
	internal partial interface IAppLifecycleManagerClient: IClient {
		AppLifecycleManagerClient.IAppLauncherServiceProxy AppLauncherService { get; }
	}
	
	internal sealed partial class AppLifecycleManagerClient: ClientBase, IAppLifecycleManagerClient {
		
		public const string Id = "interop.AppLifecycleManager";
		
		private static ClientOptions CreateClientOptions(AppLifecycleManagerClient.ServiceBinder serviceBinder, Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null) {
			ClientOptionsBuilder builder = new ClientOptionsBuilder().WithApplicationId(Id).WithDefaultConfiguration();
			serviceBinder.Bind(builder);
			if (setup != null) {
				builder = setup(builder);
			}
			return builder.Build();
		}
		
		public AppLifecycleManagerClient(
			AppLifecycleManagerClient.IAppLifecycleServiceImpl appLifecycleService,
			AppLifecycleManagerClient.IAppMetadataServiceImpl appMetadataService,
			AppLifecycleManagerClient.IContextLinkageServiceImpl contextLinkageService,
			AppLifecycleManagerClient.IAppRegistrationServiceImpl appRegistrationService,
			Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null
		)
		:this(new AppLifecycleManagerClient.ServiceBinder(
			appLifecycleService,
			appMetadataService,
			contextLinkageService,
			appRegistrationService
		), setup) { }
		
		public AppLifecycleManagerClient(AppLifecycleManagerClient.ServiceBinder serviceBinder, Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null): base(CreateClientOptions(serviceBinder, setup)) 
		{
			AppLauncherService = new AppLifecycleManagerClient.AppLauncherServiceProxy(this.CallInvoker);
		}
	
		public sealed partial class ServiceBinder {
			
			public ServiceBinder(
				AppLifecycleManagerClient.IAppLifecycleServiceImpl appLifecycleService,
				AppLifecycleManagerClient.IAppMetadataServiceImpl appMetadataService,
				AppLifecycleManagerClient.IContextLinkageServiceImpl contextLinkageService,
				AppLifecycleManagerClient.IAppRegistrationServiceImpl appRegistrationService
			) {
				_appLifecycleServiceBinder = new AppLifecycleManagerClient.AppLifecycleServiceBinder(appLifecycleService);
				_appMetadataServiceBinder = new AppLifecycleManagerClient.AppMetadataServiceBinder(appMetadataService);
				_contextLinkageServiceBinder = new AppLifecycleManagerClient.ContextLinkageServiceBinder(contextLinkageService);
				_appRegistrationServiceBinder = new AppLifecycleManagerClient.AppRegistrationServiceBinder(appRegistrationService);
			}
			
			private AppLifecycleServiceBinder _appLifecycleServiceBinder;
			private AppMetadataServiceBinder _appMetadataServiceBinder;
			private ContextLinkageServiceBinder _contextLinkageServiceBinder;
			private AppRegistrationServiceBinder _appRegistrationServiceBinder;
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				builder = _appLifecycleServiceBinder.Bind(builder);
				builder = _appMetadataServiceBinder.Bind(builder);
				builder = _contextLinkageServiceBinder.Bind(builder);
				builder = _appRegistrationServiceBinder.Bind(builder);
				return builder;
			}
		}
	
		public partial interface IAppLifecycleServiceImpl:
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IResolveAppImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IGetLifecycleEventStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IGetInvocationEventStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IGetConnectionsImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IGetConnectionsStreamImpl
		{ }
		
		private sealed partial class AppLifecycleServiceBinder {
			
			
			private readonly IAppLifecycleServiceImpl _impl;
			
			public AppLifecycleServiceBinder(IAppLifecycleServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.Id, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Apps.Internal.Generated.ResolveAppRequest, global::Plexus.Interop.Apps.Internal.Generated.ResolveAppResponse>(global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.ResolveAppMethodId, _impl.ResolveApp);
				builder = builder.WithServerStreamingMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleEvent>(global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.GetLifecycleEventStreamMethodId, _impl.GetLifecycleEventStream);
				builder = builder.WithServerStreamingMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.InvocationEvent>(global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.GetInvocationEventStreamMethodId, _impl.GetInvocationEventStream);
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest, global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsResponse>(global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.GetConnectionsMethodId, _impl.GetConnections);
				builder = builder.WithServerStreamingMethod<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest, global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsEvent>(global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.GetConnectionsStreamMethodId, _impl.GetConnectionsStream);
				return builder; 							
			}
		}
		
		public sealed partial class AppLifecycleServiceImpl: IAppLifecycleServiceImpl
		{
			private readonly UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.ResolveAppRequest, global::Plexus.Interop.Apps.Internal.Generated.ResolveAppResponse> _resolveAppHandler;
			private readonly ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleEvent> _getLifecycleEventStreamHandler;
			private readonly ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.InvocationEvent> _getInvocationEventStreamHandler;
			private readonly UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest, global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsResponse> _getConnectionsHandler;
			private readonly ServerStreamingMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest, global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsEvent> _getConnectionsStreamHandler;
			
			public AppLifecycleServiceImpl(
				UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.ResolveAppRequest, global::Plexus.Interop.Apps.Internal.Generated.ResolveAppResponse> resolveAppHandler,
				ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleEvent> getLifecycleEventStreamHandler,
				ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.InvocationEvent> getInvocationEventStreamHandler,
				UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest, global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsResponse> getConnectionsHandler,
				ServerStreamingMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest, global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsEvent> getConnectionsStreamHandler
			) {
				_resolveAppHandler = resolveAppHandler;
				_getLifecycleEventStreamHandler = getLifecycleEventStreamHandler;
				_getInvocationEventStreamHandler = getInvocationEventStreamHandler;
				_getConnectionsHandler = getConnectionsHandler;
				_getConnectionsStreamHandler = getConnectionsStreamHandler;
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.ResolveAppResponse> ResolveApp(global::Plexus.Interop.Apps.Internal.Generated.ResolveAppRequest request, MethodCallContext context) {
				return _resolveAppHandler(request, context);
			}
			
			public Task GetLifecycleEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleEvent> responseStream, MethodCallContext context) {
				return _getLifecycleEventStreamHandler(request, responseStream, context);
			}
			
			public Task GetInvocationEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.InvocationEvent> responseStream, MethodCallContext context) {
				return _getInvocationEventStreamHandler(request, responseStream, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsResponse> GetConnections(global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest request, MethodCallContext context) {
				return _getConnectionsHandler(request, context);
			}
			
			public Task GetConnectionsStream(global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsEvent> responseStream, MethodCallContext context) {
				return _getConnectionsStreamHandler(request, responseStream, context);
			}
		}					
		
		public sealed partial class AppLifecycleServiceImpl<T>: IAppLifecycleServiceImpl
			where T:
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IResolveAppImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IGetLifecycleEventStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IGetInvocationEventStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IGetConnectionsImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleService.IGetConnectionsStreamImpl
		{
			private readonly T _impl;
			
			public AppLifecycleServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.ResolveAppResponse> ResolveApp(global::Plexus.Interop.Apps.Internal.Generated.ResolveAppRequest request, MethodCallContext context) {
				return _impl.ResolveApp(request, context);
			}
			
			public Task GetLifecycleEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleEvent> responseStream, MethodCallContext context) {
				return _impl.GetLifecycleEventStream(request, responseStream, context);
			}
			
			public Task GetInvocationEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.InvocationEvent> responseStream, MethodCallContext context) {
				return _impl.GetInvocationEventStream(request, responseStream, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsResponse> GetConnections(global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest request, MethodCallContext context) {
				return _impl.GetConnections(request, context);
			}
			
			public Task GetConnectionsStream(global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsRequest request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.GetConnectionsEvent> responseStream, MethodCallContext context) {
				return _impl.GetConnectionsStream(request, responseStream, context);
			}
		}
		
		public partial interface IAppMetadataServiceImpl:
			global::Plexus.Interop.Apps.Internal.Generated.AppMetadataService.IGetAppMetadataChangedEventStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppMetadataService.IGetMetamodelChangedEventStreamImpl
		{ }
		
		private sealed partial class AppMetadataServiceBinder {
			
			
			private readonly IAppMetadataServiceImpl _impl;
			
			public AppMetadataServiceBinder(IAppMetadataServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Apps.Internal.Generated.AppMetadataService.Id, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithServerStreamingMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.AppMetadataChangedEvent>(global::Plexus.Interop.Apps.Internal.Generated.AppMetadataService.GetAppMetadataChangedEventStreamMethodId, _impl.GetAppMetadataChangedEventStream);
				builder = builder.WithServerStreamingMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.MetamodelChangedEvent>(global::Plexus.Interop.Apps.Internal.Generated.AppMetadataService.GetMetamodelChangedEventStreamMethodId, _impl.GetMetamodelChangedEventStream);
				return builder; 							
			}
		}
		
		public sealed partial class AppMetadataServiceImpl: IAppMetadataServiceImpl
		{
			private readonly ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.AppMetadataChangedEvent> _getAppMetadataChangedEventStreamHandler;
			private readonly ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.MetamodelChangedEvent> _getMetamodelChangedEventStreamHandler;
			
			public AppMetadataServiceImpl(
				ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.AppMetadataChangedEvent> getAppMetadataChangedEventStreamHandler,
				ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.MetamodelChangedEvent> getMetamodelChangedEventStreamHandler
			) {
				_getAppMetadataChangedEventStreamHandler = getAppMetadataChangedEventStreamHandler;
				_getMetamodelChangedEventStreamHandler = getMetamodelChangedEventStreamHandler;
			}
			
			public Task GetAppMetadataChangedEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.AppMetadataChangedEvent> responseStream, MethodCallContext context) {
				return _getAppMetadataChangedEventStreamHandler(request, responseStream, context);
			}
			
			public Task GetMetamodelChangedEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.MetamodelChangedEvent> responseStream, MethodCallContext context) {
				return _getMetamodelChangedEventStreamHandler(request, responseStream, context);
			}
		}					
		
		public sealed partial class AppMetadataServiceImpl<T>: IAppMetadataServiceImpl
			where T:
			global::Plexus.Interop.Apps.Internal.Generated.AppMetadataService.IGetAppMetadataChangedEventStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppMetadataService.IGetMetamodelChangedEventStreamImpl
		{
			private readonly T _impl;
			
			public AppMetadataServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task GetAppMetadataChangedEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.AppMetadataChangedEvent> responseStream, MethodCallContext context) {
				return _impl.GetAppMetadataChangedEventStream(request, responseStream, context);
			}
			
			public Task GetMetamodelChangedEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.MetamodelChangedEvent> responseStream, MethodCallContext context) {
				return _impl.GetMetamodelChangedEventStream(request, responseStream, context);
			}
		}
		
		public partial interface IContextLinkageServiceImpl:
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IContextLoadedStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.ICreateContextImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IJoinContextImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IGetContextsImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IGetLinkedInvocationsImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IGetAllLinkedInvocationsImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IAppJoinedContextStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IRestoreContextsLinkageImpl
		{ }
		
		private sealed partial class ContextLinkageServiceBinder {
			
			
			private readonly IContextLinkageServiceImpl _impl;
			
			public ContextLinkageServiceBinder(IContextLinkageServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.Id, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithServerStreamingMethod<global::Plexus.Interop.Apps.Internal.Generated.Context, global::Plexus.Interop.Apps.Internal.Generated.ContextLoadingUpdate>(global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.ContextLoadedStreamMethodId, _impl.ContextLoadedStream);
				builder = builder.WithUnaryMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.Context>(global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.CreateContextMethodId, _impl.CreateContext);
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Apps.Internal.Generated.Context, global::Google.Protobuf.WellKnownTypes.Empty>(global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.JoinContextMethodId, _impl.JoinContext);
				builder = builder.WithUnaryMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.ContextsList>(global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.GetContextsMethodId, _impl.GetContexts);
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Apps.Internal.Generated.Context, global::Plexus.Interop.Apps.Internal.Generated.InvocationsList>(global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.GetLinkedInvocationsMethodId, _impl.GetLinkedInvocations);
				builder = builder.WithUnaryMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.ContextToInvocationsList>(global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.GetAllLinkedInvocationsMethodId, _impl.GetAllLinkedInvocations);
				builder = builder.WithServerStreamingMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.AppJoinedContextEvent>(global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.AppJoinedContextStreamMethodId, _impl.AppJoinedContextStream);
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageRequest, global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageResponse>(global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.RestoreContextsLinkageMethodId, _impl.RestoreContextsLinkage);
				return builder; 							
			}
		}
		
		public sealed partial class ContextLinkageServiceImpl: IContextLinkageServiceImpl
		{
			private readonly ServerStreamingMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.Context, global::Plexus.Interop.Apps.Internal.Generated.ContextLoadingUpdate> _contextLoadedStreamHandler;
			private readonly UnaryMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.Context> _createContextHandler;
			private readonly UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.Context, global::Google.Protobuf.WellKnownTypes.Empty> _joinContextHandler;
			private readonly UnaryMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.ContextsList> _getContextsHandler;
			private readonly UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.Context, global::Plexus.Interop.Apps.Internal.Generated.InvocationsList> _getLinkedInvocationsHandler;
			private readonly UnaryMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.ContextToInvocationsList> _getAllLinkedInvocationsHandler;
			private readonly ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.AppJoinedContextEvent> _appJoinedContextStreamHandler;
			private readonly UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageRequest, global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageResponse> _restoreContextsLinkageHandler;
			
			public ContextLinkageServiceImpl(
				ServerStreamingMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.Context, global::Plexus.Interop.Apps.Internal.Generated.ContextLoadingUpdate> contextLoadedStreamHandler,
				UnaryMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.Context> createContextHandler,
				UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.Context, global::Google.Protobuf.WellKnownTypes.Empty> joinContextHandler,
				UnaryMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.ContextsList> getContextsHandler,
				UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.Context, global::Plexus.Interop.Apps.Internal.Generated.InvocationsList> getLinkedInvocationsHandler,
				UnaryMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.ContextToInvocationsList> getAllLinkedInvocationsHandler,
				ServerStreamingMethodHandler<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Apps.Internal.Generated.AppJoinedContextEvent> appJoinedContextStreamHandler,
				UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageRequest, global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageResponse> restoreContextsLinkageHandler
			) {
				_contextLoadedStreamHandler = contextLoadedStreamHandler;
				_createContextHandler = createContextHandler;
				_joinContextHandler = joinContextHandler;
				_getContextsHandler = getContextsHandler;
				_getLinkedInvocationsHandler = getLinkedInvocationsHandler;
				_getAllLinkedInvocationsHandler = getAllLinkedInvocationsHandler;
				_appJoinedContextStreamHandler = appJoinedContextStreamHandler;
				_restoreContextsLinkageHandler = restoreContextsLinkageHandler;
			}
			
			public Task ContextLoadedStream(global::Plexus.Interop.Apps.Internal.Generated.Context request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.ContextLoadingUpdate> responseStream, MethodCallContext context) {
				return _contextLoadedStreamHandler(request, responseStream, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.Context> CreateContext(global::Google.Protobuf.WellKnownTypes.Empty request, MethodCallContext context) {
				return _createContextHandler(request, context);
			}
			
			public Task<global::Google.Protobuf.WellKnownTypes.Empty> JoinContext(global::Plexus.Interop.Apps.Internal.Generated.Context request, MethodCallContext context) {
				return _joinContextHandler(request, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.ContextsList> GetContexts(global::Google.Protobuf.WellKnownTypes.Empty request, MethodCallContext context) {
				return _getContextsHandler(request, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.InvocationsList> GetLinkedInvocations(global::Plexus.Interop.Apps.Internal.Generated.Context request, MethodCallContext context) {
				return _getLinkedInvocationsHandler(request, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.ContextToInvocationsList> GetAllLinkedInvocations(global::Google.Protobuf.WellKnownTypes.Empty request, MethodCallContext context) {
				return _getAllLinkedInvocationsHandler(request, context);
			}
			
			public Task AppJoinedContextStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.AppJoinedContextEvent> responseStream, MethodCallContext context) {
				return _appJoinedContextStreamHandler(request, responseStream, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageResponse> RestoreContextsLinkage(global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageRequest request, MethodCallContext context) {
				return _restoreContextsLinkageHandler(request, context);
			}
		}					
		
		public sealed partial class ContextLinkageServiceImpl<T>: IContextLinkageServiceImpl
			where T:
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IContextLoadedStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.ICreateContextImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IJoinContextImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IGetContextsImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IGetLinkedInvocationsImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IGetAllLinkedInvocationsImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IAppJoinedContextStreamImpl,
			global::Plexus.Interop.Apps.Internal.Generated.ContextLinkageService.IRestoreContextsLinkageImpl
		{
			private readonly T _impl;
			
			public ContextLinkageServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task ContextLoadedStream(global::Plexus.Interop.Apps.Internal.Generated.Context request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.ContextLoadingUpdate> responseStream, MethodCallContext context) {
				return _impl.ContextLoadedStream(request, responseStream, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.Context> CreateContext(global::Google.Protobuf.WellKnownTypes.Empty request, MethodCallContext context) {
				return _impl.CreateContext(request, context);
			}
			
			public Task<global::Google.Protobuf.WellKnownTypes.Empty> JoinContext(global::Plexus.Interop.Apps.Internal.Generated.Context request, MethodCallContext context) {
				return _impl.JoinContext(request, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.ContextsList> GetContexts(global::Google.Protobuf.WellKnownTypes.Empty request, MethodCallContext context) {
				return _impl.GetContexts(request, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.InvocationsList> GetLinkedInvocations(global::Plexus.Interop.Apps.Internal.Generated.Context request, MethodCallContext context) {
				return _impl.GetLinkedInvocations(request, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.ContextToInvocationsList> GetAllLinkedInvocations(global::Google.Protobuf.WellKnownTypes.Empty request, MethodCallContext context) {
				return _impl.GetAllLinkedInvocations(request, context);
			}
			
			public Task AppJoinedContextStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Apps.Internal.Generated.AppJoinedContextEvent> responseStream, MethodCallContext context) {
				return _impl.AppJoinedContextStream(request, responseStream, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageResponse> RestoreContextsLinkage(global::Plexus.Interop.Apps.Internal.Generated.RestoreContextsLinkageRequest request, MethodCallContext context) {
				return _impl.RestoreContextsLinkage(request, context);
			}
		}
		
		public partial interface IAppRegistrationServiceImpl:
			global::Plexus.Interop.Apps.Internal.Generated.AppRegistrationService.IRequestInstanceIdImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppRegistrationService.IRegisterInstanceIdImpl
		{ }
		
		private sealed partial class AppRegistrationServiceBinder {
			
			
			private readonly IAppRegistrationServiceImpl _impl;
			
			public AppRegistrationServiceBinder(IAppRegistrationServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Apps.Internal.Generated.AppRegistrationService.Id, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Apps.Internal.Generated.RequestInstanceIdRequest, global::Plexus.Interop.Apps.Internal.Generated.UniqueId>(global::Plexus.Interop.Apps.Internal.Generated.AppRegistrationService.RequestInstanceIdMethodId, _impl.RequestInstanceId);
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdRequest, global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdResponse>(global::Plexus.Interop.Apps.Internal.Generated.AppRegistrationService.RegisterInstanceIdMethodId, _impl.RegisterInstanceId);
				return builder; 							
			}
		}
		
		public sealed partial class AppRegistrationServiceImpl: IAppRegistrationServiceImpl
		{
			private readonly UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.RequestInstanceIdRequest, global::Plexus.Interop.Apps.Internal.Generated.UniqueId> _requestInstanceIdHandler;
			private readonly UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdRequest, global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdResponse> _registerInstanceIdHandler;
			
			public AppRegistrationServiceImpl(
				UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.RequestInstanceIdRequest, global::Plexus.Interop.Apps.Internal.Generated.UniqueId> requestInstanceIdHandler,
				UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdRequest, global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdResponse> registerInstanceIdHandler
			) {
				_requestInstanceIdHandler = requestInstanceIdHandler;
				_registerInstanceIdHandler = registerInstanceIdHandler;
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.UniqueId> RequestInstanceId(global::Plexus.Interop.Apps.Internal.Generated.RequestInstanceIdRequest request, MethodCallContext context) {
				return _requestInstanceIdHandler(request, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdResponse> RegisterInstanceId(global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdRequest request, MethodCallContext context) {
				return _registerInstanceIdHandler(request, context);
			}
		}					
		
		public sealed partial class AppRegistrationServiceImpl<T>: IAppRegistrationServiceImpl
			where T:
			global::Plexus.Interop.Apps.Internal.Generated.AppRegistrationService.IRequestInstanceIdImpl,
			global::Plexus.Interop.Apps.Internal.Generated.AppRegistrationService.IRegisterInstanceIdImpl
		{
			private readonly T _impl;
			
			public AppRegistrationServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.UniqueId> RequestInstanceId(global::Plexus.Interop.Apps.Internal.Generated.RequestInstanceIdRequest request, MethodCallContext context) {
				return _impl.RequestInstanceId(request, context);
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdResponse> RegisterInstanceId(global::Plexus.Interop.Apps.Internal.Generated.RegisterInstanceIdRequest request, MethodCallContext context) {
				return _impl.RegisterInstanceId(request, context);
			}
		}
		
		public partial interface IAppLauncherServiceProxy:
			global::Plexus.Interop.Apps.Internal.Generated.AppLauncherService.ILaunchProxy,
			global::Plexus.Interop.Apps.Internal.Generated.AppLauncherService.IAppLaunchedEventStreamProxy
		{ }
		
		public sealed partial class AppLauncherServiceProxy: IAppLauncherServiceProxy {
			
			public static global::Plexus.Interop.Apps.Internal.Generated.AppLauncherService.Descriptor Descriptor = global::Plexus.Interop.Apps.Internal.Generated.AppLauncherService.DefaultDescriptor;
			
			private readonly IClientCallInvoker _callInvoker;
									
			public AppLauncherServiceProxy(IClientCallInvoker callInvoker) {
				_callInvoker = callInvoker;
			}						
			
			public IUnaryMethodCall<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse> Launch(global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest request) {
				return _callInvoker.Call(Descriptor.LaunchMethod, request);
			}
			
			public IServerStreamingMethodCall<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchedEvent> AppLaunchedEventStream(global::Google.Protobuf.WellKnownTypes.Empty request) {
				return _callInvoker.Call(Descriptor.AppLaunchedEventStreamMethod, request);
			}
		}
		
		public IAppLauncherServiceProxy AppLauncherService { get; private set; }
	}
}
#endregion Designer generated code
