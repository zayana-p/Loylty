using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TGCLoyaltyApp.Core.Components.BlobStorageComponent;

namespace TGCLoyaltyApp.Core.Components
{
    public interface IAzureStorage
    {
        Task<BlobResponseDto> UploadAsync(IFormFile blob, string CardNo);
        Task<BlobResponseDto> UploadPromtionAsync(Stream data, string FilePath);
        Task<Stream> DownloadFileFromStorage(string fileName);
    }
}
