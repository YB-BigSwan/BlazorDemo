using Microsoft.JSInterop;

namespace BlazorDemo.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "success", message);
        }

        public static async ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "error", message);
        }
        
        public static async ValueTask SweetAlertSuccess(this IJSRuntime jsRuntime, string title, string message)
        {
            await jsRuntime.InvokeVoidAsync("showSweetAlert", "success", title, message);
        }

        public static async ValueTask SweetAlertError(this IJSRuntime jsRuntime, string title, string message)
        {
            await jsRuntime.InvokeVoidAsync("showSweetAlert", "error", title, message);
        }
    }
}