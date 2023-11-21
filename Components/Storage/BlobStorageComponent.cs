using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGCLoyaltyApp.Core.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TGCLoyaltyApp.Core.Components
{
    public class BlobStorageComponent : IAzureStorage
    {
        private readonly BlobStorageSettings _blobStorage;
        private readonly ILogger<BlobStorageComponent> _logger;
        public BlobStorageComponent(IOptions<BlobStorageSettings> _blobStorageSettings, ILogger<BlobStorageComponent> logger)
        {
            _blobStorage = _blobStorageSettings.Value;
            _logger = logger;
        }
        public async Task<BlobResponseDto> UploadAsync(IFormFile blob, string FilePath)
        {
            // Create new upload response object that we can return to the requesting method
            BlobResponseDto response = new();

            // Get a reference to a container named in appsettings.json and then create it
            BlobContainerClient container = new BlobContainerClient(_blobStorage.ConnectionString, _blobStorage.ContainerName);
            //await container.CreateAsync();
            try
            {
                // Get a reference to the blob just uploaded from the API in a container from configuration settings
                string fileExtension = Path.GetExtension(blob.FileName);
                string FileName = FilePath;
                await container.GetBlobClient(FileName).DeleteIfExistsAsync();
                BlobClient client = container.GetBlobClient(FileName);

                // Open a stream for the file we want to upload
                await using (Stream? data = blob.OpenReadStream())
                {
                    // Upload the file async
                    await client.UploadAsync(data);
                }

                // Everything is OK and file got uploaded
                response.Code = 200;
                response.Status = $"File {blob.FileName} Uploaded Successfully";
                response.Error = false;
                response.Blob.Uri = client.Uri.AbsoluteUri;
                response.Blob.Name = client.Name;
                var datapic = await this.DownloadFileFromStorage(FileName);
                MemoryStream memoryStream = new MemoryStream();
                datapic.CopyTo(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);
                response.Blob.byteData = memoryStream?.ToArray();

            }
            // If the file already exists, we catch the exception and do not upload it
            catch (RequestFailedException ex)
               when (ex.ErrorCode == BlobErrorCode.BlobAlreadyExists)
            {
                //_logger.LogError($"File with name {blob.FileName} already exists in container. Set another name to store the file in the container: '{_storageContainerName}.'");
                response.Status = $"File with name {blob.FileName} already exists. Please use another name to store your file.";
                response.Error = true;
                return response;
            }
            // If we get an unexpected error, we catch it here and return the error message
            catch (RequestFailedException ex)
            {
                // Log error to console and create a new response we can return to the requesting method
                //_logger.LogError($"Unhandled Exception. ID: {ex.StackTrace} - Message: {ex.Message}");
                response.Status = $"Unexpected error: {ex.StackTrace}. Check log with StackTrace ID.";
                response.Error = true;
                return response;
            }

            // Return the BlobUploadResponse object
            return response;
        }
        public async Task<BlobResponseDto> UploadPromtionAsync(Stream data, string FilePath)
        {
            // Create new upload response object that we can return to the requesting method
            BlobResponseDto response = new();

            // Get a reference to a container named in appsettings.json and then create it
            BlobContainerClient container = new BlobContainerClient(_blobStorage.ConnectionString, _blobStorage.ContainerName);
            //await container.CreateAsync();
            try
            {
                // Get a reference to the blob just uploaded from the API in a container from configuration settings
                string FileName = FilePath;
                await container.GetBlobClient(FileName).DeleteIfExistsAsync();
                BlobClient client = container.GetBlobClient(FileName);


                    // Upload the file async
                    await client.UploadAsync(data);

                // Everything is OK and file got uploaded
                response.Code = 200;
                response.Status = $"File Uploaded Successfully";
                response.Error = false;
                response.Blob.Uri = client.Uri.AbsoluteUri;
                response.Blob.Name = client.Name;
                var datapic = await this.DownloadFileFromStorage(FileName);
                MemoryStream memoryStream = new MemoryStream();
                datapic.CopyTo(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);
                response.Blob.byteData = memoryStream?.ToArray();

            }
            // If the file already exists, we catch the exception and do not upload it
            catch (RequestFailedException ex)
               when (ex.ErrorCode == BlobErrorCode.BlobAlreadyExists)
            {
                //_logger.LogError($"File with name {blob.FileName} already exists in container. Set another name to store the file in the container: '{_storageContainerName}.'");
                response.Status = $"File with same name already exists. Please use another name to store your file.";
                response.Error = true;
                return response;
            }
            // If we get an unexpected error, we catch it here and return the error message
            catch (RequestFailedException ex)
            {
                // Log error to console and create a new response we can return to the requesting method
                //_logger.LogError($"Unhandled Exception. ID: {ex.StackTrace} - Message: {ex.Message}");
                response.Status = $"Unexpected error: {ex.StackTrace}. Check log with StackTrace ID.";
                response.Error = true;
                return response;
            }

            // Return the BlobUploadResponse object
            return response;
        }
        public async Task<Stream> DownloadFileFromStorage(string fileName)
        {
            // Create a URI to the blob
            BlobContainerClient client = new BlobContainerClient(_blobStorage.ConnectionString, _blobStorage.ContainerName);
            try
            {
                // Get a reference to the blob uploaded earlier from the API in the container from configuration settings
                BlobClient file = client.GetBlobClient(fileName);

                // Check if the file exists in the container
                if (await file.ExistsAsync())
                {
                    var data = await file.OpenReadAsync();
                    Stream blobContent = data;

                    // Download the file details async
                    var content = await file.DownloadContentAsync();

                    // Add data to variables in order to return a BlobDto
                    string name = fileName;
                    string contentType = content.Value.Details.ContentType;

                    // Create new BlobDto with blob data from variables
                    return blobContent;
                }
            }
            catch (RequestFailedException ex)
                when (ex.ErrorCode == BlobErrorCode.BlobNotFound)
            {
                // Log error to console
                _logger.LogError($"File {fileName} was not found.");
            }

            // File does not exist, return null and handle that in requesting method
            return null;
        }

        public class BlobResponseDto : ResponseBase
        {
            public string? Status { get; set; }
            public bool Error { get; set; }
            public BlobDto Blob { get; set; }

            public BlobResponseDto()
            {
                Blob = new BlobDto();
            }
        }
        public class BlobDto
        {
            public string? Uri { get; set; }
            public string? Name { get; set; }
            public byte[]? byteData { get; set; }
            public string? ContentType { get; set; }
            public Stream? Content { get; set; }
        }
        public class BlobStorageSettings
        {
            public string ConnectionString { get; set; }
            public string ContainerName { get; set; }
        }
    }
}
