namespace Bookings.Domain.ValueObjects;

public record Person
{
  public string FamilyName { get; }
  public string GivenName { get; }
  public string OtherNames { get; }
  public string Title { get; }
  public string EmailAddress { get; }
  public string PhoneNumber { get; }

  public Person(string familyName, string givenName, string otherNames, string title, string emailAddress, string phoneNumber)
  {
    FamilyName = familyName;
    GivenName = givenName;
    OtherNames = otherNames;
    Title = title;
    EmailAddress = emailAddress;
    PhoneNumber = phoneNumber;
  }
}