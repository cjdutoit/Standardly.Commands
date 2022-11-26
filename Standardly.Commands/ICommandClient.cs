// ---------------------------------------------------------------
// Copyright (c) Christo du Toit. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Standardly.Commands
{
    public interface ICommandClient : IDisposable
    {
        /// <summary>
        /// A command client that to run commands. 
        /// </summary>
        /// <param name="commandPath">
        ///     Summary:
        ///        Gets or sets the application or document to start.
        ///
        ///     Returns:
        ///        The name of the application to start, or the name of a document of a file type
        ///        that is associated with an application and that has a default open action available
        ///        to it. The default is an empty string ("").
        /// </param>
        /// <param name="useShellExecute">
        ///     Summary:
        ///         Gets or sets a value indicating whether to use the operating system shell to
        ///         start the process.
        ///
        ///     Returns:
        ///         true if the shell should be used when starting the process; false if the process
        ///         should be created directly from the executable file. The default is true.
        /// </param>
        /// <param name="createNoWindow">
        ///     Summary:
        ///         Gets or sets a value indicating whether to start the process in a new window.
        ///
        ///     Returns:
        ///         true if the process should be started without creating a new window to contain
        ///         it; otherwise, false. The default is false.
        /// </param>


        /// <summary>
        /// Executes a command.
        /// </summary>
        /// <param name="command">The application to run or document to open.</param>
        /// <returns>Returns a string output for the action taken.</returns>
        string ExecuteCommand(string command);

        /// <summary>
        /// Executes multiple commands.
        /// </summary>
        /// <param name="commands">The command list of application to run or documents to open.</param>
        /// <returns>Returns a string output for the action taken.</returns>
        string ExecuteCommand(List<string> commands);
    }
}