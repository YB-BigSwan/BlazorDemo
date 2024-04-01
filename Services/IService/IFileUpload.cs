using Microsoft.AspNetCore.Components.Forms;

namespace BlazorDemo.Services.IService;

public interface IFileUpload
{
    Task<string> UploadFile(IBrowserFile file);
    bool DeleteFile(string filePath);
}