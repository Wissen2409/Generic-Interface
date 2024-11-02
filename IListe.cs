

// Bir interface generic olabilir!!
// Aynı zamanda başka bir interface'i implementde edebilir
// Başka bir generic interface'i implement ettiğinde, generic interface'in generic tipi,
// implement edilen interface'e de verilmelidir!!


public interface IListe<T>:IComparable<T>
{

    public void Add(T value);
}