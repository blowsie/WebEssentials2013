﻿using System.Collections.Generic;
using MadsKristensen.EditorExtensions.JavaScript;

namespace MadsKristensen.EditorExtensions.TypeScript
{
    public class TsLintCompiler : JsHintCompiler
    {
        public new readonly static string ConfigFileName = "tslint.json";
        public override IEnumerable<string> SourceExtensions { get { return new[] { ".ts" }; } }

        public override string ServiceName { get { return "TsLint"; } }
    }
}
