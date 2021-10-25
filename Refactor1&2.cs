public class GenericMaximum <T> Where T : IComparable
{
    public T firstValue, secondValue, thirdValue;
 12 refrences
public GenericMaximum (T firstValue, T secondValue, T thirdValue)
{
this.firstValue= firstValue;
this.secondValue  secondValue;
this.thirdValue thirdValue;
}


1 refrence
public static T maxValue(T firstValue, T  secondValue, T thirdValue)
{
    if(firstValue.compareTo(secondValue)> 0  && firstValue.compareto(thirdValue)> 0 ||
        firstValue.compareTo(secondValue)> =0   && firstValue.compareto(thirdValue)> 0 ||
        firstValue.compareTo(secondValue)>0  && firstValue.compareto(thirdValue)>=0)
    {
        return firstValue;
    }
    if(secondValue.CompareTo(firstValue)  > 0  &&  secondValue.CompareTo(thirdValue)  > 0  ||
       secondValue.CompareTo(firstValue)  >= 0  &&  secondValue.CompareTo(thirdValue)  > 0  ||
       secondValue.CompareTo(firstValue)  > 0  &&  secondValue.CompareTo(thirdValue)  >=0 )
    {
       return secondValue;
    }     
    if(thirdValue.CompareTo(firstValue)  > 0 &&  thirdValue.CompareTo(secondValue) > 0 ||
       thirdValue.CompareTo(firstValue)  >= 0 &&  thirdValue.CompareTo(secondValue) > 0 ||
       thirdValue.CompareTo(firstValue)  > 0 &&  thirdValue.CompareTo(secondValue) >= 0) 
    {
          return thirdValue;    
    }
    return default;
}    

11 references
public T MaxMethod()
 {
      T max  = GenericMaximum<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
      return max;
  }      
}


