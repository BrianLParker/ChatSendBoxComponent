using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ChatSendBoxComponent.Views.Components.Chat
{
    public partial class ChatSendBox
    {
        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public string Label { get; set; }

        [Parameter]
        public string Placeholder { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        [Parameter]
        public Action OnClick { get; set; }

        [Parameter]
        public bool IsDisabled { get; set; }

        public async Task Click()
        {
            await ValueChanged.InvokeAsync(Value);
            OnClick?.Invoke();
        }

        public ValueTask FocusAsync() => input.FocusAsync();

        public void Disable()
        {
            IsDisabled = true;
            InvokeAsync(StateHasChanged);
        }

        public void Enable()
        {
            IsDisabled = false;
            InvokeAsync(StateHasChanged);
        }

        private ElementReference input;
    }
}
