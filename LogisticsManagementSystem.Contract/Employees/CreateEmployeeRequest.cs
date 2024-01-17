namespace LogisticsManagementSystem.Contract;

public record CreateEmployeeRequest(string? userName, string? phoneNumber, string password, string confirmPassword);
