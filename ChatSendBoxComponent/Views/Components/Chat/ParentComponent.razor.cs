using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ChatSendBoxComponent.Views.Components.Chat
{
    public partial class ParentComponent
    {
        [Inject]
        private IJSRuntime JsRuntime { get; set; }

        private string message;
        private ChatSendBox chatSendBox;

        private void OnClick()
        {
            JsRuntime.InvokeAsync<object>("alert", new[] { message });
            message = "";
            chatSendBox.FocusAsync();
        }
    }
}