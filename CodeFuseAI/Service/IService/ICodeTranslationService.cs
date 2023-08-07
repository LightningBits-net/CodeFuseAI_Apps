﻿using System;

namespace CodeFuseAI.Service.IService
{
    public interface ICodeTranslationService
    {
        Task<string> TranslateVBNetToCSharpAsync(string vbNetCode);
        Task<string> TranslateCSharpToVBNetAsync(string csharpCode);
        Task<string> ExplainCodeDifferencesAsync(string originalCode, string translatedCode, string originalLanguage, string translatedLanguage);

    }
}
