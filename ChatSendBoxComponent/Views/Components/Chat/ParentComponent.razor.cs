using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ChatSendBoxComponent.Views.Components.Chat
{
    public partial class ParentComponent
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        string message;
        ChatSendBox chatSendBox;

        void OnClick()
        {
            JsRuntime.InvokeAsync<object>("alert", new[] { message });
            message = "";
            chatSendBox.FocusAsync();
        }
    }
}