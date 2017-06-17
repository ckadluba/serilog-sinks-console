﻿// Copyright 2017 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Serilog.Sinks.SystemConsole.Themes
{
    /// <summary>
    /// Elements styled by a console theme.
    /// </summary>
    public enum ConsoleThemeStyle
    {
        /// <summary>
        /// Prominent text, generally content within an event's message.
        /// </summary>
        Text,

        /// <summary>
        /// Boilerplate text, for example items specified in an output template.
        /// </summary>
        SecondaryText,

        /// <summary>
        /// Punctuation used when writing structured data.
        /// </summary>
        Punctuation,

        /// <summary>
        /// Output demonstrating some kind of configuration issue, e.g. an invalid
        /// message template token.
        /// </summary>
        Invalid,

        /// <summary>
        /// The built-in <see langword="null"/> value.
        /// </summary>
        Null,

        /// <summary>
        /// Property and type names.
        /// </summary>
        Name,

        /// <summary>
        /// Strings.
        /// </summary>
        String,

        /// <summary>
        /// Numbers.
        /// </summary>
        Number,
        
        /// <summary>
        /// <see cref="System.Boolean"/> values.
        /// </summary>
        Boolean,

        /// <summary>
        /// Unrecogized literal values, e.g. <see cref="System.Guid"/> instances.
        /// </summary>
        Object,

        /// <summary>
        /// Level indicator.
        /// </summary>
        LevelVerbose,

        /// <summary>
        /// Level indicator.
        /// </summary>
        LevelDebug,

        /// <summary>
        /// Level indicator.
        /// </summary>
        LevelInformation,

        /// <summary>
        /// Level indicator.
        /// </summary>
        LevelWarning,

        /// <summary>
        /// Level indicator.
        /// </summary>
        LevelError,

        /// <summary>
        /// Level indicator.
        /// </summary>
        LevelFatal
    }
}