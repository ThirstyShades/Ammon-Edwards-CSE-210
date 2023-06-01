public class Loanable
{
    // Attributes
    private bool _isCheckedIn = true;
    // string _title; breakign the code

    public void checkOut()
    {
        _isCheckedIn = false;
    }

    public void checkIn()
    {
    _isCheckedIn = true;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Avalible: {_isCheckedIn}");
    }
}
