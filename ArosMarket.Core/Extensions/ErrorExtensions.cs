using FluentValidation;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using StatusGeneric;

namespace ArosMarket.Core.Extensions;

public static class ErrorExtensions
{
    public static void CopyToModelState(this IStatusGeneric status, ModelStateDictionary modelState)
    {
        if (!status.HasErrors)
        {
            return;
        }

        foreach (var error in status.Errors)
        {
            modelState.AddModelError(error.ErrorResult.MemberNames.Count() == 1 ? error.ErrorResult.MemberNames.First() : string.Empty,
                error.ToString());
        }
    }
}
