public class Address
{
    string _street;

    string _city;

    string _state;

    string _country;

    string _zipcode;

    public Address(string street, string city, string state, string country, string zipcode)
    {
        _street = street;

        _city = city;

        _state = state;

        _country = country;

        _zipcode = zipcode;
    }

    public string GetAddress()
    {
        return $"{_street} {_city}, {_state} {_zipcode} {_country}";
    }
}