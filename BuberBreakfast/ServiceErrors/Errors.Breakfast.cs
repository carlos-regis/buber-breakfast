using ErrorOr;

namespace BuberBreakfast.ServiceErrors;

public static class Errors
{
    public static class Breakfast
    {
        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName",
            description: $"Breakfast name must be at least {Models.Breakfast.MinNameLength} characters " +
                $"and no more than {Models.Breakfast.MaxNameLength} characters."
        );

        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.InvalidDescription",
            description: $"Breakfast description must be at least {Models.Breakfast.MinDescriptionLength} characters " +
                $"and no more than {Models.Breakfast.MaxDescriptionLength} characters."
        );

        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast not found."
        );
    }
}
