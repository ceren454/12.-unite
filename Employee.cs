using System;

public abstract class Employee
{
    public string FirstName { get; }
    public string LastName { get; }
    public string SocialSecurityNumber { get; }

    protected Employee(
        string firstName,
        string lastName,
        string socialSecurityNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurityNumber = socialSecurityNumber;
    }

    public override string ToString() =>
        $"{FirstName} {LastName}\n" +
        $"social security number: {SocialSecurityNumber}";

    public abstract decimal Earnings();
}
