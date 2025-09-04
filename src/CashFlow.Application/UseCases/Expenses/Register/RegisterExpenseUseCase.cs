using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        //TODO: Validações e Regras de Negócio

        Validate(request);

        return new ResponseRegisterExpenseJson();
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);

        if (titleIsEmpty)
            throw new ArgumentException("O título é obrigatório");

        if (request.Amount <= 0)
            throw new ArgumentException("O valor deve ser maior que zero");

        var result = DateTime.Compare(request.Date, DateTime.UtcNow);

        if (result > 0)
            throw new ArgumentException("A data não pode ser maior que a data atual");

        var paymentsTypeIsValid = Enum.IsDefined(typeof(PaymentType), request.PaymentType);

        if (!paymentsTypeIsValid)
            throw new ArgumentException("O tipo de pagamento é inválido");
    }
}
