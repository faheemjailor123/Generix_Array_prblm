public static double MaximumFloatNumber(double firstValue, double secondValue, double third Value)
{
 if (firstValue.CompareTo(secondValue) > 0 &&  firstValue.CompareTo(thirdValue) > 0  ||
     firstValue.CompareTo(secondValue) >= 0 &&  firstValue.CompareTo(thirdValue) > 0  ||
     firstValue.CompareTo(secondValue) > 0 &&  firstValue.CompareTo(thirdValue) >= 0)
 {
       return firstString;
 }    
 if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
     secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
     secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
{
     return  secondString;
}     
if  (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >  0  ||
     thirdValue.CompareTo(firstValue) > = 0 && thirdValue.CompareTo(secondValue) >  0  || 
     thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > = 0)
{
    return thirdValue;
 }
return firstValue;
}
