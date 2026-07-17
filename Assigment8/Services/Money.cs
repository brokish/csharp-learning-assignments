namespace Assigment8.Services;

public class Money
{
    public double Amount;

    public Money(double amount)
    {
        Amount = amount;
    }

    public static Money operator +(Money m1, Money m2)
    {
        return new Money(m1.Amount + m2.Amount);
    }

    public static Money operator -(Money m1, Money m2)
    {
        return new Money(m1.Amount - m2.Amount);
    }

    public static bool operator ==(Money m1, Money m2)
    {
        if (ReferenceEquals(m1, null) || ReferenceEquals(m2, null)) return ReferenceEquals(m1, m2);
        return m1.Amount == m2.Amount;
    }

    public static bool operator !=(Money m1, Money m2)
    {
        return !(m1 == m2);
    }
}