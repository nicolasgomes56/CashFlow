﻿using AutoMapper;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UseCases.Expenses.GetById;

public class GetByIdExpenseUseCase : IGetByIdExpenseUseCase
{
    private readonly IExpensesReadOnlyRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdExpenseUseCase(IExpensesReadOnlyRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ResponseExpensesJson> Execute(long id)
    {
        var result = await _repository.GetById(id);

        if (result is null)
            throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);

        return _mapper.Map<ResponseExpensesJson>(result);
    }
}
