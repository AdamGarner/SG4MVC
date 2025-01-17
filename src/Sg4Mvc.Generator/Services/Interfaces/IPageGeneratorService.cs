using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Sg4Mvc.Generator.CodeGen;

namespace Sg4Mvc.Generator.Services.Interfaces;

public interface IPageGeneratorService
{
    ClassDeclarationSyntax GeneratePartialPage(PageView pageView);
    ClassDeclarationSyntax GenerateSg4Page(PageDefinition page);
    ClassBuilder WithViewsClass(ClassBuilder classBuilder, IEnumerable<PageView> viewFiles);
    void AddSg4ActionMethods(ClassBuilder genControllerClass, String pagePath);
}
