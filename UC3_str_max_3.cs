public static string MaximumString(string firstString , string secondString, string thirdString)
{
  if(firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdstring) > 0 ||
    firstString.CompareTo(secondString) > =0 && firstString.CompareTo(thirdstring) > 0 ||
    firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdstring)>= 0 )
  {
       return firstString;
  } 
  if(secondString.CompareTo(firststring)> 0 &&  secondString.CompareTo(thirdstring) > 0  ||
      secondString.CompareTo(firststring)> = 0 &&  secondString.CompareTo(thirdstring) > 0  ||
      secondString.CompareTo(firststring)> 0 &&  secondString.CompareTo(thirdstring) >= 0)  
  {
       return secondString;
  }    
  if (thirdString.CompareTo(firstString)  > 0 && thirdString.CompareTo(secondString) > 0 ||
      thirdString.CompareTo(firstString)  > = 0 && thirdString.CompareTo(secondString) > 0 ||
      thirdString.CompareTo(firstString)  > 0 && thirdString.CompareTo(secondString) >= 0 )
  {
      return thirdString;
  }    
  return firstString;
}
