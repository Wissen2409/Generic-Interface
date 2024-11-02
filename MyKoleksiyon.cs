

// kendi yazdığım generic bir sınıfa, kendi yazdığım bir generic interface'i impelement etmeye 
// çalışıyorum
public class MyKoleksiyon<T> : IListe<T>
{
    // yazdığım interface'den geldi!!
    public void Add(T value)
    {
        throw new NotImplementedException();
    }


    // CompareTo, yazdığım interface'e referans ettiğim interface'den geldi
    public int CompareTo(T? other)
    {
        throw new NotImplementedException();
    }
}