using Microsoft.Extensions.DependencyInjection;

namespace BlobHelper
{
    /// <summary>
    /// Provides extension methods to add Blob Storage services to an IServiceCollection
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds an Azure Blob Storage service to an IServiceCollection instance.
        /// </summary>
        /// <param name="services">The IServiceCollection instance to which the Azure Blob Storage service should be added.</param>
        /// <param name="azureSettings">The Azure settings used to configure the Azure Blob Storage service.</param>
        /// <param name="serviceLifetime">The lifetime of the Azure Blob Storage service. Defaults to Scoped.</param>
        /// <returns>The updated IServiceCollection instance with the Azure Blob Storage service added.</returns>
        public static IServiceCollection AddAzureBlobStorage(
            this IServiceCollection services,
            AzureSettings azureSettings,
            ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            var azureBlobClientServiceDescriptor = new ServiceDescriptor(typeof(IBlobClient),
                _ => new AzureBlobClient(azureSettings), serviceLifetime);
            services.Add(azureBlobClientServiceDescriptor);
            return services;
        }
        
        /// <summary>
        /// Adds an Aws Blob Storage service to an IServiceCollection instance.
        /// </summary>
        /// <param name="services">The IServiceCollection instance to which the Aws Blob Storage service should be added.</param>
        /// <param name="awsSettings">The Azure settings used to configure the Aws Blob Storage service.</param>
        /// <param name="serviceLifetime">The lifetime of the Aws Blob Storage service. Defaults to Scoped.</param>
        /// <returns>The updated IServiceCollection instance with the Aws Blob Storage service added.</returns>
        public static IServiceCollection AddAwsBlobStorage(
            this IServiceCollection services,
            AwsSettings awsSettings,
            ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            var awsBlobClientServiceDescriptor = new ServiceDescriptor(typeof(IBlobClient),
                _ => new AwsBlobClient(awsSettings), serviceLifetime);
            services.Add(awsBlobClientServiceDescriptor);
            return services;
        }
        
        
        /// <summary>
        /// Adds an v Blob Storage service to an IServiceCollection instance.
        /// </summary>
        /// <param name="services">The IServiceCollection instance to which the Komodo Blob Storage service should be added.</param>
        /// <param name="komodoSettings">The Azure settings used to configure the Komodo Blob Storage service.</param>
        /// <param name="serviceLifetime">The lifetime of the Komodo Blob Storage service. Defaults to Scoped.</param>
        /// <returns>The updated IServiceCollection instance with the Komodo Blob Storage service added.</returns>
        public static IServiceCollection AddKomodoBlobStorage(
            this IServiceCollection services,
            KomodoSettings komodoSettings,
            ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            var komodoBlobClientServiceDescriptor = new ServiceDescriptor(typeof(IBlobClient),
                _ => new KomodoBlobClient(komodoSettings), serviceLifetime);
            services.Add(komodoBlobClientServiceDescriptor);
            return services;
        }
        
        /// <summary>
        /// Adds an KvpBase Blob Storage service to an IServiceCollection instance.
        /// </summary>
        /// <param name="services">The IServiceCollection instance to which the KvpBase Blob Storage service should be added.</param>
        /// <param name="kvpBaseSettings">The Azure settings used to configure the KvpBase Blob Storage service.</param>
        /// <param name="serviceLifetime">The lifetime of the KvpBase Blob Storage service. Defaults to Scoped.</param>
        /// <returns>The updated IServiceCollection instance with the KvpBase Blob Storage service added.</returns>
        public static IServiceCollection AddKvpBaseBlobStorage(
            this IServiceCollection services,
            KvpbaseSettings kvpBaseSettings,
            ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            var kvpBaseBlobClientServiceDescriptor = new ServiceDescriptor(typeof(IBlobClient),
                _ => new KvpBaseBlobClient(kvpBaseSettings), serviceLifetime);
            services.Add(kvpBaseBlobClientServiceDescriptor);
            return services;
        }
        
        /// <summary>
        /// Adds an Disk Blob Storage service to an IServiceCollection instance.
        /// </summary>
        /// <param name="services">The IServiceCollection instance to which the v Blob Storage service should be added.</param>
        /// <param name="diskSettings">The Azure settings used to configure the v Blob Storage service.</param>
        /// <param name="serviceLifetime">The lifetime of the v Blob Storage service. Defaults to Scoped.</param>
        /// <returns>The updated IServiceCollection instance with the Disk Blob Storage service added.</returns>
        public static IServiceCollection AddDiskBlobStorage(
            this IServiceCollection services,
            DiskSettings diskSettings,
            ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            var diskBlobClientServiceDescriptor = new ServiceDescriptor(typeof(IBlobClient),
                _ => new DiskBlobClient(diskSettings), serviceLifetime);
            services.Add(diskBlobClientServiceDescriptor);
            return services;
        }
    }
}