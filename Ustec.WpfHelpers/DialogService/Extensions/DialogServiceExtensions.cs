using Prism.Services.Dialogs;

namespace Ustec.WpfHelpers.DialogService.Extensions
{
    public static class DialogServiceExtensions
    {
        /// <summary>問い合わせメッセーボックスを表示します。</summary>
        /// <param name="dialogService">IDialogService。</param>
        /// <param name="message">表示するメッセージを表す文字列。</param>
        /// <returns>問い合わせメッセーボックスの戻り値を表すButtonResult列挙型の内の1つ。</returns>
        public static ButtonResult ShowConfirmationMessage(this IDialogService dialogService, string message)
        {
            var param = new DialogParameters($"Message={message}");
            var tempRet = ButtonResult.Cancel;

            dialogService.ShowDialog("ConfirmedMessageBox", param, r => tempRet = r.Result);

            return tempRet;
        }
    }
}