using Artech.Architecture.UI.Framework.Helper;
using Artech.Architecture.UI.Framework.Services;
using Artech.Common.Framework.Commands;
using System.Windows.Forms;

namespace Oqiita.Packages.SamplePackage
{
    class CommandManager : CommandDelegator
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CommandManager()
        {
            AddCommand(CommandKeys.TestCommand, new ExecHandler(this.ExTestCommand), new QueryHandler(KBOpenEnabled));
        }

        /// <summary>
        /// テストコマンド
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool ExTestCommand(CommandData data)
        {
            bool result = true;
            MessageBox.Show("Test Command");
            return result;
        }

        /// <summary>
        /// KBが開いている場合のみ実行可能
        /// </summary>
        /// <param name="data"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        private bool KBOpenEnabled(CommandData data, ref CommandStatus status)
        {
            status.State = CommandState.Disabled;
            if (UIServices.KB != null && UIServices.KB.CurrentKB != null)
            {
                status.State = CommandState.Enabled;
            }
            return true;
        }

    }
}