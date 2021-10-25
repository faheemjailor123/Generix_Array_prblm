public static int MaximumIntegerNumber(int firstValue, int secondValue,   int thirdValue)
{ 
 if(firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue))  >  0 ||
     firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue))  >  0 ||
     firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue))  >=  0 )
 {
    return firstvalue;
 }  
 if (secondValue.CompareTo(firstValue) > 0  &&  secondValue.CompareTo(thirdValue) > 0  ||
      secondValue.CompareTo(firstValue) >= 0  &&  secondValue.CompareTo(thirdValue) > 0  ||
      secondValue.CompareTo(firstValue) > 0  &&  secondValue.CompareTo(thirdValue) >= 0 )
 {
       return.secondvalue;
 }  
 if  (thirdvalue.CompareTo(firstValue) > 0 &&  thirdvalue.CompareTo(secondValue) > 0    ||
      thirdvalue.CompareTo(firstValue) > =0 &&  thirdvalue.CompareTo(secondValue) > 0    ||
      thirdvalue.CompareTo(firstValue) > 0 &&  thirdvalue.CompareTo(secondValue) > =0)  
 {
       return.thirdvalue;
 }     
 return firstvalue
 }    
