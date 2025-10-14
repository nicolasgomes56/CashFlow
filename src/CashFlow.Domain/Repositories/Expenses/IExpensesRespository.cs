using CashFlow.Domain.Entites;

namespace CashFlow.Domain.Repositories.Expenses;

public interface IExpensesRespository
{
    Task Add(Expense expense);
}
