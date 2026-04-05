using Microsoft.AspNetCore.Identity;

namespace TheatreReportingApp.DtoAndHelpers
{
    public class RussianIdentityErrorsDescriber:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUniqueChars),
                Description = $"Пароль должен содержать не менее {uniqueChars} уникальных символов."
            };
        }
    }
}
