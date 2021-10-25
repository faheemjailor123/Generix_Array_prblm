public class GenericMaximum<T>    where T : IComparable
{
    public  T[] value;
    12 references
    public  GenericMaximum(T[] value)
    {
       this.value = value;
    }
    1 reference
    public T[] sort(T[] values)
    {
      array.sort(values);
      return values;
    }
    2 references
    public T MaxValue(params  T[] values)
    {
       var sorted_values = sort(values);
       return sorted_values[^1];
    }
    11 references
    public T MaxMethod()
    {
       var max = MaxValues(this.value);
       return max ;
     }
     1 reference
     public void PrintMaxValue()
     {
       var max = MaxValue(this.value);
       Console.WriteLine("Maximum value is"  +max)
     }
     
     0 references
     static void Main(String[] args)
     {
     int[]  arr  = {112,344,432,555,965};
     GenericMaximum<int> generic = new GenericMaximum<int>(arr);
     generic.PrintMaxValue();
     }
