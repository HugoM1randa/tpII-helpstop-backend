using HelpApp.Domain.Entities;
using FluentAssertions;
using Xunit;
using Newtonsoft.Json.Linq;

namespace HelpApp.Domain.Test
{
    public class CategoryUnitTest
    {
        #region Testes Positivos

        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectionValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Category With More Than Three Lenght")]
        public void CreateCategory_WithValidMoreThanThreeLenght_ResultObjectionValidState()
        {
            Action action = () => new Category(2, "Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Category With Valid State Alone Name")]
        public void CreateCategory_AloneName_ResultObjectionValidState()
        {
            Action action = () => new Category("Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }



        #endregion

        #region Testes Negativos

        [Fact(DisplayName = "Create Category With Name Empty")]
        public void CreateCategory_WithNameEmpty_ResultObjectException()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Category Without Three Lenght")]
        public void CreateCategory_WithoutThreeLenght_ResultObjectException()
        {
            Action action = () => new Category(2, "Ca");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Category With Id Invalid")]
        public void CreateCategory_WithIdInvalid_ResultObjectException()
        {
            Action action = () => new Category(-1, "");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value.");
        }

        #endregion
    }
}
