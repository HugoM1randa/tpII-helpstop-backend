using HelpApp.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace HelpApp.Domain.Test
{
    public class ProductUnitTest
    {

        #region Testes Positivos
        [Fact(DisplayName = "Create Product With Parameters Valid")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Name State")]
        public void CreateProduct_WithValidNameState_ResultObjectValidState()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Correct Name Lenght")]
        public void CreateProduct_WithCorrectNameLenght_ResultObjectValidState()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Description State")]
        public void CreateProduct_WithValidDescriptionState_ResultObjectValidState()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Description Lenght")]
        public void CreateProduct_WithValidDescriptionLenght_ResultObjectValidState()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Right Price")]
        public void CreateProduct_WithRightPrice_ResultObjectValidState()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Right ValueOn Stock")]
        public void CreateProduct_WithValueOnStock_ResultObjectValidState()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Right Image Lenght")]
        public void CreateProduct_WithRightImageLenght_ResultObjectValidState()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        #endregion

        #region Testes Negativos

        [Fact(DisplayName = "Create Product With Negative Id")]
        public void CreateProduct_WithNegativeId_ResultObjectException()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Update Invalid Id value");
        }

        [Fact(DisplayName = "Create Product With Empty Name")]
        public void CreateProduct_WithEmptyName_ResultObjectException()
        {
            Action action = () => new Product("", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product With Null Name")]
        public void CreateProduct_WithEmptyNull_ResultObjectException()
        {
            Action action = () => new Product(null, "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product Without Three Lenght on Name")]
        public void CreateProduct_WithoutThreeLenghtOnName_ResultObjectException()
        {
            Action action = () => new Product("po", "Product Description", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Product With Empty Description")]
        public void CreateProduct_WithEmptyDescription_ResultObjectException()
        {
            Action action = () => new Product("Product Name", "", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, name is required.");
        }

        [Fact(DisplayName = "Create Product With Null Description")]
        public void CreateProduct_WithEmptyNullDescription_ResultObjectException()
        {
            Action action = () => new Product("Product Name", null, 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, name is required.");
        }

        [Fact(DisplayName = "Create Product Without Five Lenght on Description")]
        public void CreateProduct_WithoutFiveLenghtOnDescription_ResultObjectException()
        {
            Action action = () => new Product("Product Name", "po", 9.99m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 5 characters.");
        }

        [Fact(DisplayName = "Create Product With Invalid Price")]
        public void CreateProduct_WithInvalidPrice_ResultObjectException()
        {
            Action action = () => new Product("Product Name", "Product Description", -2.0m, 99, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price negative value.");
        }

        [Fact(DisplayName = "Create Product With Invalid Stock")]
        public void CreateProduct_WithInvalidStock_ResultObjectException()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, -2, "/img/productimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock negative value.");
        }

        [Fact(DisplayName = "Create Product With Too Long Image")]
        public void CreateProduct_WithTooLongImage_ResultObjectException()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 100, "/img/productimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimageproductimage.jpg");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, too long, maximum 250 characters.");
        }

        [Fact(DisplayName = "Create Product With Empty Image")]
        public void CreateProduct_WithEmptyImage_ResultObjectException()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 100, "");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, name is required");
        }


        #endregion


    }
}
