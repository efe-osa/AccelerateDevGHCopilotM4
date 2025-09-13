using NSubstitute;
using Library.Infrastructure.Data;
using Library.ApplicationCore.Entities;
using Library.ApplicationCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace UnitTests.Infrastructure.JsonLoanRepositoryTests;

public class GetLoanTest
{
    private readonly ILoanRepository _mockLoanRepository;
    private readonly JsonLoanRepository _jsonLoanRepository;
    private readonly IConfiguration _configuration;
    private readonly JsonData _jsonData;

    public GetLoanTest()
    {
        _mockLoanRepository = Substitute.For<ILoanRepository>();
        _configuration = new ConfigurationBuilder().Build();
        _jsonData = new JsonData(_configuration);
        _jsonLoanRepository = new JsonLoanRepository(_jsonData);
    }

    [Fact(DisplayName = "JsonLoanRepository.GetLoan: Returns loan when loan ID exists")]
    public async Task GetLoan_ReturnsLoan_WhenLoanIdExists()
    {
        // Arrange
        int loanId = 1; // use a Loan ID 1 since it exists in Loans.json
        var expectedLoan = new Loan
        {
            Id = loanId,
            BookItemId = 17,
            PatronId = 22,
            LoanDate = DateTime.Parse("2023-12-08T00:40:43.1808862"),
            DueDate = DateTime.Parse("2023-12-22T00:40:43.1808862"),
            ReturnDate = null
        };
        _mockLoanRepository.GetLoan(loanId).Returns(expectedLoan);

        // Act
        var actualLoan = await _jsonLoanRepository.GetLoan(loanId);

        // Assert
        Assert.NotNull(actualLoan);
        Assert.Equal(expectedLoan.Id, actualLoan!.Id);
    }

    [Fact(DisplayName = "JsonLoanRepository.GetLoan: Returns null when loan ID does not exist")]
    public async Task GetLoan_ReturnsNull_WhenLoanIdDoesNotExist()
    {
        // Arrange
        int loanId = 999; // use a non-existing Loan ID

        // Act
        var actualLoan = await _jsonLoanRepository.GetLoan(loanId);

        // Assert
        Assert.Null(actualLoan);
    }
}
