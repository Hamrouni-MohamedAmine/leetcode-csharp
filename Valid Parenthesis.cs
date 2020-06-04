 public bool checkValidString (string s) {
     if (s.Length < 1)
         return true;
     int tempLeft = 0, tempRight = 0;

     for (int i = 0; i < s.Length; i++) {
         if (s[i] == ')')
             tempRight -= 1;
         else
             tempRight += 1;

         if (tempRight < 0)
             return false;

         if (s[(s.Length - 1) - i] == '(')
             tempLeft -= 1;
         else
             tempLeft += 1;

         if (tempLeft < 0)
             return false;

     }
     return true;
 }