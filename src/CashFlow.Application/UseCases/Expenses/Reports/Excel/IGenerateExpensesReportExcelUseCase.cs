namespace CashFlow.Application.UseCases.Expenses.Reports;

public interface IGenerateExpensesReportExcelfUseCase
{
    Task<byte[]> Execute(DateOnly month);
}