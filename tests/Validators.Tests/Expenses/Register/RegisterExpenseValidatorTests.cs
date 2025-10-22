using CashFlow.Application.UseCases.Expenses;
using CashFlow.Communication.Enums;
using CashFlow.Exception;
using CommonTestUtilities.Requests;
using Shouldly;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        // Arrange - Configurar o cenário de teste
        var validator = new ExpenseValidator();
        var request = RequestRegisterExpensesJsonBuilder.Build();

        // Act - Executar a ação a ser testada
        var result = validator.Validate(request);

        // Assert - Verificar o resultado esperado
        result.IsValid.ShouldBeTrue();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void Error_Title_Empty(string title)
    {
        // Arrange
        var validator = new ExpenseValidator();
        var request = RequestRegisterExpensesJsonBuilder.Build();
        request.Title = title;

        // Act
        var result = validator.Validate(request);

        // Assert
        result.IsValid.ShouldBeFalse();
        result.Errors.Single().ErrorMessage.ShouldBe(ResourceErrorMessages.TITLE_REQUIRED);
    }

    [Fact]
    public void Error_Date_Future()
    {
        // Arrange
        var validator = new ExpenseValidator();
        var request = RequestRegisterExpensesJsonBuilder.Build();
        request.Date = DateTime.UtcNow.AddDays(1);

        // Act
        var result = validator.Validate(request);

        // Assert
        result.IsValid.ShouldBeFalse();
        result.Errors.Single().ErrorMessage.ShouldBe(ResourceErrorMessages.EXPENSES_CANNOT_FOR_THE_FUTURE);
    }

    [Fact]
    public void Error_PaymentType_Invalid()
    {
        // Arrange
        var validator = new ExpenseValidator();
        var request = RequestRegisterExpensesJsonBuilder.Build();
        request.PaymentType = (PaymentType)700; 

        // Act
        var result = validator.Validate(request);

        // Assert
        result.IsValid.ShouldBeFalse();
        result.Errors.Single().ErrorMessage.ShouldBe(ResourceErrorMessages.PAYMENTS_TYPE_INVALID);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-3)]
    public void Error_Amount_Invalid(decimal amount)
    {
        // Arrange
        var validator = new ExpenseValidator();
        var request = RequestRegisterExpensesJsonBuilder.Build();
        request.Amount = amount;

        // Act
        var result = validator.Validate(request);

        // Assert
        result.IsValid.ShouldBeFalse();
        result.Errors.Single().ErrorMessage.ShouldBe(ResourceErrorMessages.AMOUNT_MUST_BE_GREATER_THAN_ZERO);
    }
}