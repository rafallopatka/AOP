class ExampleViewModel : INotifyPropertyChanged
{
    private string _firstName;
    private string _secondName;
    private string _lastName;
    private string _email;
    private string _address;
    private string _country;
    private string _city;
    private string _phone;

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (_firstName == value)
                return;

            _firstName = value;
            OnPropertyChanged();
        }
    }

    public string SecondName
    {
        get { return _secondName; }
        set
        {
            if (_secondName == value)
                return;

            _secondName = value;
            OnPropertyChanged();
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (_lastName == value)
                return;

            _lastName = value;
            OnPropertyChanged();
        }
    }

    public string Email
    {
        get { return _email; }
        set
        {
            if (_email == value)
                return;

            _email = value;
            OnPropertyChanged();
        }
    }

    public string Address
    {
        get { return _address; }
        set
        {
            if (_address == value)
                return;

            _address = value;
            OnPropertyChanged();
        }
    }

    public string Country
    {
        get { return _country; }
        set
        {
            if (_country == value)
                return;

            _country = value;
            OnPropertyChanged();
        }
    }

    public string City
    {
        get { return _city; }
        set
        {
            if (_city == value)
                return;

            _city = value;
            OnPropertyChanged();
        }
    }

    public string Phone
    {
        get { return _phone; }
        set
        {
            if (_phone == value)
                return;

            _phone = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
