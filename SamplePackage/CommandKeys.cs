using System;
using Artech.Common.Framework.Commands;

namespace Oqiita.Packages.SamplePackage
{
    class CommandKeys
    {
        /* コマンド */
        private static CommandKey testCommand = new CommandKey(Package.guid, "TestCommand");

        /* コマンドの取得 */
        public static CommandKey TestCommand { get { return testCommand; } }
    }
}